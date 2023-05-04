﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arshif.PL
{
    public partial class ArchiveFileForm : DevExpress.XtraEditors.XtraForm
    {

        // database and tables
        TBArchiveFile tbadd;
        DBAREntities db;
        // other var
        public int ArchiveID;
        int id;
        bool state;

        public ArchiveFileForm()
        {
            InitializeComponent();
            ArchiveID = Convert.ToInt16(lb_id.Text);
            LoadData();
        }

        public void LoadData()
        {    // This line of code is generated by Data Source Configuration Wizard
            this.entityInstantFeedbackSource2.GetQueryable += entityInstantFeedbackSource2_GetQueryable;
            // This line of code is generated by Data Source Configuration Wizard
            this.entityInstantFeedbackSource2.DismissQueryable += entityInstantFeedbackSource2_DismissQueryable;
            this.entityInstantFeedbackSource2.Refresh();
        }



        // This event is generated by Data Source Configuration Wizard
        void entityInstantFeedbackSource2_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            // Instantiate a new DataContext
            Arshif.DBAREntities dataContext = new Arshif.DBAREntities();
            // Assign a queryable source to the EntityInstantFeedbackSource
            e.QueryableSource = dataContext.TBArchiveFiles.Where(x => x.IDArchive == ArchiveID).Select(x => new
            {
                x.ID, x.IDArchive, x.AddDate, x.ArchDate, x.ArchDetails, x.ArchNumber, x.ArchReciver, x.ArchSender, x.ArchTitle
            });
            // Assign the DataContext to the Tag property,
            // to dispose of it in the DismissQueryable event handler
            e.Tag = dataContext;
        }

        // This event is generated by Data Source Configuration Wizard
        void entityInstantFeedbackSource2_DismissQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            // Dispose of the DataContext
            ((Arshif.DBAREntities)e.Tag).Dispose();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddPage.AddFile add = new AddPage.AddFile();
            add.btn_add.Text = "اضافة";
            add.id = 0;
            add.IDArch = Convert.ToInt32(lb_id.Text);
            add.ArchDep = lb_archdep.Text;
            add.page = this;
            add.Show();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {

                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                if (id > 0)
                {
                    // edit
                    AddPage.AddFile add = new AddPage.AddFile();
                    add.btn_add.Text = "تعديل";
                    add.id = id;
                    add.IDArch = Convert.ToInt32(lb_id.Text);
                    add.ArchDep = lb_archdep.Text;
                    add.edt_number.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("ArchNumber"));
                    add.edt_reciver.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("ArchReciver"));
                    add.edt_sender.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("ArchSender"));
                    add.edt_title.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("ArchTitle"));
                    add.edt_date.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("ArchDate"));
                    add.edt_details.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("ArchDetails"));
                    add.page = this;
                    add.Show();
                }
                else
                {
                    MessageBox.Show("لا بيانات لتعديلها");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في العملية", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

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
                        tbadd = new TBArchiveFile
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
                private bool Delete(TBArchiveFile data)
            {
                try
                {
                    db = new DBAREntities();
                    db.Entry(data).State = System.Data.Entity.EntityState.Deleted;
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

        private void btn_showfiles_Click(object sender, EventArgs e)
        {

            try
            {

                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                if (id > 0)
                {
                    PL.ShowFiels files = new ShowFiels();
                    files.id = id;
                    files.Show();

                }
                else
                {
                    MessageBox.Show("لا بيانات");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في العملية", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    } }
