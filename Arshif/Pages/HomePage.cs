using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arshif.Pages
{
    public partial class HomePage : DevExpress.XtraEditors.XtraUserControl
    {
        DBAREntities db;
        int Depcount, Usercount, Archivecount;
        double Datacount1, Datacount2, Datacount3, Datacount4, Datacount5;
        private double TotalSize;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PL.SearchResult search = new PL.SearchResult();
            search.SearchText = edt_search.Text;
            search.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            AddPage.AddNewFileFromHome addNewFileFromHome = new AddPage.AddNewFileFromHome();
            addNewFileFromHome.Show();
        }

        public HomePage()
        {
            InitializeComponent();
            db= new DBAREntities();

        }

        private void LoadDep()
        {
            try
            {
                Depcount = db.TBDeps.Select(x => x.ID).ToList().Count;
            }
            catch
            {

            }
        }
        private void LoadUser()
        {
            try
            {
                Usercount = db.TBUSERS.Select(x => x.ID).ToList().Count;
            }
            catch
            {

            }
        }
        private void LoadArcive()
        {
            try
            {
                Archivecount = db.TBArchiveCategories.Select(x => x.ID).ToList().Count;
            }
            catch
            {

            }
        }

        private void LoadData()
        {
            try
            {
                Datacount1 =(double) db.TBArchiveFiles.Select(x => x.FileSize1).ToArray().Sum();
                Datacount2 = (double)db.TBArchiveFiles.Select(x => x.FileSize2).ToArray().Sum();
                Datacount3 = (double)db.TBArchiveFiles.Select(x => x.FileSize3).ToArray().Sum();
                Datacount4 = (double)db.TBArchiveFiles.Select(x => x.FileSize4).ToArray().Sum();
                Datacount5 = (double)db.TBArchiveFiles.Select(x => x.FileSize5).ToArray().Sum();
                TotalSize=(Datacount1+Datacount2+Datacount3+Datacount4+Datacount5)*0.000001;
            
            }
            catch
            {

            }
        }

        private async void HomePage_Load(object sender, EventArgs e)
        {
            // load dep
            await Task.Run(()=>LoadDep());
            await Task.Run(()=>LoadArcive());
            await Task.Run(()=>LoadData());
            await Task.Run(()=>LoadUser());
            txt_depcount.Text=Depcount.ToString();
            txt_usercount.Text=Usercount.ToString();
            txt_archivecount.Text= Archivecount.ToString();
            txt_datasize.Text=TotalSize.ToString("#0.00");
        }
    }
}
