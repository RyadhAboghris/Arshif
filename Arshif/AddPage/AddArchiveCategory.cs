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
    public partial class AddArchiveCategory : DevExpress.XtraEditors.XtraForm
    {
        // database and tables
        DBAREntities db;
        TBArchiveCategory tbadd;

        // other var 
        public int id;
        public Pages.ArchiveCatPage page;
        bool state;
        public AddArchiveCategory()
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
                    tbadd = new TBArchiveCategory { 
                  ArchiveTitle=edt_name.Text,
                  ArchiveDes=edt_details.Text,
                  UserName=Properties.Settings.Default.UserName,
                  UserDep = Properties.Settings.Default.UserDep,
                  IDUser = Properties.Settings.Default.UserID,

                    };
                }
                // edit
                else
                {
                    tbadd = new TBArchiveCategory
                    {
                        ID=id,
                        ArchiveTitle = edt_name.Text,
                        ArchiveDes = edt_details.Text,
                        UserName = Properties.Settings.Default.UserName,
                        UserDep = Properties.Settings.Default.UserDep,
                        IDUser = Properties.Settings.Default.UserID,
                    };
                }
                // add or edit
                loading.Visible = true;
                var result = await Task.Run(() => addorEdit(tbadd));
                if(result == true)
                {
                    // reload data
                    page.LoadData();
                    toastNotificationsManager1.ShowNotification("9953fd39-6ba8-4c1d-a304-138c8944a086");
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
        private bool addorEdit(TBArchiveCategory data)
        {
            try {
            db=new DBAREntities();
                db.Set<TBArchiveCategory>().AddOrUpdate(data);
                db.SaveChanges();
                state=true;
            } catch { 
            
           state = false;
            }
            return state;
        }
    }
}