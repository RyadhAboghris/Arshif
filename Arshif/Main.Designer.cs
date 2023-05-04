namespace Arshif
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement11 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement12 = new DevExpress.XtraEditors.TileItemElement();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBar2 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.btn_home = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btn_dep = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btn_users = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btn_archive = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btn_setting = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btn_help = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.pn_container = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tileBar1
            // 
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.Location = new System.Drawing.Point(0, 0);
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(240, 150);
            this.tileBar1.TabIndex = 0;
            this.tileBar1.Text = "tileBar1";
            // 
            // tileBar2
            // 
            this.tileBar2.AllowSelectedItem = true;
            this.tileBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tileBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar2.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar2.Groups.Add(this.tileBarGroup2);
            this.tileBar2.Location = new System.Drawing.Point(0, 0);
            this.tileBar2.MaxId = 6;
            this.tileBar2.Name = "tileBar2";
            this.tileBar2.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar2.Size = new System.Drawing.Size(1078, 108);
            this.tileBar2.TabIndex = 1;
            this.tileBar2.Text = "tileBar2";
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.btn_home);
            this.tileBarGroup2.Items.Add(this.btn_dep);
            this.tileBarGroup2.Items.Add(this.btn_users);
            this.tileBarGroup2.Items.Add(this.btn_archive);
            this.tileBarGroup2.Items.Add(this.btn_setting);
            this.tileBarGroup2.Items.Add(this.btn_help);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // btn_home
            // 
            this.btn_home.AppearanceItem.Normal.BackColor = System.Drawing.Color.Teal;
            this.btn_home.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Teal;
            this.btn_home.AppearanceItem.Normal.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.AppearanceItem.Normal.Options.UseBackColor = true;
            this.btn_home.AppearanceItem.Normal.Options.UseFont = true;
            this.btn_home.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement7.Text = "الرئيسة";
            tileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.btn_home.Elements.Add(tileItemElement7);
            this.btn_home.Id = 0;
            this.btn_home.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btn_home.Name = "btn_home";
            this.btn_home.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_home_ItemClick);
            // 
            // btn_dep
            // 
            this.btn_dep.AppearanceItem.Normal.BackColor = System.Drawing.Color.Teal;
            this.btn_dep.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Teal;
            this.btn_dep.AppearanceItem.Normal.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dep.AppearanceItem.Normal.Options.UseBackColor = true;
            this.btn_dep.AppearanceItem.Normal.Options.UseFont = true;
            this.btn_dep.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            tileItemElement8.Text = "الاقسام";
            tileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.btn_dep.Elements.Add(tileItemElement8);
            this.btn_dep.Id = 1;
            this.btn_dep.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btn_dep.Name = "btn_dep";
            this.btn_dep.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_dep_ItemClick);
            // 
            // btn_users
            // 
            this.btn_users.AppearanceItem.Normal.BackColor = System.Drawing.Color.Teal;
            this.btn_users.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Teal;
            this.btn_users.AppearanceItem.Normal.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.AppearanceItem.Normal.Options.UseBackColor = true;
            this.btn_users.AppearanceItem.Normal.Options.UseFont = true;
            this.btn_users.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            tileItemElement9.Text = "مستخدمين";
            tileItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.btn_users.Elements.Add(tileItemElement9);
            this.btn_users.Id = 2;
            this.btn_users.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btn_users.Name = "btn_users";
            this.btn_users.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_users_ItemClick);
            // 
            // btn_archive
            // 
            this.btn_archive.AppearanceItem.Normal.BackColor = System.Drawing.Color.Teal;
            this.btn_archive.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Teal;
            this.btn_archive.AppearanceItem.Normal.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_archive.AppearanceItem.Normal.Options.UseBackColor = true;
            this.btn_archive.AppearanceItem.Normal.Options.UseFont = true;
            this.btn_archive.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            tileItemElement10.Text = "ارشيف";
            tileItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.btn_archive.Elements.Add(tileItemElement10);
            this.btn_archive.Id = 3;
            this.btn_archive.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btn_archive.Name = "btn_archive";
            this.btn_archive.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_archive_ItemClick);
            // 
            // btn_setting
            // 
            this.btn_setting.AppearanceItem.Normal.BackColor = System.Drawing.Color.Teal;
            this.btn_setting.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Teal;
            this.btn_setting.AppearanceItem.Normal.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setting.AppearanceItem.Normal.Options.UseBackColor = true;
            this.btn_setting.AppearanceItem.Normal.Options.UseFont = true;
            this.btn_setting.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            tileItemElement11.Text = "الاعدادات";
            tileItemElement11.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.btn_setting.Elements.Add(tileItemElement11);
            this.btn_setting.Id = 4;
            this.btn_setting.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_setting_ItemClick);
            // 
            // btn_help
            // 
            this.btn_help.AppearanceItem.Normal.BackColor = System.Drawing.Color.Teal;
            this.btn_help.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Teal;
            this.btn_help.AppearanceItem.Normal.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.AppearanceItem.Normal.Options.UseBackColor = true;
            this.btn_help.AppearanceItem.Normal.Options.UseFont = true;
            this.btn_help.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement12.Text = "تسجيل الخروج";
            tileItemElement12.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.btn_help.Elements.Add(tileItemElement12);
            this.btn_help.Id = 5;
            this.btn_help.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btn_help.Name = "btn_help";
            this.btn_help.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_help_ItemClick);
            // 
            // pn_container
            // 
            this.pn_container.BackColor = System.Drawing.Color.White;
            this.pn_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_container.Location = new System.Drawing.Point(0, 108);
            this.pn_container.Name = "pn_container";
            this.pn_container.Size = new System.Drawing.Size(1078, 572);
            this.pn_container.TabIndex = 2;
            this.pn_container.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_container_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 680);
            this.Controls.Add(this.pn_container);
            this.Controls.Add(this.tileBar2);
            this.Controls.Add(this.tileBar1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Main.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arshif";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Navigation.TileBar tileBar2;
        private System.Windows.Forms.Panel pn_container;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem btn_home;
        private DevExpress.XtraBars.Navigation.TileBarItem btn_archive;
        private DevExpress.XtraBars.Navigation.TileBarItem btn_setting;
        private DevExpress.XtraBars.Navigation.TileBarItem btn_help;
        public DevExpress.XtraBars.Navigation.TileBarItem btn_dep;
        public DevExpress.XtraBars.Navigation.TileBarItem btn_users;
    }
}

