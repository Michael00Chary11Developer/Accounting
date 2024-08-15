namespace Accounting.App.OpenAccounting
{
    partial class frmReport
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
            this.tspReport = new System.Windows.Forms.ToolStrip();
            this.btnReportEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnReportRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnReportPrint = new System.Windows.Forms.ToolStripButton();
            this.gpbReportSearch = new System.Windows.Forms.GroupBox();
            this.btnReportFilter = new System.Windows.Forms.Button();
            this.mtxtToDate = new System.Windows.Forms.MaskedTextBox();
            this.mtxtFromDate = new System.Windows.Forms.MaskedTextBox();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblReportPerson = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stiReport = new Stimulsoft.Report.StiReport();
            this.tspReport.SuspendLayout();
            this.gpbReportSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // tspReport
            // 
            this.tspReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tspReport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReportEdit,
            this.btnDelete,
            this.btnReportRefresh,
            this.btnReportPrint});
            this.tspReport.Location = new System.Drawing.Point(0, 0);
            this.tspReport.Name = "tspReport";
            this.tspReport.Size = new System.Drawing.Size(584, 54);
            this.tspReport.TabIndex = 0;
            // 
            // btnReportEdit
            // 
            this.btnReportEdit.Image = global::Accounting.App.Properties.Resources.Edit_PNG;
            this.btnReportEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReportEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportEdit.Name = "btnReportEdit";
            this.btnReportEdit.Size = new System.Drawing.Size(47, 51);
            this.btnReportEdit.Text = "ویرایش";
            this.btnReportEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportEdit.Click += new System.EventHandler(this.btnReportEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Accounting.App.Properties.Resources.Delete_PNG;
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(36, 51);
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReportRefresh
            // 
            this.btnReportRefresh.Image = global::Accounting.App.Properties.Resources.Refresh_PNG;
            this.btnReportRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReportRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportRefresh.Name = "btnReportRefresh";
            this.btnReportRefresh.Size = new System.Drawing.Size(60, 51);
            this.btnReportRefresh.Text = "بروزرسانی";
            this.btnReportRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportRefresh.Click += new System.EventHandler(this.btnReportRefresh_Click);
            // 
            // btnReportPrint
            // 
            this.btnReportPrint.Image = global::Accounting.App.Properties.Resources.Print;
            this.btnReportPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReportPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportPrint.Name = "btnReportPrint";
            this.btnReportPrint.Size = new System.Drawing.Size(36, 51);
            this.btnReportPrint.Text = "چاپ";
            this.btnReportPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportPrint.Click += new System.EventHandler(this.btnReportPrint_Click);
            // 
            // gpbReportSearch
            // 
            this.gpbReportSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gpbReportSearch.Controls.Add(this.btnReportFilter);
            this.gpbReportSearch.Controls.Add(this.mtxtToDate);
            this.gpbReportSearch.Controls.Add(this.mtxtFromDate);
            this.gpbReportSearch.Controls.Add(this.cbCustomer);
            this.gpbReportSearch.Controls.Add(this.lblToDate);
            this.gpbReportSearch.Controls.Add(this.lblFromDate);
            this.gpbReportSearch.Controls.Add(this.lblReportPerson);
            this.gpbReportSearch.Location = new System.Drawing.Point(0, 58);
            this.gpbReportSearch.Name = "gpbReportSearch";
            this.gpbReportSearch.Size = new System.Drawing.Size(583, 53);
            this.gpbReportSearch.TabIndex = 1;
            this.gpbReportSearch.TabStop = false;
            this.gpbReportSearch.Text = "جستجو";
            // 
            // btnReportFilter
            // 
            this.btnReportFilter.BackColor = System.Drawing.Color.Aqua;
            this.btnReportFilter.Location = new System.Drawing.Point(6, 16);
            this.btnReportFilter.Name = "btnReportFilter";
            this.btnReportFilter.Size = new System.Drawing.Size(69, 23);
            this.btnReportFilter.TabIndex = 6;
            this.btnReportFilter.Text = "انجام";
            this.btnReportFilter.UseVisualStyleBackColor = false;
            this.btnReportFilter.Click += new System.EventHandler(this.btnReportFilter_Click);
            // 
            // mtxtToDate
            // 
            this.mtxtToDate.BackColor = System.Drawing.SystemColors.Info;
            this.mtxtToDate.Location = new System.Drawing.Point(76, 18);
            this.mtxtToDate.Mask = "0000/00/00";
            this.mtxtToDate.Name = "mtxtToDate";
            this.mtxtToDate.Size = new System.Drawing.Size(100, 21);
            this.mtxtToDate.TabIndex = 5;
            // 
            // mtxtFromDate
            // 
            this.mtxtFromDate.BackColor = System.Drawing.SystemColors.Info;
            this.mtxtFromDate.Location = new System.Drawing.Point(229, 18);
            this.mtxtFromDate.Mask = "0000/00/00";
            this.mtxtFromDate.Name = "mtxtFromDate";
            this.mtxtFromDate.Size = new System.Drawing.Size(100, 21);
            this.mtxtFromDate.TabIndex = 4;
            this.mtxtFromDate.ValidatingType = typeof(System.DateTime);
            // 
            // cbCustomer
            // 
            this.cbCustomer.BackColor = System.Drawing.SystemColors.Info;
            this.cbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(383, 18);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(121, 21);
            this.cbCustomer.TabIndex = 3;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(182, 21);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(41, 13);
            this.lblToDate.TabIndex = 2;
            this.lblToDate.Text = "تا تاریخ:";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(335, 21);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(42, 13);
            this.lblFromDate.TabIndex = 1;
            this.lblFromDate.Text = "از تاریخ:";
            // 
            // lblReportPerson
            // 
            this.lblReportPerson.AutoSize = true;
            this.lblReportPerson.Location = new System.Drawing.Point(510, 21);
            this.lblReportPerson.Name = "lblReportPerson";
            this.lblReportPerson.Size = new System.Drawing.Size(67, 13);
            this.lblReportPerson.TabIndex = 0;
            this.lblReportPerson.Text = "طرف حساب:";
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CustomerID,
            this.Amount,
            this.Date,
            this.Description});
            this.dgvReport.Location = new System.Drawing.Point(0, 105);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.Size = new System.Drawing.Size(583, 255);
            this.dgvReport.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "کد شخص";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "طرف حساب";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "مبلغ";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "DateTitle";
            this.Date.HeaderText = "تاریخ";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "توضیحات";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // stiReport
            // 
            this.stiReport.CookieContainer = null;
            this.stiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport.ReportAlias = "Report";
            this.stiReport.ReportGuid = "5f98a06f79be440ca01b59b71d28bd9b";
            this.stiReport.ReportName = "Report";
            this.stiReport.ReportSource = null;
            this.stiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport.UseProgressInThread = false;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.gpbReportSearch);
            this.Controls.Add(this.tspReport);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.tspReport.ResumeLayout(false);
            this.tspReport.PerformLayout();
            this.gpbReportSearch.ResumeLayout(false);
            this.gpbReportSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspReport;
        private System.Windows.Forms.ToolStripButton btnReportEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnReportRefresh;
        private System.Windows.Forms.ToolStripButton btnReportPrint;
        private System.Windows.Forms.GroupBox gpbReportSearch;
        private System.Windows.Forms.Button btnReportFilter;
        private System.Windows.Forms.MaskedTextBox mtxtToDate;
        private System.Windows.Forms.MaskedTextBox mtxtFromDate;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblReportPerson;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private Stimulsoft.Report.StiReport stiReport;
    }
}