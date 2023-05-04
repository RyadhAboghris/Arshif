using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arshif.AddPage
{
    public partial class AddFile : DevExpress.XtraEditors.XtraForm
    {
        // database and tables
        DBAREntities db;
        TBArchiveFile tbadd;

        // other var 
        public int id;
        public int IDArch;
        public string ArchDep;

        public PL.ArchiveFileForm page;
        bool state;
        string[] FileNames;
        public AddFile()
        {
            InitializeComponent();
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            if (edt_title.Text == ""||FileNames==null)
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
                    tbadd = new TBArchiveFile();
                    tbadd.ArchDate = edt_date.Value;
                    tbadd.ArchDep = ArchDep;
                    tbadd.ArchNumber = edt_number.Text;
                    tbadd.ArchDetails = edt_details.Text;
                    tbadd.ArchReciver = edt_reciver.Text;
                    tbadd.ArchSender = edt_sender.Text;
                    tbadd.ArchTitle = edt_title.Text;
                    tbadd.IDArchive = IDArch;
                    if (FileNames.Length ==1)
                    {
                        tbadd.FileName1=Path.GetFileNameWithoutExtension(FileNames[0]);
                        tbadd.FileExt1=Path.GetExtension(FileNames[0]);
                        tbadd.FileSize1 =(double) File.ReadAllBytes(FileNames[0]).Length;
                        tbadd.FileFile1 = File.ReadAllBytes(FileNames[0]);
                    
                    }
                    if (FileNames.Length == 2)
                    {
                        tbadd.FileName1 = Path.GetFileNameWithoutExtension(FileNames[0]);
                        tbadd.FileExt1 = Path.GetExtension(FileNames[0]);
                        tbadd.FileSize1 = (double)File.ReadAllBytes(FileNames[0]).Length;
                        tbadd.FileFile1 = File.ReadAllBytes(FileNames[0]);
                        tbadd.FileName2 = Path.GetFileNameWithoutExtension(FileNames[1]);
                        tbadd.FileExt2 = Path.GetExtension(FileNames[1]);
                        tbadd.FileSize2 = (double)File.ReadAllBytes(FileNames[1]).Length;
                        tbadd.FileFile2 = File.ReadAllBytes(FileNames[1]);

                    }
                    if (FileNames.Length == 3)
                    {
                        tbadd.FileName1 = Path.GetFileNameWithoutExtension(FileNames[0]);
                        tbadd.FileExt1 = Path.GetExtension(FileNames[0]);
                        tbadd.FileSize1 = (double)File.ReadAllBytes(FileNames[0]).Length;
                        tbadd.FileFile1 = File.ReadAllBytes(FileNames[0]);
                        tbadd.FileName2 = Path.GetFileNameWithoutExtension(FileNames[1]);
                        tbadd.FileExt2 = Path.GetExtension(FileNames[1]);
                        tbadd.FileSize2 = (double)File.ReadAllBytes(FileNames[1]).Length;
                        tbadd.FileFile2 = File.ReadAllBytes(FileNames[1]);
                        tbadd.FileName3 = Path.GetFileNameWithoutExtension(FileNames[2]);
                        tbadd.FileExt3 = Path.GetExtension(FileNames[2]);
                        tbadd.FileSize3 = (double)File.ReadAllBytes(FileNames[2]).Length;
                        tbadd.FileFile3 = File.ReadAllBytes(FileNames[2]);

                    }
                    if (FileNames.Length == 4)
                    {
                        tbadd.FileName1 = Path.GetFileNameWithoutExtension(FileNames[0]);
                        tbadd.FileExt1 = Path.GetExtension(FileNames[0]);
                        tbadd.FileSize1 = (double)File.ReadAllBytes(FileNames[0]).Length;
                        tbadd.FileFile1 = File.ReadAllBytes(FileNames[0]);
                        tbadd.FileName2 = Path.GetFileNameWithoutExtension(FileNames[1]);
                        tbadd.FileExt2 = Path.GetExtension(FileNames[1]);
                        tbadd.FileSize2 = (double)File.ReadAllBytes(FileNames[1]).Length;
                        tbadd.FileFile2 = File.ReadAllBytes(FileNames[1]);
                        tbadd.FileName3 = Path.GetFileNameWithoutExtension(FileNames[2]);
                        tbadd.FileExt3 = Path.GetExtension(FileNames[2]);
                        tbadd.FileSize3 = (double)File.ReadAllBytes(FileNames[2]).Length;
                        tbadd.FileFile3 = File.ReadAllBytes(FileNames[2]);
                        tbadd.FileName4 = Path.GetFileNameWithoutExtension(FileNames[3]);
                        tbadd.FileExt4 = Path.GetExtension(FileNames[3]);
                        tbadd.FileSize4 = (double)File.ReadAllBytes(FileNames[3]).Length;
                        tbadd.FileFile4 = File.ReadAllBytes(FileNames[3]);

                    }
                    if (FileNames.Length == 5)
                    {
                        tbadd.FileName1 = Path.GetFileNameWithoutExtension(FileNames[0]);
                        tbadd.FileExt1 = Path.GetExtension(FileNames[0]);
                        tbadd.FileSize1 = (double)File.ReadAllBytes(FileNames[0]).Length;
                        tbadd.FileFile1 = File.ReadAllBytes(FileNames[0]);
                        tbadd.FileName2 = Path.GetFileNameWithoutExtension(FileNames[1]);
                        tbadd.FileExt2 = Path.GetExtension(FileNames[1]);
                        tbadd.FileSize2 = (double)File.ReadAllBytes(FileNames[1]).Length;
                        tbadd.FileFile2 = File.ReadAllBytes(FileNames[1]);
                        tbadd.FileName3 = Path.GetFileNameWithoutExtension(FileNames[2]);
                        tbadd.FileExt3 = Path.GetExtension(FileNames[2]);
                        tbadd.FileSize3 = (double)File.ReadAllBytes(FileNames[2]).Length;
                        tbadd.FileFile3 = File.ReadAllBytes(FileNames[2]);
                        tbadd.FileName4 = Path.GetFileNameWithoutExtension(FileNames[3]);
                        tbadd.FileExt4 = Path.GetExtension(FileNames[3]);
                        tbadd.FileSize4 = (double)File.ReadAllBytes(FileNames[3]).Length;
                        tbadd.FileFile4 = File.ReadAllBytes(FileNames[3]);
                        tbadd.FileName5 = Path.GetFileNameWithoutExtension(FileNames[4]);
                        tbadd.FileExt5 = Path.GetExtension(FileNames[4]);
                        tbadd.FileSize5 = (double)File.ReadAllBytes(FileNames[4]).Length;
                        tbadd.FileFile5 = File.ReadAllBytes(FileNames[4]);

                    }
                }


                // edit
                else
                {
                    tbadd = new TBArchiveFile();
                    tbadd.ArchDate = edt_date.Value;
                    tbadd.ArchDep = ArchDep;
                    tbadd.ArchNumber = edt_number.Text;
                    tbadd.ArchDetails = edt_details.Text;
                    tbadd.ArchReciver = edt_reciver.Text;
                    tbadd.ArchSender = edt_sender.Text;
                    tbadd.ArchTitle = edt_title.Text;
                    tbadd.IDArchive = IDArch;
                    tbadd.ID = id;
                    if (FileNames.Length == 1)
                    {
                        tbadd.FileName1 = Path.GetFileNameWithoutExtension(FileNames[0]);
                        tbadd.FileExt1 = Path.GetExtension(FileNames[0]);
                        tbadd.FileSize1 = (double)File.ReadAllBytes(FileNames[0]).Length;
                        tbadd.FileFile1 = File.ReadAllBytes(FileNames[0]);

                    }
                    if (FileNames.Length == 2)
                    {
                        tbadd.FileName1 = Path.GetFileNameWithoutExtension(FileNames[0]);
                        tbadd.FileExt1 = Path.GetExtension(FileNames[0]);
                        tbadd.FileSize1 = (double)File.ReadAllBytes(FileNames[0]).Length;
                        tbadd.FileFile1 = File.ReadAllBytes(FileNames[0]);
                        tbadd.FileName2 = Path.GetFileNameWithoutExtension(FileNames[1]);
                        tbadd.FileExt2 = Path.GetExtension(FileNames[1]);
                        tbadd.FileSize2 = (double)File.ReadAllBytes(FileNames[1]).Length;
                        tbadd.FileFile2 = File.ReadAllBytes(FileNames[1]);

                    }
                    if (FileNames.Length == 3)
                    {
                        tbadd.FileName1 = Path.GetFileNameWithoutExtension(FileNames[0]);
                        tbadd.FileExt1 = Path.GetExtension(FileNames[0]);
                        tbadd.FileSize1 = (double)File.ReadAllBytes(FileNames[0]).Length;
                        tbadd.FileFile1 = File.ReadAllBytes(FileNames[0]);
                        tbadd.FileName2 = Path.GetFileNameWithoutExtension(FileNames[1]);
                        tbadd.FileExt2 = Path.GetExtension(FileNames[1]);
                        tbadd.FileSize2 = (double)File.ReadAllBytes(FileNames[1]).Length;
                        tbadd.FileFile2 = File.ReadAllBytes(FileNames[1]);
                        tbadd.FileName3 = Path.GetFileNameWithoutExtension(FileNames[2]);
                        tbadd.FileExt3 = Path.GetExtension(FileNames[2]);
                        tbadd.FileSize3 = (double)File.ReadAllBytes(FileNames[2]).Length;
                        tbadd.FileFile3 = File.ReadAllBytes(FileNames[2]);

                    }
                    if (FileNames.Length == 4)
                    {
                        tbadd.FileName1 = Path.GetFileNameWithoutExtension(FileNames[0]);
                        tbadd.FileExt1 = Path.GetExtension(FileNames[0]);
                        tbadd.FileSize1 = (double)File.ReadAllBytes(FileNames[0]).Length;
                        tbadd.FileFile1 = File.ReadAllBytes(FileNames[0]);
                        tbadd.FileName2 = Path.GetFileNameWithoutExtension(FileNames[1]);
                        tbadd.FileExt2 = Path.GetExtension(FileNames[1]);
                        tbadd.FileSize2 = (double)File.ReadAllBytes(FileNames[1]).Length;
                        tbadd.FileFile2 = File.ReadAllBytes(FileNames[1]);
                        tbadd.FileName3 = Path.GetFileNameWithoutExtension(FileNames[2]);
                        tbadd.FileExt3 = Path.GetExtension(FileNames[2]);
                        tbadd.FileSize3 = (double)File.ReadAllBytes(FileNames[2]).Length;
                        tbadd.FileFile3 = File.ReadAllBytes(FileNames[2]);
                        tbadd.FileName4 = Path.GetFileNameWithoutExtension(FileNames[3]);
                        tbadd.FileExt4 = Path.GetExtension(FileNames[3]);
                        tbadd.FileSize4 = (double)File.ReadAllBytes(FileNames[3]).Length;
                        tbadd.FileFile4 = File.ReadAllBytes(FileNames[3]);

                    }
                    if (FileNames.Length == 5)
                    {
                        tbadd.FileName1 = Path.GetFileNameWithoutExtension(FileNames[0]);
                        tbadd.FileExt1 = Path.GetExtension(FileNames[0]);
                        tbadd.FileSize1 = (double)File.ReadAllBytes(FileNames[0]).Length;
                        tbadd.FileFile1 = File.ReadAllBytes(FileNames[0]);
                        tbadd.FileName2 = Path.GetFileNameWithoutExtension(FileNames[1]);
                        tbadd.FileExt2 = Path.GetExtension(FileNames[1]);
                        tbadd.FileSize2 = (double)File.ReadAllBytes(FileNames[1]).Length;
                        tbadd.FileFile2 = File.ReadAllBytes(FileNames[1]);
                        tbadd.FileName3 = Path.GetFileNameWithoutExtension(FileNames[2]);
                        tbadd.FileExt3 = Path.GetExtension(FileNames[2]);
                        tbadd.FileSize3 = (double)File.ReadAllBytes(FileNames[2]).Length;
                        tbadd.FileFile3 = File.ReadAllBytes(FileNames[2]);
                        tbadd.FileName4 = Path.GetFileNameWithoutExtension(FileNames[3]);
                        tbadd.FileExt4 = Path.GetExtension(FileNames[3]);
                        tbadd.FileSize4 = (double)File.ReadAllBytes(FileNames[3]).Length;
                        tbadd.FileFile4 = File.ReadAllBytes(FileNames[3]);
                        tbadd.FileName5 = Path.GetFileNameWithoutExtension(FileNames[4]);
                        tbadd.FileExt5 = Path.GetExtension(FileNames[4]);
                        tbadd.FileSize5 = (double)File.ReadAllBytes(FileNames[4]).Length;
                        tbadd.FileFile5 = File.ReadAllBytes(FileNames[4]);

                    }
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
        private bool addorEdit(TBArchiveFile data)
        {
            try {
            db=new DBAREntities();
                db.Set<TBArchiveFile>().AddOrUpdate(data);
                db.SaveChanges();
                state=true;
            } catch { 
            
           state = false;
            }
            return state;
        }

        private void btn_selectefiles_Click(object sender, EventArgs e)
        {
            try
            {
                var ofd = new OpenFileDialog();
                ofd.Multiselect = true;

                ofd.Title = "اختر 5 ملفات كحد اقصى بحجم 5 ميقا كحد اقصى";

                var rs = ofd.ShowDialog();
                var fileinfo = new FileInfo(ofd.FileName);

                if (rs == DialogResult.OK && ofd.FileNames.Length<6 && fileinfo.Length<5000000)
                {

                    FileNames = ofd.FileNames;
                    btn_selectefiles.Text = "تم اختيار الملفات , انقر لتغييرها";
                }
                else
                {
                    MessageBox.Show("اقصى عدد ملفات هو 5 و لا يتعدى حجم الملف الواحد 5 ميقا بايت");

                }

            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
         
        }
    }
}