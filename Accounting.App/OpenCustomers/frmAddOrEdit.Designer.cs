namespace Accounting.App.OpenCustomers
{
    partial class frmAddOrEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOrEdit));
            this.gpbPicture = new System.Windows.Forms.GroupBox();
            this.btnSelectPicture = new System.Windows.Forms.Button();
            this.pcCustomers = new System.Windows.Forms.PictureBox();
            this.gpbIdentity = new System.Windows.Forms.GroupBox();
            this.gpbAddress = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.gpbEmail = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.gpbMobilePhoneNumber = new System.Windows.Forms.GroupBox();
            this.txtMobilePhoneNumber = new System.Windows.Forms.TextBox();
            this.gpbFullName = new System.Windows.Forms.GroupBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.requiredFieldValidatorFullName = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidatorPhone = new ValidationComponents.RequiredFieldValidator(this.components);
            this.gpbPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcCustomers)).BeginInit();
            this.gpbIdentity.SuspendLayout();
            this.gpbAddress.SuspendLayout();
            this.gpbEmail.SuspendLayout();
            this.gpbMobilePhoneNumber.SuspendLayout();
            this.gpbFullName.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPicture
            // 
            this.gpbPicture.BackColor = System.Drawing.Color.PowderBlue;
            this.gpbPicture.Controls.Add(this.btnSelectPicture);
            this.gpbPicture.Controls.Add(this.pcCustomers);
            this.gpbPicture.Location = new System.Drawing.Point(4, 13);
            this.gpbPicture.Name = "gpbPicture";
            this.gpbPicture.Size = new System.Drawing.Size(209, 293);
            this.gpbPicture.TabIndex = 0;
            this.gpbPicture.TabStop = false;
            this.gpbPicture.Text = "تصویر فرد";
            // 
            // btnSelectPicture
            // 
            this.btnSelectPicture.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSelectPicture.Location = new System.Drawing.Point(7, 262);
            this.btnSelectPicture.Name = "btnSelectPicture";
            this.btnSelectPicture.Size = new System.Drawing.Size(196, 25);
            this.btnSelectPicture.TabIndex = 1;
            this.btnSelectPicture.Text = "انتخاب تصویر";
            this.btnSelectPicture.UseVisualStyleBackColor = false;
            this.btnSelectPicture.Click += new System.EventHandler(this.btnSelectPicture_Click);
            // 
            // pcCustomers
            // 
            this.pcCustomers.BackColor = System.Drawing.SystemColors.Info;
            this.pcCustomers.Image = global::Accounting.App.Properties.Resources.NoPhoto;
            this.pcCustomers.Location = new System.Drawing.Point(7, 21);
            this.pcCustomers.Name = "pcCustomers";
            this.pcCustomers.Size = new System.Drawing.Size(196, 234);
            this.pcCustomers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcCustomers.TabIndex = 0;
            this.pcCustomers.TabStop = false;
            // 
            // gpbIdentity
            // 
            this.gpbIdentity.BackColor = System.Drawing.Color.PowderBlue;
            this.gpbIdentity.Controls.Add(this.gpbAddress);
            this.gpbIdentity.Controls.Add(this.gpbEmail);
            this.gpbIdentity.Controls.Add(this.gpbMobilePhoneNumber);
            this.gpbIdentity.Controls.Add(this.gpbFullName);
            this.gpbIdentity.Controls.Add(this.btnSave);
            this.gpbIdentity.Location = new System.Drawing.Point(219, 13);
            this.gpbIdentity.Name = "gpbIdentity";
            this.gpbIdentity.Size = new System.Drawing.Size(287, 293);
            this.gpbIdentity.TabIndex = 1;
            this.gpbIdentity.TabStop = false;
            this.gpbIdentity.Text = "اطلاعات شخص";
            // 
            // gpbAddress
            // 
            this.gpbAddress.Controls.Add(this.txtAddress);
            this.gpbAddress.Location = new System.Drawing.Point(6, 171);
            this.gpbAddress.Name = "gpbAddress";
            this.gpbAddress.Size = new System.Drawing.Size(273, 84);
            this.gpbAddress.TabIndex = 6;
            this.gpbAddress.TabStop = false;
            this.gpbAddress.Text = "آدرس";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Info;
            this.txtAddress.Location = new System.Drawing.Point(6, 23);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(245, 55);
            this.txtAddress.TabIndex = 0;
            // 
            // gpbEmail
            // 
            this.gpbEmail.Controls.Add(this.txtEmail);
            this.gpbEmail.Location = new System.Drawing.Point(6, 121);
            this.gpbEmail.Name = "gpbEmail";
            this.gpbEmail.Size = new System.Drawing.Size(273, 50);
            this.gpbEmail.TabIndex = 5;
            this.gpbEmail.TabStop = false;
            this.gpbEmail.Text = "ایمیل";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Info;
            this.txtEmail.Location = new System.Drawing.Point(6, 23);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(245, 21);
            this.txtEmail.TabIndex = 0;
            // 
            // gpbMobilePhoneNumber
            // 
            this.gpbMobilePhoneNumber.Controls.Add(this.txtMobilePhoneNumber);
            this.gpbMobilePhoneNumber.Location = new System.Drawing.Point(6, 71);
            this.gpbMobilePhoneNumber.Name = "gpbMobilePhoneNumber";
            this.gpbMobilePhoneNumber.Size = new System.Drawing.Size(273, 50);
            this.gpbMobilePhoneNumber.TabIndex = 4;
            this.gpbMobilePhoneNumber.TabStop = false;
            this.gpbMobilePhoneNumber.Text = "شماره موبایل";
            // 
            // txtMobilePhoneNumber
            // 
            this.txtMobilePhoneNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txtMobilePhoneNumber.Location = new System.Drawing.Point(6, 20);
            this.txtMobilePhoneNumber.Name = "txtMobilePhoneNumber";
            this.txtMobilePhoneNumber.Size = new System.Drawing.Size(245, 21);
            this.txtMobilePhoneNumber.TabIndex = 0;
            // 
            // gpbFullName
            // 
            this.gpbFullName.Controls.Add(this.txtFullName);
            this.gpbFullName.Location = new System.Drawing.Point(6, 21);
            this.gpbFullName.Name = "gpbFullName";
            this.gpbFullName.Size = new System.Drawing.Size(273, 50);
            this.gpbFullName.TabIndex = 3;
            this.gpbFullName.TabStop = false;
            this.gpbFullName.Text = "نام و نام خانوادگی";
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.SystemColors.Info;
            this.txtFullName.Location = new System.Drawing.Point(6, 20);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(245, 21);
            this.txtFullName.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSave.Location = new System.Drawing.Point(6, 262);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(274, 24);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // requiredFieldValidatorFullName
            // 
            this.requiredFieldValidatorFullName.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidatorFullName.ControlToValidate = this.txtFullName;
            this.requiredFieldValidatorFullName.ErrorMessage = "لطفا نام و نام خانوادگی خود را وارد کنید";
            this.requiredFieldValidatorFullName.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidatorFullName.Icon")));
            // 
            // requiredFieldValidatorPhone
            // 
            this.requiredFieldValidatorPhone.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidatorPhone.ControlToValidate = this.txtMobilePhoneNumber;
            this.requiredFieldValidatorPhone.ErrorMessage = "لطفا شماره موبایل را وارد کنید";
            this.requiredFieldValidatorPhone.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidatorPhone.Icon")));
            // 
            // frmAddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(510, 310);
            this.Controls.Add(this.gpbIdentity);
            this.Controls.Add(this.gpbPicture);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddOrEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن شخص جدید";
            this.Load += new System.EventHandler(this.frmAddOrEdit_Load);
            this.gpbPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcCustomers)).EndInit();
            this.gpbIdentity.ResumeLayout(false);
            this.gpbAddress.ResumeLayout(false);
            this.gpbAddress.PerformLayout();
            this.gpbEmail.ResumeLayout(false);
            this.gpbEmail.PerformLayout();
            this.gpbMobilePhoneNumber.ResumeLayout(false);
            this.gpbMobilePhoneNumber.PerformLayout();
            this.gpbFullName.ResumeLayout(false);
            this.gpbFullName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPicture;
        private System.Windows.Forms.Button btnSelectPicture;
        private System.Windows.Forms.PictureBox pcCustomers;
        private System.Windows.Forms.GroupBox gpbIdentity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gpbAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.GroupBox gpbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox gpbMobilePhoneNumber;
        private System.Windows.Forms.TextBox txtMobilePhoneNumber;
        private System.Windows.Forms.GroupBox gpbFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidatorFullName;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidatorPhone;
    }
}