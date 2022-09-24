using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using CsvLib;

namespace CCSoundTrans
{
    public partial class FrmMain : Form
    {
        OdbcConnection conOdbc;
        OdbcCommand cmdSound;
        SqlCommand cascommand;
        DataTable cdrdata;
        string source;
        string destination;
        string sshuser;
        string sshpass;
        string sship;
        string dosyaad;

        private bool Baglan()
        {
            try
            {
                conOdbc = new OdbcConnection("Dsn=callserver;uid=root");
                conOdbc.Open();
                lblServer.Text = "Ses Kayýt Sunucusu: " + conOdbc.DataSource.ToString();
                return true;
            }
            catch (Exception E)
            {
                MessageBox.Show("Veri tabaný açýlamadý!" + E.Message.ToString());
                return false;
            }
        }

        private void WriteSSHLog(string logdata)
        {
            try
            {
                lstState.Items.Insert(0,DateTime.Now.ToString("HH:mm:ss")+": "+logdata);
            }
            catch 
            {
                   
            }
        }

        private void ReadConf()
        {
            try
            {
                source = CCSoundTrans.Properties.Settings.Default.filesrc;
                destination = CCSoundTrans.Properties.Settings.Default.filedes;
                sshuser = CCSoundTrans.Properties.Settings.Default.sshuser;
                sshpass = CCSoundTrans.Properties.Settings.Default.sshpass;
                sship = CCSoundTrans.Properties.Settings.Default.sship;
                WriteSSHLog("Kayýt Dizini:" + source);
                WriteSSHLog("S.K Dizini:" + destination);
                WriteSSHLog("S.K Server" + sship);
                if (!Directory.Exists(destination))
                    Directory.CreateDirectory(destination);
            }
            catch
            {
                MessageBox.Show("Ayarlar okunamadý!");
            }
        }

        private DataTable GetData(string sdata,string state,string sure,DateTime datesound1, DateTime datesound2 )
        {
            DateTime startdt;
            DateTime stopdt;
            startdt = datesound1;
            stopdt = datesound2;
            stopdt = stopdt.AddHours(23);
            stopdt = stopdt.AddMinutes(59);
            stopdt = stopdt.AddSeconds(59);

            string sqlstr = "SELECT uniqueid as No,clid as CLID,"+
                //"DATE_FORMAT(calldate,'%Y-%m-%d %H:%i:%s') as Tarih,"+
                "adddate(calldate,INTERVAL (duration-billsec) second) as Tarih,"+
                "src as Arayan,dst Aranan" +
                ",dstchannel as Kanal,duration as Süre" +
                ",billsec as KonuþmaSüre,disposition as Durum,userfield as DosyaAd" +
                " FROM cdr WHERE calldate between " +
                "'" + startdt.ToString("yyyy-MM-dd HH:mm:ss") + "'" + " and " +
                "'" + stopdt.ToString("yyyy-MM-dd HH:mm:ss") + "'" +
                " and (src like '%" + sdata + "%'"+
                " or dstchannel like '%" + sdata + "%'"+
                " or clid like '%" + sdata + "%'" +
                " or uniqueid like '%" + sdata + "%'" +
                " or dst like '%" + sdata + "%')" +
                " and billsec >= " + sure;
            if (state != "ALL")
            {
                sqlstr += " and disposition = '" + state + "'";
            }

            cmdSound = new OdbcCommand(sqlstr, conOdbc);
            OdbcDataAdapter da = new OdbcDataAdapter(cmdSound);
            DataTable dt = new DataTable("cdr");

            try
            {
                da.Fill(dt);
                return dt;
            }
            catch (Exception E)
            {
                MessageBox.Show("Hata:" + E.Message.ToString());
                return null;
            }
        }


