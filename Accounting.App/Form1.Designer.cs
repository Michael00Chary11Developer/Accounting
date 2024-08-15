namespace Accounting.App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnCustomers = new System.Windows.Forms.ToolStripButton();
            this.btnNewAccounting = new System.Windows.Forms.ToolStripButton();
            this.btnReportPay = new System.Windows.Forms.ToolStripButton();
            this.btnReportRecieve = new System.Windows.Forms.ToolStripButton();
            this.pcAccounting = new System.Windows.Forms.PictureBox();
            this.tstsField = new System.Windows.Forms.StatusStrip();
            this.slblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimerTlbTime = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSetting = new System.Windows.Forms.ToolStripButton();
            this.gpbGetReport = new System.Windows.Forms.GroupBox();
            this.lblSayRecieve = new System.Windows.Forms.Label();
            this.lblSayPay = new System.Windows.Forms.Label();
            this.lblSayBalance = new System.Windows.Forms.Label();
            this.lblRecive = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnReportingRefresh = new System.Windows.Forms.Button();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcAccounting)).BeginInit();
            this.tstsField.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.gpbGetReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCustomers,
            this.btnNewAccounting,
            this.btnReportPay,
            this.btnReportRecieve});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(784, 54);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnCustomers
            // 
            this.btnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomers.Image")));
            this.btnCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(76, 51);
            this.btnCustomers.Text = "حساب کاربری";
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnNewAccounting
            // 
            this.btnNewAccounting.Image = global::Accounting.App.Properties.Resources.Transaction_PNG;
            this.btnNewAccounting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewAccounting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewAccounting.Name = "btnNewAccounting";
            this.btnNewAccounting.Size = new System.Drawing.Size(75, 51);
            this.btnNewAccounting.Text = " تراکنش جدید";
            this.btnNewAccounting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewAccounting.Click += new System.EventHandler(this.btnNewAccounting_Click);
            // 
            // btnReportPay
            // 
            this.btnReportPay.Image = global::Accounting.App.Properties.Resources.Add_a_new_Pay__transaction;
            this.btnReportPay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReportPay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportPay.Name = "btnReportPay";
            this.btnReportPay.Size = new System.Drawing.Size(97, 51);
            this.btnReportPay.Text = "گزارش پرداختی ها";
            this.btnReportPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportPay.Click += new System.EventHandler(this.btnReportPay_Click);
            // 
            // btnReportRecieve
            // 
            this.btnReportRecieve.Image = global::Accounting.App.Properties.Resources.Recieve;
            this.btnReportRecieve.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReportRecieve.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportRecieve.Name = "btnReportRecieve";
            this.btnReportRecieve.Size = new System.Drawing.Size(98, 51);
            this.btnReportRecieve.Text = "گزارش دریافتی ها";
            this.btnReportRecieve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportRecieve.Click += new System.EventHandler(this.btnReportRecieve_Click);
            // 
            // pcAccounting
            // 
            this.pcAccounting.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.pcAccounting.Image = global::Accounting.App.Properties.Resources.Accounting_PNG;
            this.pcAccounting.Location = new System.Drawing.Point(12, 285);
            this.pcAccounting.Name = "pcAccounting";
            this.pcAccounting.Size = new System.Drawing.Size(296, 250);
            this.pcAccounting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcAccounting.TabIndex = 2;
            this.pcAccounting.TabStop = false;
            // 
            // tstsField
            // 
            this.tstsField.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblDate,
            this.slblTime});
            this.tstsField.Location = new System.Drawing.Point(0, 539);
            this.tstsField.Name = "tstsField";
            this.tstsField.Size = new System.Drawing.Size(784, 22);
            this.tstsField.TabIndex = 3;
            this.tstsField.Text = "statusStrip1";
            // 
            // slblDate
            // 
            this.slblDate.Name = "slblDate";
            this.slblDate.Size = new System.Drawing.Size(31, 17);
            this.slblDate.Text = "تاریخ";
            // 
            // slblTime
            // 
            this.slblTime.Name = "slblTime";
            this.slblTime.Size = new System.Drawing.Size(29, 17);
            this.slblTime.Text = "زمان";
            // 
            // TimerTlbTime
            // 
            this.TimerTlbTime.Enabled = true;
            this.TimerTlbTime.Interval = 1000;
            this.TimerTlbTime.Tick += new System.EventHandler(this.TimerTlbTime_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Cyan;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSetting});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSetting
            // 
            this.btnSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(23, 22);
            this.btnSetting.Text = "تنظیمات";
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // gpbGetReport
            // 
            this.gpbGetReport.Controls.Add(this.btnReportingRefresh);
            this.gpbGetReport.Controls.Add(this.lblBalance);
            this.gpbGetReport.Controls.Add(this.lblPay);
            this.gpbGetReport.Controls.Add(this.lblRecive);
            this.gpbGetReport.Controls.Add(this.lblSayBalance);
            this.gpbGetReport.Controls.Add(this.lblSayPay);
            this.gpbGetReport.Controls.Add(this.lblSayRecieve);
            this.gpbGetReport.Location = new System.Drawing.Point(433, 82);
            this.gpbGetReport.Name = "gpbGetReport";
            this.gpbGetReport.Size = new System.Drawing.Size(351, 127);
            this.gpbGetReport.TabIndex = 4;
            this.gpbGetReport.TabStop = false;
            this.gpbGetReport.Text = "گزارش هزینه کلی";
            // 
            // lblSayRecieve
            // 
            this.lblSayRecieve.AutoSize = true;
            this.lblSayRecieve.Location = new System.Drawing.Point(276, 25);
            this.lblSayRecieve.Name = "lblSayRecieve";
            this.lblSayRecieve.Size = new System.Drawing.Size(60, 13);
            this.lblSayRecieve.TabIndex = 0;
            this.lblSayRecieve.Text = "دریافتی ها:";
            // 
            // lblSayPay
            // 
            this.lblSayPay.AutoSize = true;
            this.lblSayPay.Location = new System.Drawing.Point(276, 48);
            this.lblSayPay.Name = "lblSayPay";
            this.lblSayPay.Size = new System.Drawing.Size(63, 13);
            this.lblSayPay.TabIndex = 1;
            this.lblSayPay.Text = "پرداختی ها:";
            // 
            // lblSayBalance
            // 
            this.lblSayBalance.AutoSize = true;
            this.lblSayBalance.Location = new System.Drawing.Point(279, 71);
            this.lblSayBalance.Name = "lblSayBalance";
            this.lblSayBalance.Size = new System.Drawing.Size(34, 13);
            this.lblSayBalance.TabIndex = 2;
            this.lblSayBalance.Text = "مانده:";
            // 
            // lblRecive
            // 
            this.lblRecive.Location = new System.Drawing.Point(173, 25);
            this.lblRecive.Name = "lblRecive";
            this.lblRecive.Size = new System.Drawing.Size(100, 23);
            this.lblRecive.TabIndex = 3;
            this.lblRecive.Text = "0";
            // 
            // lblPay
            // 
            this.lblPay.Location = new System.Drawing.Point(173, 48);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(100, 23);
            this.lblPay.TabIndex = 4;
            this.lblPay.Text = "0";
            // 
            // lblBalance
            // 
            this.lblBalance.Location = new System.Drawing.Point(173, 71);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(100, 23);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "0";
            // 
            // btnReportingRefresh
            // 
            this.btnReportingRefresh.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnReportingRefresh.Location = new System.Drawing.Point(6, 97);
            this.btnReportingRefresh.Name = "btnReportingRefresh";
            this.btnReportingRefresh.Size = new System.Drawing.Size(339, 23);
            this.btnReportingRefresh.TabIndex = 6;
            this.btnReportingRefresh.Text = "به روز رسانی";
            this.btnReportingRefresh.UseVisualStyleBackColor = false;
            this.btnReportingRefresh.Click += new System.EventHandler(this.btnReportingRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gpbGetReport);
            this.Controls.Add(this.tstsField);
            this.Controls.Add(this.pcAccounting);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حسابداری شخصی من";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcAccounting)).EndInit();
            this.tstsField.ResumeLayout(false);
            this.tstsField.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gpbGetReport.ResumeLayout(false);
            this.gpbGetReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnCustomers;
        private System.Windows.Forms.ToolStripButton btnNewAccounting;
        private System.Windows.Forms.ToolStripButton btnReportPay;
        private System.Windows.Forms.ToolStripButton btnReportRecieve;
        private System.Windows.Forms.PictureBox pcAccounting;
        private System.Windows.Forms.StatusStrip tstsField;
        private System.Windows.Forms.ToolStripStatusLabel slblDate;
        private System.Windows.Forms.ToolStripStatusLabel slblTime;
        private System.Windows.Forms.Timer TimerTlbTime;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSetting;
        private System.Windows.Forms.GroupBox gpbGetReport;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label lblRecive;
        private System.Windows.Forms.Label lblSayBalance;
        private System.Windows.Forms.Label lblSayPay;
        private System.Windows.Forms.Label lblSayRecieve;
        private System.Windows.Forms.Button btnReportingRefresh;
    }
}

