﻿using DevExpress.XtraEditors;
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
    public partial class DepPage : DevExpress.XtraEditors.XtraUserControl
    {
        // database and tables
        DBAREntities db;
        TBDep tbadd;

        int id;
        bool state;
        public DepPage()
        {
            InitializeComponent();
            LoadData();
               }

        // load data 
        public void LoadData()
        {
            // This line of code is generated by Data Source Configuration Wizard
            this.entityInstantFeedbackSource1.GetQueryable += entityInstantFeedbackSource1_GetQueryable;
            // This line of code is generated by Data Source Configuration Wizard
            this.entityInstantFeedbackSource1.DismissQueryable += entityInstantFeedbackSource1_DismissQueryable;
            this.entityInstantFeedbackSource1.Refresh();
        }


        // This event is generated by Data Source Configuration Wizard
        void entityInstantFeedbackSource1_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            // Instantiate a new DataContext
            Arshif.DBAREntities dataContext = new Arshif.DBAREntities();
            // Assign a queryable source to the EntityInstantFeedbackSource
            e.QueryableSource = dataContext.TBDeps;
            // Assign the DataContext to the Tag property,
            // to dispose of it in the DismissQueryable event handler
            e.Tag = dataContext;
        }

        // This event is generated by Data Source Configuration Wizard
        void entityInstantFeedbackSource1_DismissQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            // Dispose of the DataContext
            ((Arshif.DBAREntities)e.Tag).Dispose();
        }
        //add
        private void btn_add_Click(object sender, EventArgs e)
        {
            AddPage.AddDep add = new AddPage.AddDep();
            add.btn_add.Text = "اضافة";
            add.id = 0;
            add.page = this;
            add.Show();
        }
        //edit
        private void btn_edit_Click(object sender, EventArgs e)
        {
            try {

                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                if (id > 0)
                {
                    // edit
                    AddPage.AddDep add = new AddPage.AddDep();
                    add.btn_add.Text = "تعديل";
                    add.id = id;
                    add.edt_name.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("DepName"));
                    add.edt_details.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("DepDetails"));
                    add.page = this;
                    add.Show();
                }
                else
                {
                    MessageBox.Show("لا بيانات لتعديلها");
                }
            }
            catch(Exception ex){
                    MessageBox.Show("خطأ في العملية", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        // delete
        private async void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {

                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                if (id > 0)
                {

                    var resutl = MessageBox.Show("اجراء حذف", "هل انت متأكد من هذا الاجراء", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resutl == DialogResult.Yes)
                    {
                        // delete
                        // loading
                        loading.Visible = true;
                        tbadd = new TBDep
                        {
                            ID = id,
                        };
                        var rs = await Task.Run(() => Delete(tbadd));
                        if (rs == true)
                        {
                            LoadData();
                            toastNotificationsManager1.ShowNotification("9953fd39-6ba8-4c1d-a304-138c8944a086");
                        }
                        else
                        {
                            MessageBox.Show("خطأ في الاتصال", "تأكد من الاتصال في السيرفر", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        // end
                        loading.Visible = false;

                    }
                    else
                    {
                        MessageBox.Show("لا بيانات لحذفها");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في العملية", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        // delete method
        private bool Delete(TBDep data)
        {
            try
            {
                db = new DBAREntities();
                db.Entry(data).State=System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                state = true;
            }
            catch
            {

                state = false;
            }
            return state;
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }
    }
}
