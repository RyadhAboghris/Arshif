namespace Arshif.AddPage
{
    partial class AddFile
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.edt_title = new DevExpress.XtraEditors.TextEdit();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.loading = new DevExpress.XtraWaitForm.ProgressPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edt_details = new System.Windows.Forms.RichTextBox();
            this.edt_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.edt_reciver = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.edt_sender = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edt_number = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_selectefiles = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_title.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_reciver.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_sender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_number.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 576);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 90);
            this.panel1.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btn_add.Appearance.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseBackColor = true;
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(423, 10);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(122, 68);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "اضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "العنوان";
            // 
            // edt_title
            // 
            this.edt_title.Location = new System.Drawing.Point(23, 30);
            this.edt_title.Name = "edt_title";
            this.edt_title.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_title.Properties.Appearance.Options.UseFont = true;
            this.edt_title.Size = new System.Drawing.Size(356, 32);
            this.edt_title.TabIndex = 2;
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "6c1b90da-356e-4711-b6aa-975bd01dc970";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("9953fd39-6ba8-4c1d-a304-138c8944a086", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "تمت العملية  بنجاح", "تمت العملية  بنجاح", "تمت العملية  بنجاح", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01)});
            // 
            // loading
            // 
            this.loading.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.loading.Appearance.Options.UseBackColor = true;
            this.loading.Caption = "الرجاء الانتظار";
            this.loading.Description = "العملية تجرى في الخلفية";
            this.loading.Location = new System.Drawing.Point(155, 300);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(246, 66);
            this.loading.TabIndex = 5;
            this.loading.Text = "progressPanel1";
            this.loading.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edt_details);
            this.groupBox1.Controls.Add(this.edt_date);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.edt_reciver);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.edt_sender);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.edt_number);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.edt_title);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 351);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المعلومات الاساسية";
            // 
            // edt_details
            // 
            this.edt_details.Location = new System.Drawing.Point(23, 222);
            this.edt_details.Name = "edt_details";
            this.edt_details.Size = new System.Drawing.Size(356, 123);
            this.edt_details.TabIndex = 14;
            this.edt_details.Text = "";
            // 
            // edt_date
            // 
            this.edt_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.edt_date.Location = new System.Drawing.Point(23, 102);
            this.edt_date.Name = "edt_date";
            this.edt_date.Size = new System.Drawing.Size(358, 33);
            this.edt_date.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(444, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "التفاصيل";
            // 
            // edt_reciver
            // 
            this.edt_reciver.Location = new System.Drawing.Point(23, 177);
            this.edt_reciver.Name = "edt_reciver";
            this.edt_reciver.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_reciver.Properties.Appearance.Options.UseFont = true;
            this.edt_reciver.Size = new System.Drawing.Size(356, 32);
            this.edt_reciver.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(381, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "الجهة الصادر اليها";
            // 
            // edt_sender
            // 
            this.edt_sender.Location = new System.Drawing.Point(23, 139);
            this.edt_sender.Name = "edt_sender";
            this.edt_sender.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_sender.Properties.Appearance.Options.UseFont = true;
            this.edt_sender.Size = new System.Drawing.Size(356, 32);
            this.edt_sender.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(381, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "الجهة الصادر منها";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(455, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "التاريخ";
            // 
            // edt_number
            // 
            this.edt_number.Location = new System.Drawing.Point(23, 65);
            this.edt_number.Name = "edt_number";
            this.edt_number.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_number.Properties.Appearance.Options.UseFont = true;
            this.edt_number.Size = new System.Drawing.Size(356, 32);
            this.edt_number.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(469, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "العدد";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_selectefiles);
            this.groupBox2.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 422);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 148);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اختيار ملفات (5 حد اقصى) و بحجم لا يتعدى 5 ميقا لكل ملف";
            // 
            // btn_selectefiles
            // 
            this.btn_selectefiles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_selectefiles.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btn_selectefiles.Appearance.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selectefiles.Appearance.Options.UseBackColor = true;
            this.btn_selectefiles.Appearance.Options.UseFont = true;
            this.btn_selectefiles.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_selectefiles.ImageOptions.SvgImage")));
            this.btn_selectefiles.Location = new System.Drawing.Point(6, 59);
            this.btn_selectefiles.Name = "btn_selectefiles";
            this.btn_selectefiles.Size = new System.Drawing.Size(521, 50);
            this.btn_selectefiles.TabIndex = 7;
            this.btn_selectefiles.Text = "اختر الملفات";
            this.btn_selectefiles.Click += new System.EventHandler(this.btn_selectefiles_Click);
            // 
            // AddFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 666);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFile";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة ملف";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edt_title.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_reciver.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_sender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_number.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        public DevExpress.XtraEditors.TextEdit edt_title;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private DevExpress.XtraWaitForm.ProgressPanel loading;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        public DevExpress.XtraEditors.TextEdit edt_reciver;
        private System.Windows.Forms.Label label5;
        public DevExpress.XtraEditors.TextEdit edt_sender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public DevExpress.XtraEditors.TextEdit edt_number;
        private System.Windows.Forms.Label label2;
        public DevExpress.XtraEditors.SimpleButton btn_selectefiles;
        public System.Windows.Forms.DateTimePicker edt_date;
        public System.Windows.Forms.RichTextBox edt_details;
    }
}