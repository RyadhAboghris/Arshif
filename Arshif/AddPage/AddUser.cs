using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arshif.AddPage
{
    public partial class AddUser : DevExpress.XtraEditors.XtraForm
    {
        // database and tables
        DBAREntities db;
        TBUSER tbadd;

        // other var 
        public int id;
        public int depid;
        public List<string> DepNameList;
        public int start;

        public Pages.UsersPage page;
        bool state;

        public  AddUser() {
            
            
            InitializeComponent(); 
        
        
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            if (edt_name.Text == "" || edt_username.Text == "" || edt_password.Text == "" || edt_dep.SelectedItem == null || edt_role.SelectedItem == null || depid == null)
            {
                MessageBox.Show("خطأ ادخال", "اكمل الحقول لطفا", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // set Data 
                // check if add or edit
                if (id == 0)
                // add
                {
                    tbadd = new TBUSER
                    {
                        IDDep = depid,
                        FullName = edt_name.Text,
                        UserName = edt_username.Text,
                        Password = edt_password.Text,
                        DepName = edt_dep.Text,
                        UserRole = edt_role.Text,
                    };
                }
                // edit
                else
                {
                    tbadd = new TBUSER
                    {
                        ID = id,
                        IDDep = depid,
                        FullName = edt_name.Text,
                        UserName = edt_username.Text,
                        Password = edt_password.Text,
                        DepName = edt_dep.Text,
                        UserRole = edt_role.Text,
                    };
                }
                // add or edit
                loading.Visible = true;
                var result = await Task.Run(() => addorEdit(tbadd));
                if (result == true)
                {
                    
                    toastNotificationsManager1.ShowNotification("9953fd39-6ba8-4c1d-a304-138c8944a086");
                    if (start == 1)
                    {
                        start = 0;
                        Application.Restart();
                    }
                    else
                    {
                        // reload data
                        page.LoadData();
                    }
                    
                    Close();
                }
                else
                {
                    MessageBox.Show("خطأ في الاتصال", "تأكد من الاتصال في السيرفر", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                loading.Visible = false;

            }
        }

        // add or edit
        private bool addorEdit(TBUSER data)
        {
            try
            {
                db = new DBAREntities();
                db.Set<TBUSER>().AddOrUpdate(data);
                db.SaveChanges();
                state = true;
            }
            catch
            {

                state = false;
            }
            return state;
        }

        private bool loadDepName()
        {
            try
            {
                db = new DBAREntities();


                DepNameList = db.TBDeps.Select(x => x.DepName).ToList();
                state = true;
            } catch
            {
                state = false;
            }
            return state;
        }

        private async void AddUser_Load(object sender, EventArgs e)
        {
            loading.Visible = true;
            var rs = await Task.Run(() => loadDepName());
            if(rs == true)
            {
                edt_dep.DataSource = DepNameList;
            } else
            {
                MessageBox.Show(
                    "خطأ في الاتصال",
                    "تأكد من الاتصال في السيرفر",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            loading.Visible = false;
        }

        private async void edt_dep_SelectedIndexChanged(object sender, EventArgs e)
        {
            loading.Visible = true;
            string DepName = edt_dep.Text;
            var rs = await Task.Run(() => loadDepID(DepName));
            if(rs == false)
            {
                MessageBox.Show(
                    "خطأ في الاتصال",
                    "تأكد من الاتصال في السيرفر",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            loading.Visible = false;
        }

        private bool loadDepID(string DepName)
        {
            try
            {
                db = new DBAREntities();
                depid = db.TBDeps.Where(x => x.DepName == DepName).Select(x => x.ID).First();
                state = true;
            } catch
            {
                state = false;
            }
            return state;
        }

        private void AddUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(start == 1)
            {
                Application.Exit();
            }
        }
    }
}