        private bool PlayFile(string File)
        {
            string tmpdosya;


            try
            {
                tmpdosya = File.Remove(0, 6);
                plFile.URL = destination + "/tmpsound.wav"; //+ tmpdosya;
                plFile.Ctlcontrols.play();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //ls /var/spool/asterisk/monitor
        private bool listSound(string dir)
        {
            try
            {
                SSHTransfer ssht = new SSHTransfer(sshuser, sshpass, sship);
                try
                {
                    if (!ssht.Connect())
                        return false;
                    else
                        WriteSSHLog("SSH Sunucusuna Baðlanýldý!:" + sship);


                   string[] res = ssht.ListFile(dir).Split('\n');
                   foreach (string ff in res)
                   {
                       lstState.Items.Add(ff);
                       //string[] ffs = ff.Split('-');
                       //ssht.RenameFile(source + "/" + ff, source + "/" + ffs[ffs.Length - 1]);
                       //listBox1.Items.Add(ff + " > " + ffs[ffs.Length - 1]);
                       Application.DoEvents();
                   }
                   
                }
                finally
                {
                    ssht.DisconnectScp();
                    WriteSSHLog("SSH sunucusu baðlatý kesildi.:" + sship);
                }

                return true;
            }
            catch
            {
                return false;
            }

        }


        private bool Yedekle(DataTable SData,bool delete)
        {
            try
            {
                SSHTransfer ssht = new SSHTransfer(sshuser, sshpass, sship);
                try
                {
                    if (!ssht.Connect())
                        return false;
                    else
                        WriteSSHLog("SSH Sunucusuna Baðlanýldý!:" + sship);

                    foreach (DataRow cl in SData.Rows)
                    {
                        string dosya = cl["DosyaAd"].ToString();
                        string tmpdosya = dosya.Remove(0, 6);

                        if (!ssht.DownloadFile(source + "/" + tmpdosya, destination + "/" + tmpdosya))
                        {
                            WriteSSHLog("Hata dosya transfer edililemedi!:" + tmpdosya);
                        }
                        else
                        {
                            if (delete)
                                if (!ssht.DeleteFile(source + "/" + tmpdosya))
                                    WriteSSHLog("Dosya silinemedi!:" + tmpdosya);   
                        }
                        pbYedek.Value += 1;
                        pbYedek.Update();
                        Application.DoEvents();
                    }

                }
                finally
                {
                    ssht.DisconnectScp();
                    WriteSSHLog("SSH sunucusu baðlatý kesildi.:" + sship);
                }
                
                return true;
            }
            catch
            {
                return false;
            }


        }


        private bool TransferEt(string DosyaAd)
        {
            string tmpdosya;
          

            try
            {
                if (DosyaAd.StartsWith("audio"))
                {
                    tmpdosya = DosyaAd.Remove(0, 6);
                }
                else
                {
                    tmpdosya = DosyaAd;
                }
                
                SSHTransfer ssht = new SSHTransfer(sshuser, sshpass, sship);
                if (!ssht.Connect())
                {
                    MessageBox.Show("SSH baðlantýsý yapýlamadý.");
                    return false;
                }

                //WriteSSHLog("SSH sunucusuna baðlanýldý");
                try
                {
                    plFile.Ctlcontrols.stop();
                    plFile.close();
                    if (File.Exists(destination + "/tmpsound.wav"))
                        File.Delete(destination + "/tmpsound.wav");
                    //WriteSSHLog("Dosya transfer ediliyor...");
                    if (!ssht.DownloadFile(source + "/" + tmpdosya, destination + "/tmpsound.wav" ))
                    {
                        WriteSSHLog("Hata !: " + tmpdosya);
                        return false;
                        //if (!ssht.DeleteFile(source + "/OUT207-20101130-164339-1291128219.4.wav"))
                        //{
                        //    MessageBox.Show("Dosya silinemedi");
                        //}
                    }
                }
                finally
                {
                    ssht.DisconnectScp();
                    //WriteSSHLog("SSH sunucusu baðlatý kesildi");
                }

                WriteSSHLog("Baþarýlý: " + tmpdosya);
                return true;
            }
            catch
            {
                return false;
            }
        }



        public FrmMain()
        {
            InitializeComponent();
        }

    
        private void btnSearch_Click(object sender, EventArgs e)
        {
            cdrdata = GetData(txtSearch.Text.Trim(),cmdState.Text,txtKonSure.Text, dtTarih1.Value, dtTarih2.Value);
            grdSound.DataSource = cdrdata;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ReadConf();
            dtTarih1.Value = DateTime.Today;
            dtTarih2.Value = DateTime.Today;
            dtBackBas.Value = DateTime.Today;
            dtBackBit.Value = DateTime.Today;

            Baglan();
        }


        private void grdSound_SelectionChanged(object sender, EventArgs e)
        {
            dosyaad = (string)grdSound.CurrentRow.Cells["No"].Value + ".WAV";
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            if (TransferEt(dosyaad))
            {
                PlayFile(dosyaad);
            }
        }

        
        private void btnRecShow_Click(object sender, EventArgs e)
        {
            cdrdata = GetData("","ANSWERED","1", dtBackBas.Value, dtBackBit.Value);
            grdSound.DataSource = cdrdata;
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            try
            {
                cdrdata = GetData("", "ANSWERED", "1", dtBackBas.Value, dtBackBit.Value);
                grdSound.DataSource = cdrdata;
                pbYedek.Minimum = 0;
                pbYedek.Maximum = cdrdata.Rows.Count;
                pbYedek.Value = 0;
                try
                {
                    if (!Directory.Exists(destination+"/data"))
                        Directory.CreateDirectory(destination + "/data"); 

                    string Csvstr = CsvLibrary.ExportCsv(";", cdrdata, true);
                    string file = destination + "/data/" +
                        dtTarih1.Value.Day + "_" + dtTarih1.Value.Month + "_" + dtTarih1.Value.Year + "  " +
                        dtTarih2.Value.Day + "_" + dtTarih2.Value.Month + "_" + dtTarih2.Value.Year + ".csv";
                    lstState.Items.Insert(0, "Data dosyasý: " + file);
                    
                    if (File.Exists(file))
                        File.Delete(file);

                    FileStream fs = new FileStream(file,FileMode.Create);
                    StreamWriter sr = new StreamWriter(fs);
                    sr.Write(Csvstr);
                    sr.Close();
                    fs.Close();
                }
                catch (Exception E) 
                {
                    MessageBox.Show("Hata! Veritabani dosyasý yedeklenemedi:" + E.Message.ToString());
                }
                
                if (chkDelete.Checked)
                    Yedekle(cdrdata, true);
                else
                    Yedekle(cdrdata, false);
            }
            catch 
            {
                WriteSSHLog("Yedekleme Ýþlemi Baþarýsýz.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (TransferEt(dosyaad))
                {
                    lstState.Items.Insert(0, dosyaad + " transfer edildi.");
                    SaveFileDialog DialogSave = new SaveFileDialog();
                    DialogSave.DefaultExt = "wav";
                    // Available file extensions
                    DialogSave.Filter = "Wav file (*.wav)|*.wav";
                    // Adds a extension if the user does not
                    DialogSave.AddExtension = true;
                    // Restores the selected directory, next time
                    DialogSave.RestoreDirectory = true;
                    // Dialog title
                    DialogSave.Title = "Ses dosyasý kayýt yeri";
                    // Startup directory
                    DialogSave.InitialDirectory = @"C:/";

                    // Show the dialog and process the result
                    if (DialogSave.ShowDialog() == DialogResult.OK)
                    {
                        string tmpdosya = dosyaad.Remove(0, 6);
                        tmpdosya = destination + "/tmpsound.wav" ;
                        lstState.Items.Insert(0, "Kaynak: " + tmpdosya);
                        lstState.Items.Insert(0, "Hedef: " + DialogSave.FileName);
                        File.Copy(tmpdosya, DialogSave.FileName);
                    }
                    DialogSave.Dispose();
                    DialogSave = null;

                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Hata ! " + E.Message.ToString());
            }
        }

        private void grdSound_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TransferEt(dosyaad))
            {
                PlayFile(dosyaad);
            }
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            listSound(source);
        }

        private void conCAS_InfoMessage(object sender, OdbcInfoMessageEventArgs e)
        {

        }

       

       

        
    }
}