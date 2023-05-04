namespace Arshif.PL
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pic_logo = new DevExpress.XtraEditors.PictureEdit();
            this.edt_componydes = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edt_componyname = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_savegen = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.edt_password = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.edt_username = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.edt_port = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.edt_database = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.edt_servername = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_saveconstring = new DevExpress.XtraEditors.SimpleButton();
            this.btn_backup = new DevExpress.XtraEditors.SimpleButton();
            this.label10 = new System.Windows.Forms.Label();
            this.loading = new DevExpress.XtraWaitForm.ProgressPanel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_componyname.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_port.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_database.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_servername.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.pic_logo);
            this.groupBox1.Controls.Add(this.edt_componydes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.edt_componyname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_savegen);
            this.groupBox1.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(82, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(412, 585);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اعدادات العامة";
            // 
            // pic_logo
            // 
            this.pic_logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_logo.EditValue = ((object)(resources.GetObject("pic_logo.EditValue")));
            this.pic_logo.Location = new System.Drawing.Point(111, 438);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_logo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pic_logo.Size = new System.Drawing.Size(156, 96);
            this.pic_logo.TabIndex = 13;
            // 
            // edt_componydes
            // 
            this.edt_componydes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_componydes.Location = new System.Drawing.Point(17, 236);
            this.edt_componydes.Name = "edt_componydes";
            this.edt_componydes.Size = new System.Drawing.Size(367, 168);
            this.edt_componydes.TabIndex = 12;
            this.edt_componydes.Text = "";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "الشعار";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "وصف المؤسسة";
            // 
            // edt_componyname
            // 
            this.edt_componyname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_componyname.Location = new System.Drawing.Point(11, 147);
            this.edt_componyname.Name = "edt_componyname";
            this.edt_componyname.Properties.Appearance.Font = new System.Drawing.Font("LBC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_componyname.Properties.Appearance.Options.UseFont = true;
            this.edt_componyname.Size = new System.Drawing.Size(378, 42);
            this.edt_componyname.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "اسم المؤسسة";
            // 
            // btn_savegen
            // 
            this.btn_savegen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_savegen.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btn_savegen.Appearance.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_savegen.Appearance.Options.UseBackColor = true;
            this.btn_savegen.Appearance.Options.UseFont = true;
            this.btn_savegen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_savegen.ImageOptions.Image")));
            this.btn_savegen.Location = new System.Drawing.Point(301, 538);
            this.btn_savegen.Name = "btn_savegen";
            this.btn_savegen.Size = new System.Drawing.Size(105, 41);
            this.btn_savegen.TabIndex = 7;
            this.btn_savegen.Text = "حفظ";
            this.btn_savegen.Click += new System.EventHandler(this.btn_savegen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btn_saveconstring);
            this.groupBox2.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(636, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(412, 585);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الاتصال الشبكي";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.edt_password);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.edt_username);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.edt_port);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.edt_database);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.edt_servername);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 467);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(156, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "نوع الاتصال";
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(118, 126);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 26);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.Text = "شبكي";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(235, 126);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 26);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "محلي";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // edt_password
            // 
            this.edt_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_password.EditValue = "12345";
            this.edt_password.Enabled = false;
            this.edt_password.Location = new System.Drawing.Point(6, 369);
            this.edt_password.Name = "edt_password";
            this.edt_password.Properties.Appearance.Font = new System.Drawing.Font("LBC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_password.Properties.Appearance.Options.UseFont = true;
            this.edt_password.Properties.PasswordChar = '*';
            this.edt_password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edt_password.Size = new System.Drawing.Size(257, 42);
            this.edt_password.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "كلمة السر";
            // 
            // edt_username
            // 
            this.edt_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_username.EditValue = "sa";
            this.edt_username.Enabled = false;
            this.edt_username.Location = new System.Drawing.Point(6, 321);
            this.edt_username.Name = "edt_username";
            this.edt_username.Properties.Appearance.Font = new System.Drawing.Font("LBC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_username.Properties.Appearance.Options.UseFont = true;
            this.edt_username.Properties.PasswordChar = '*';
            this.edt_username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edt_username.Size = new System.Drawing.Size(257, 42);
            this.edt_username.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "اسم المستخدم";
            // 
            // edt_port
            // 
            this.edt_port.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_port.EditValue = "1433";
            this.edt_port.Enabled = false;
            this.edt_port.Location = new System.Drawing.Point(6, 273);
            this.edt_port.Name = "edt_port";
            this.edt_port.Properties.Appearance.Font = new System.Drawing.Font("LBC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_port.Properties.Appearance.Options.UseFont = true;
            this.edt_port.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edt_port.Size = new System.Drawing.Size(257, 42);
            this.edt_port.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "رقم المنفذ";
            // 
            // edt_database
            // 
            this.edt_database.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_database.EditValue = "DBAR";
            this.edt_database.Enabled = false;
            this.edt_database.Location = new System.Drawing.Point(6, 225);
            this.edt_database.Name = "edt_database";
            this.edt_database.Properties.Appearance.Font = new System.Drawing.Font("LBC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_database.Properties.Appearance.Options.UseFont = true;
            this.edt_database.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edt_database.Size = new System.Drawing.Size(257, 42);
            this.edt_database.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "قاعدة البيانات";
            // 
            // edt_servername
            // 
            this.edt_servername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_servername.EditValue = ".\\RYADHABOGHRIS";
            this.edt_servername.Location = new System.Drawing.Point(6, 172);
            this.edt_servername.Name = "edt_servername";
            this.edt_servername.Properties.Appearance.Font = new System.Drawing.Font("LBC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_servername.Properties.Appearance.Options.UseFont = true;
            this.edt_servername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edt_servername.Size = new System.Drawing.Size(257, 42);
            this.edt_servername.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "اسم السيرفير";
            // 
            // btn_saveconstring
            // 
            this.btn_saveconstring.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_saveconstring.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btn_saveconstring.Appearance.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveconstring.Appearance.Options.UseBackColor = true;
            this.btn_saveconstring.Appearance.Options.UseFont = true;
            this.btn_saveconstring.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_saveconstring.ImageOptions.Image")));
            this.btn_saveconstring.Location = new System.Drawing.Point(301, 538);
            this.btn_saveconstring.Name = "btn_saveconstring";
            this.btn_saveconstring.Size = new System.Drawing.Size(105, 41);
            this.btn_saveconstring.TabIndex = 7;
            this.btn_saveconstring.Text = "حفظ";
            this.btn_saveconstring.Click += new System.EventHandler(this.btn_saveconstring_Click);
            // 
            // btn_backup
            // 
            this.btn_backup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_backup.Appearance.BackColor = System.Drawing.Color.White;
            this.btn_backup.Appearance.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backup.Appearance.Options.UseBackColor = true;
            this.btn_backup.Appearance.Options.UseFont = true;
            this.btn_backup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_backup.ImageOptions.Image")));
            this.btn_backup.Location = new System.Drawing.Point(636, 609);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(412, 41);
            this.btn_backup.TabIndex = 11;
            this.btn_backup.Text = "اخذ نسخة احتياطية";
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.Font = new System.Drawing.Font("LBC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(668, 583);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(355, 22);
            this.label10.TabIndex = 20;
            this.label10.Text = "يجب تشغيل البرنامج كمسؤول لكي تتمكن من اجراء النسخ الاحتياطي";
            // 
            // loading
            // 
            this.loading.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.loading.Appearance.Options.UseBackColor = true;
            this.loading.Caption = "الرجاء الانتظار";
            this.loading.Description = "العملية تجرى في الخلفية";
            this.loading.Location = new System.Drawing.Point(430, 298);
            this.loading.Name = "loading";
            this.loading.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loading.Size = new System.Drawing.Size(246, 66);
            this.loading.TabIndex = 21;
            this.loading.Text = "progressPanel1";
            this.loading.Visible = false;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 662);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_backup);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اعدادات البرنامج";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingForm_FormClosed);
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_componyname.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_port.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_database.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_servername.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public DevExpress.XtraEditors.SimpleButton btn_savegen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public DevExpress.XtraEditors.TextEdit edt_componyname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox edt_componydes;
        private System.Windows.Forms.GroupBox groupBox2;
        public DevExpress.XtraEditors.SimpleButton btn_saveconstring;
        public DevExpress.XtraEditors.TextEdit edt_servername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        public DevExpress.XtraEditors.TextEdit edt_password;
        private System.Windows.Forms.Label label8;
        public DevExpress.XtraEditors.TextEdit edt_username;
        private System.Windows.Forms.Label label7;
        public DevExpress.XtraEditors.TextEdit edt_port;
        private System.Windows.Forms.Label label5;
        public DevExpress.XtraEditors.TextEdit edt_database;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label9;
        public DevExpress.XtraEditors.SimpleButton btn_backup;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.PictureEdit pic_logo;
        private DevExpress.XtraWaitForm.ProgressPanel loading;
    }
}