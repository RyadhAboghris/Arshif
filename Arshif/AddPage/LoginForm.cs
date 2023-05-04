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
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        // database and tables
        DBAREntities db;
        TBUSER tbadd;

        // other var 
        public int id;
        public int depid;
        public List<string> DepNameList;

        public Pages.UsersPage page;
        bool state;

        public  LoginForm() {
            InitializeComponent(); 
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            if ( edt_username.Text == "" || edt_password.Text == "" )
            {
                MessageBox.Show("خطأ ادخال", "اكمل الحقول لطفا", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // set Data 
                // check if add or edit
              
              
                // add or edit
                loading.Visible = true;
                var userName=edt_username.Text;
                var password=edt_password.Text;
                var result = await Task.Run(() => LoginCheck(userName, password));
                if (result == true)
                {
                    // sign in
                    Main main = new Main();
                    // ser user data
                    Properties.Settings.Default.UserID = tbadd.ID;
                    Properties.Settings.Default.FullName = tbadd.FullName;
                    Properties.Settings.Default.UserName = tbadd.UserName;
                    Properties.Settings.Default.UserRole = tbadd.UserRole;
                    Properties.Settings.Default.UserDep = tbadd.DepName;
                    Properties.Settings.Default.Save();
                    // role
                    if (tbadd.UserRole == "مستخدم")
                    {
                        main.btn_dep.Visible = false;
                        main.btn_users.Visible = false;
                    }
                    main.Show();
                   
                    Hide();
                }
                else
                {
                    MessageBox.Show("خطأ في تسجيل الدخول", "خطأ في معلومات تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                loading.Visible = false;

            }
        }

        // add or edit
        private bool LoginCheck(string UserName,string Password)
        {
            try
            {
                db = new DBAREntities();
                tbadd=db.TBUSERS.Where(x=>x.UserName == UserName&&x.Password == Password).FirstOrDefault();
                if(tbadd != null)
                {
                    state = true;
                }
                else
                {
                    state = false;
                }
                state = true;
            }
            catch
            {

                state = false;
            }
            return state;
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}