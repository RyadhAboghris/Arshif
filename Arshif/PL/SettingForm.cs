using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Arshif.PL
{
    public partial class SettingForm : DevExpress.XtraEditors.XtraForm
    {
        DBAREntities db;
        string msg;
        public int start;
        public SettingForm()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_savegen_Click(object sender, EventArgs e)
        {
            saveSetting();
        }
        private void saveSetting()
        {
            try
            {
                Properties.Settings.Default.CompanyName = edt_componyname.Text;
                Properties.Settings.Default.CompanyDes = edt_componydes.Text;

                // set logo
                var ma = new MemoryStream();
                pic_logo.Image.Save(ma,System.Drawing.Imaging.ImageFormat.Png);
                Properties.Settings.Default.CompanyLogo = Convert.ToBase64String(ma.ToArray());
                Properties.Settings.Default.Save();
                MessageBox.Show("تم حفظ الاعدادات");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            GetSettings();
        }
        private void GetSettings()
        {
            try
            {
                edt_componyname.Text= Properties.Settings.Default.CompanyName  ;
                edt_componydes.Text= Properties.Settings.Default.CompanyDes ;

                // set logo
                var bytimage = Convert.FromBase64String(Properties.Settings.Default.CompanyLogo);
                if(bytimage != null)
                {
                    var ma = new MemoryStream(bytimage);
                    pic_logo.Image=Image.FromStream(ma);
                }
            
            }
            catch 
            {
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            setContype();
        }
        private void setContype()
        {
            if (radioButton1.Checked == true)
            {
                edt_port.Enabled = false;
                edt_username.Enabled = false;
                edt_password.Enabled = false;
            }
            else
            {
                edt_port.Enabled = true;
                edt_username.Enabled = true;
                edt_password.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_saveconstring_Click(object sender, EventArgs e)
        {
            //method to save
            saveConstring();
            // method to ecyp constring
            Encrypteconstring();

        }

        private void saveConstring()
        {
            // get input
            var server = edt_servername.Text;
            var dbname = edt_database.Text;
            var port = "," + edt_port.Text;
            var user = edt_username.Text;
            var password = edt_password.Text;   


            if(radioButton1.Checked== true)
            {
                // local con
                var conString = @"metadata=res://*/DBAR.csdl|res://*/DBAR.ssdl|res://*/DBAR.msl;provider=System.Data.SqlClient;provider connection string=';data source=" + server + ",1433;initial catalog=" + dbname + ";integrated security=True;MultipleActiveResultSets=True;App=EntityFramework';";





                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionStringsSection.ConnectionStrings["DBAREntities"].ConnectionString = conString;
                config.Save();
                ConfigurationManager.RefreshSection("connectionStrings");

                MessageBox.Show("سيتم اعادة تشغيل البرنامج لتطبيق الاعدادات", "تم تحديث الاتصال بنجاح");
                Application.Restart();

            }
            else
            {
                // local con
                var conString = @"metadata=res://*/DBAR.csdl|res://*/DBAR.ssdl|res://*/DBAR.msl;provider=System.Data.SqlClient;provider connection string=';data source=" + server + port + ";initial catalog=" + dbname + ";user id="+user+";password="+password+";connect Timeout=60;MultipleActiveResultSets=True;App=EntityFramework';";

                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionStringsSection.ConnectionStrings["DBAREntities"].ConnectionString = conString;
                config.Save();
                ConfigurationManager.RefreshSection("connectionStrings");

                MessageBox.Show("سيتم اعادة تشغيل البرنامج لتطبيق الاعدادات", "تم تحديث الاتصال بنجاح");
                Application.Restart();
            }


        }
        private void Encrypteconstring()
        {
            var config=ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            ExeConfigurationFileMap configFileMap= new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = config.FilePath;
            System.Configuration.Configuration myConfig = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);

            ConnectionStringsSection section = myConfig.GetSection("connectionStrings") as ConnectionStringsSection;


            if (section.SectionInformation.IsProtected)
            {
                //Remove encryption
                section.SectionInformation.UnprotectSection();
            }
            else
            {
                // Encrypt the section
                section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
            }
            myConfig.Save();

        }

        private async void btn_backup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd= new FolderBrowserDialog();
           var rs = fbd.ShowDialog();
            if (rs==DialogResult.OK)
            {
                loading.Visible = true;
                var state = await Task.Run(() => Backup(fbd));
                if (state == true)
                {
                    MessageBox.Show(" تمت عملية النسخ الاحتياطي بنجاح");
                }
                else
                {
                    MessageBox.Show(msg);
                }

                loading.Visible = false;
            }
          

        }

        private bool Backup(FolderBrowserDialog folder)
        {
            try {
                db = new DBAREntities();

                string dbname = db.Database.Connection.Database;
                string dbBackup = "DBAR" + DateTime.Now.ToString("yyyyMMddHHmm");
                var fullpath= folder.SelectedPath.ToString() + dbBackup + ".bak";
                string sqlCommand = @"BACKUP DATABASE [{0}] TO DISK ='" + fullpath + "'WITH NOFORMAT,NOINIT,NAME=N'DBAR',SKIP,NOREWIND,NOUNLOAD,STATS=10";
                int path = db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlCommand, dbname, dbBackup));
                    return true;
                    
                    } catch (Exception ex) {
                msg = ex.Message;
        
                    return false;
                
            }
        }

        private void SettingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (start == 1)
            {
                Application.Exit();
            }
        }
    }
}