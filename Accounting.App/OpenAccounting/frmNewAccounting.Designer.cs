namespace Accounting.App
{
    partial class frmNewAccounting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewAccounting));
            this.gpbPerson = new System.Windows.Forms.GroupBox();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lblPerson = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSortTran = new System.Windows.Forms.Label();
            this.rbRecieve = new System.Windows.Forms.RadioButton();
            this.rbPay = new System.Windows.Forms.RadioButton();
            this.lblAmount = new System.Windows.Forms.Label();
            this.nmrAmount = new System.Windows.Forms.NumericUpDown();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.rangeValidatorNmrAmount = new ValidationComponents.RangeValidator(this.components);
            this.requiredFieldValidatorPerson = new ValidationComponents.RequiredFieldValidator(this.components);
            this.gpbPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbPerson
            // 
            this.gpbPerson.BackColor = System.Drawing.Color.LightCyan;
            this.gpbPerson.Controls.Add(this.dgvCustomer);
            this.gpbPerson.Controls.Add(this.txtFilter);
            this.gpbPerson.Location = new System.Drawing.Point(13, 13);
            this.gpbPerson.Name = "gpbPerson";
            this.gpbPerson.Size = new System.Drawing.Size(218, 336);
            this.gpbPerson.TabIndex = 0;
            this.gpbPerson.TabStop = false;
            this.gpbPerson.Text = "اشخاص";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName});
            this.dgvCustomer.Location = new System.Drawing.Point(7, 49);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.Size = new System.Drawing.Size(205, 281);
            this.dgvCustomer.TabIndex = 1;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "نام و نام خانوادگی";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.SystemColors.Info;
            this.txtFilter.Location = new System.Drawing.Point(7, 21);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(205, 21);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Location = new System.Drawing.Point(509, 13);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(67, 13);
            this.lblPerson.TabIndex = 1;
            this.lblPerson.Text = "طرف حساب:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Info;
            this.txtName.Location = new System.Drawing.Point(238, 12);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(266, 21);
            this.txtName.TabIndex = 2;
            // 
            // lblSortTran
            // 
            this.lblSortTran.AutoSize = true;
            this.lblSortTran.Location = new System.Drawing.Point(509, 42);
            this.lblSortTran.Name = "lblSortTran";
            this.lblSortTran.Size = new System.Drawing.Size(63, 13);
            this.lblSortTran.TabIndex = 3;
            this.lblSortTran.Text = "نوع تراکنش:";
            // 
            // rbRecieve
            // 
            this.rbRecieve.AutoSize = true;
            this.rbRecieve.Location = new System.Drawing.Point(454, 42);
            this.rbRecieve.Name = "rbRecieve";
            this.rbRecieve.Size = new System.Drawing.Size(49, 17);
            this.rbRecieve.TabIndex = 4;
            this.rbRecieve.TabStop = true;
            this.rbRecieve.Text = "درآمد";
            this.rbRecieve.UseVisualStyleBackColor = true;
            // 
            // rbPay
            // 
            this.rbPay.AutoSize = true;
            this.rbPay.Location = new System.Drawing.Point(399, 42);
            this.rbPay.Name = "rbPay";
            this.rbPay.Size = new System.Drawing.Size(51, 17);
            this.rbPay.TabIndex = 5;
            this.rbPay.TabStop = true;
            this.rbPay.Text = "هزینه";
            this.rbPay.UseVisualStyleBackColor = true;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(509, 73);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(31, 13);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "مبلغ:";
            // 
            // nmrAmount
            // 
            this.nmrAmount.BackColor = System.Drawing.SystemColors.Info;
            this.nmrAmount.Location = new System.Drawing.Point(238, 71);
            this.nmrAmount.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.nmrAmount.Name = "nmrAmount";
            this.nmrAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nmrAmount.Size = new System.Drawing.Size(266, 21);
            this.nmrAmount.TabIndex = 7;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(509, 105);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(34, 13);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "شرح:";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Info;
            this.txtDescription.Location = new System.Drawing.Point(237, 102);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(266, 219);
            this.txtDescription.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSave.Location = new System.Drawing.Point(238, 328);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(334, 21);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rangeValidatorNmrAmount
            // 
            this.rangeValidatorNmrAmount.CancelFocusChangeWhenInvalid = false;
            this.rangeValidatorNmrAmount.ControlToValidate = this.nmrAmount;
            this.rangeValidatorNmrAmount.ErrorMessage = "لطفا مبلغ رو به انگلیسی وارد کنید";
            this.rangeValidatorNmrAmount.Icon = ((System.Drawing.Icon)(resources.GetObject("rangeValidatorNmrAmount.Icon")));
            this.rangeValidatorNmrAmount.MaximumValue = "10000000000000000000";
            this.rangeValidatorNmrAmount.MinimumValue = "1";
            this.rangeValidatorNmrAmount.Type = ValidationComponents.ValidationDataType.Integer;
            // 
            // requiredFieldValidatorPerson
            // 
            this.requiredFieldValidatorPerson.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidatorPerson.ControlToValidate = this.txtName;
            this.requiredFieldValidatorPerson.ErrorMessage = "لطفا نام را از لیست انتخاب کنید";
            this.requiredFieldValidatorPerson.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidatorPerson.Icon")));
            // 
            // frmNewAccounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.nmrAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.rbPay);
            this.Controls.Add(this.rbRecieve);
            this.Controls.Add(this.lblSortTran);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.gpbPerson);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNewAccounting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تراکنش جدید";
            this.Load += new System.EventHandler(this.frmNewAccounting_Load);
            this.gpbPerson.ResumeLayout(false);
            this.gpbPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPerson;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSortTran;
        private System.Windows.Forms.RadioButton rbRecieve;
        private System.Windows.Forms.RadioButton rbPay;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown nmrAmount;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private ValidationComponents.RangeValidator rangeValidatorNmrAmount;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidatorPerson;
    }
}