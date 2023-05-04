using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Arshif
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public Main()
        {
            InitializeComponent();
            loadHomePage();
        }
        // load home page
        private void btn_home_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            loadHomePage();
        }
        private void loadHomePage()
        {
            Pages.HomePage page= new Pages.HomePage();
            loadPage(page);
        }

        // load page method
        private void loadPage(DevExpress.XtraEditors.XtraUserControl page)
        {
            try {
            var oldpage=pn_container.Controls.OfType<XtraUserControl>().FirstOrDefault();
                if(oldpage != null)
                {
                    pn_container.Controls.Remove(oldpage);
                    oldpage.Dispose();
                }
                page.Dock = DockStyle.Fill;
                pn_container.Controls.Add(page);
            
            }catch { }
        }

        private void pn_container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_dep_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Pages.DepPage page = new Pages.DepPage();
            loadPage(page);
        }

        private void btn_users_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Pages.UsersPage page = new Pages.UsersPage();
            loadPage(page);
        }

        private void btn_archive_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Pages.ArchiveCatPage page = new Pages.ArchiveCatPage();
            loadPage(page);
        }

        private void btn_setting_ItemClick(object sender, TileItemEventArgs e)
        {
            PL.SettingForm setting = new PL.SettingForm();
            setting.Show();
        }

        private void btn_help_ItemClick(object sender, TileItemEventArgs e)
        {
            AddPage.LoginForm loginForm = new AddPage.LoginForm();
            loginForm.Show();
            Hide();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
