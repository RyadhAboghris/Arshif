using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Tile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arshif.AddPage
{
    public partial class AddNewFileFromHome : DevExpress.XtraEditors.XtraForm
    {
        DBAREntities db;
        TBArchiveCategory tbadd;
        List<string> ListCategory;
        int id;
        string DepName, UserRole;
        public AddNewFileFromHome()
        {
            InitializeComponent();
            DepName = Properties.Settings.Default.UserDep;
            db = new DBAREntities();

        }
        private void GetCategotyName()
        {
            try
            {
                
                 ListCategory = db.TBArchiveCategories.Where(x=>x.UserDep==DepName).Select(x => x.ArchiveTitle).ToList();
            }
            catch
            {

            }
        }
        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private async void AddNewFileFromHome_Load(object sender, EventArgs e)
        {
            // load
            await Task.Run(() => GetCategotyName());
            comboBox1.DataSource = ListCategory;
        }
        private void setCatData(string CatName)
        {
            try
            {
                tbadd = db.TBArchiveCategories.Where(x => x.ArchiveTitle == CatName).FirstOrDefault();
            }
            catch
            {

            }
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var CatName = comboBox1.SelectedItem.ToString();
                await Task.Run(() => setCatData(CatName));
                PL.ArchiveFileForm archive = new PL.ArchiveFileForm();
                id = tbadd.ID;
                archive.lb_id.Text = id.ToString();
                archive.ArchiveID = id;
                archive.lb_archivename.Text = tbadd.ArchiveTitle;
                archive.lb_archdep.Text = tbadd.UserDep;
                archive.Show();

            }
            catch { }
        }
    }
}