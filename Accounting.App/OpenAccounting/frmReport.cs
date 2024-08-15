using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using Accounting.Utility.Convertor;
using Accounting.ViewModel.CustomerModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Stimulsoft.Report.StiOptions;

namespace Accounting.App.OpenAccounting
{
    public partial class frmReport : Form
    {
        //UnitOfWork unitOfWork;
        public int TypeId = 0;
        public frmReport()
        {
            InitializeComponent();
            //unitOfWork = new UnitOfWork();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                List<ListCustomerViewModel> list = new List<ListCustomerViewModel>();
                list.Add(new ListCustomerViewModel()
                {
                    FullName = "لطفا نام را انتخاب کنید",
                    CustomerID = 0
                });
                list.AddRange(unitOfWork.customerRepository.GetCustomerByFullName());
                cbCustomer.DataSource = list;
                cbCustomer.DisplayMember = "FullNAME";
                cbCustomer.ValueMember = "CustomerID";
            }

            if (TypeId == 2)
            {
                this.Text = "گزارش پرداختی ها";
            }
            else
            {
                this.Text = "گزارش دریافتی ها";
            }
        }

        private void btnReportFilter_Click(object sender, EventArgs e)
        {
            filter();
        }

        void filter()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                DateTime? StartDate;
                DateTime? EndDate;

                List<DataLayer.Accounting> Result = new List<DataLayer.Accounting>();
                if ((int)cbCustomer.SelectedValue != 0)
                {
                    int customerId = int.Parse(cbCustomer.SelectedValue.ToString());
                    Result.AddRange(unitOfWork.accountingRepository.Get(c => c.TypeID == TypeId && c.CustomerID == customerId));
                }
                else
                {
                    Result.AddRange(unitOfWork.accountingRepository.Get(a => a.TypeID == TypeId));
                }

                if (mtxtFromDate.Text != "    /  /")
                {
                    StartDate = DateTime.Parse(mtxtFromDate.Text);
                    StartDate = ConvertorDate.ToMiladi(StartDate.Value);
                    Result = Result.Where(r => r.DateTitle >= StartDate).ToList();
                }

                if (mtxtFromDate.Text != "    /  /")
                {
                    EndDate = Convert.ToDateTime(mtxtToDate.Text);
                    EndDate = ConvertorDate.ToMiladi(EndDate.Value);
                    Result = Result.Where(r => r.DateTitle <= EndDate).ToList();
                }

                //if(StartDate!= "    /  /")
                //{
                //     incorrect format because of is null getter
                //}

                //var Result = unitOfWork.accountingRepository.Get(a => a.TypeID == TypeId);
                //dgvReport.AutoGenerateColumns = false;
                //dgvReport.DataSource = Result;

                dgvReport.Rows.Clear();
                foreach (var accounting in Result)
                {
                    //Customers customers = unitOfWork.customerRepository.GetCustomerByID(accounting.CustomerID);
                    //string CustomerNameById = customers.FullName;
                    //AnotherWayIsAbove
                    string CustomerName = unitOfWork.customerRepository.GetCustomerNameById(accounting.CustomerID);
                    dgvReport.Rows.Add(accounting.ID, CustomerName, accounting.Amount, accounting.DateTitle.ToPersianDate(), accounting.Description);
                    //dgvReport.Rows.Add(accounting.ID, CustomerNameById, accounting.Amount, accounting.DateTitle.ToPersianDate(), accounting.Description);
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReport.CurrentRow != null)
            {
                string cutomerName = dgvReport.CurrentRow.Cells[1].Value.ToString();
                int id = int.Parse(dgvReport.CurrentRow.Cells[0].Value.ToString());
                if (RtlMessageBox.Show($"آیا از حذف {cutomerName} مطمینید", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    using (UnitOfWork unitOfWork = new UnitOfWork())
                    {
                        unitOfWork.accountingRepository.Delete(id);
                        unitOfWork.Save();
                        filter();
                    }
            }
            else
            {
                RtlMessageBox.Show("لطفا یک شخص را انتخاب کنید!!!", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReportRefresh_Click(object sender, EventArgs e)
        {
            filter();
        }

        private void btnReportEdit_Click(object sender, EventArgs e)
        {
            if (dgvReport.CurrentRow != null)
            {
                int id = int.Parse(dgvReport.CurrentRow.Cells[0].Value.ToString());
                frmNewAccounting frmNewAccounting = new frmNewAccounting();
                frmNewAccounting.AccountId = id;
                if (frmNewAccounting.ShowDialog() == DialogResult.OK)
                {
                    filter();
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا یک نفر را جهت ویرایش انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnReportPrint_Click(object sender, EventArgs e)
        {
            DataTable dtPrint = new DataTable();
            dtPrint.Columns.Add("Customer");
            dtPrint.Columns.Add("Amount");
            dtPrint.Columns.Add("Date");
            dtPrint.Columns.Add("Description");

            foreach (DataGridViewRow item in dgvReport.Rows)
            {
                dtPrint.Rows.Add
                    (
                    item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString(),
                    item.Cells[4].Value.ToString()
                    );

                string pathStimulSoft = System.IO.Path.Combine(Application.StartupPath, "Report", "Report.mrt.mrt");
                stiReport.Load(pathStimulSoft);
                //stiReport.Load(Application.StartupPath + "/Report/Report.mrt");
                stiReport.RegData("DT", dtPrint);
                stiReport.Show();
                stiReport.Print();
            }
        }
    }
}
