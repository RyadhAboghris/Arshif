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
    public partial class AddDep : DevExpress.XtraEditors.XtraForm
    {
        // database and tables
        DBAREntities db;
        TBDep tbadd;

        // other var 
        public int id;
        public Pages.DepPage page;
        bool state;
        public int start;
        public AddDep()
        {
            InitializeComponent();
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            if (edt_name.Text == "")
            {
                MessageBox.Show("خطأ ادخال","اكمل الحقول لطفا",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                // set Data 
                // check if add or edit
                if (id == 0)
                    // add
                {
                    tbadd = new TBDep { 
                    DepName=edt_name.Text,  
                    DepDetails=edt_details.Text,
                    };
                }
                // edit
                else
                {
                    tbadd = new TBDep
                    {
                        ID=id,
                        DepName = edt_name.Text,
                        DepDetails = edt_details.Text,
                    };
                }
                // add or edit
                loading.Visible = true;
                var result = await Task.Run(() => addorEdit(tbadd));
                if(result == true)
                {
                   
                    toastNotificationsManager1.ShowNotification("9953fd39-6ba8-4c1d-a304-138c8944a086");
                    if (start == 1)
                    {
                        // add dep and user
                        AddPage.AddUser userPage = new AddPage.AddUser();
                        userPage.start = 1;
                        MessageBox.Show(" الصفحة القادمة تتيح لك اضافة مستخدم");
                        start = 0;
                        userPage.Show();

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
        private bool addorEdit(TBDep data)
        {
            try {
            db=new DBAREntities();
                db.Set<TBDep>().AddOrUpdate(data);
                db.SaveChanges();
                state=true;
            } catch { 
            
           state = false;
            }
            return state;
        }

        private void AddDep_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (start == 1)
            {
                Application.Exit();
            }
        }
    }
}