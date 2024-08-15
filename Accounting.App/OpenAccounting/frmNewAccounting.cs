using Accounting.DataLayer.Context;
using Accounting.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace Accounting.App
{
    public partial class frmNewAccounting : Form
    {
        UnitOfWork unitOfWork;
        public int AccountId = 0;
        public frmNewAccounting()
        {
            InitializeComponent();
            //unitOfWork = new UnitOfWork();
        }

        private void frmNewAccounting_Load(object sender, EventArgs e)
        {
            BindGridForT();
            if (AccountId != 0)
            {
                unitOfWork = new UnitOfWork();
                var Account = unitOfWork.accountingRepository.GetById(AccountId);

                txtName.Text = unitOfWork.customerRepository.GetCustomerNameById(Account.CustomerID);
                txtDescription.Text = Account.Description;
                nmrAmount.Value = Account.Amount;

                if (Account.TypeID == 1)
                {
                    rbRecieve.Checked = true;
                }
                else
                {
                    rbPay.Checked = true;
                }
                this.Text = "ویرایش";
                btnSave.Text = "ویرایش";
                unitOfWork.Dispose();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            BindGridForT(txtFilter.Text);
        }
        void BindGridForT(string Filter = null)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                dgvCustomer.AutoGenerateColumns = false;
                dgvCustomer.DataSource = unitOfWork.customerRepository.GetCustomerByFullName(Filter);
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvCustomer.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                unitOfWork = new UnitOfWork();
                if (rbPay.Checked || rbRecieve.Checked)
                {
                    //unitOfWork = new UnitOfWork();
                    DataLayer.Accounting accounting = new DataLayer.Accounting()
                    {
                        Amount = int.Parse(nmrAmount.Value.ToString()),
                        CustomerID = unitOfWork.customerRepository.GetCustomerIdByFullName(txtName.Text),
                        DateTitle = System.DateTime.Now,
                        Description = txtDescription.Text,
                        TypeID = (rbPay.Checked) ? 2 : 1
                    };
                    if (AccountId == 0)
                    {
                        unitOfWork.accountingRepository.Insert(accounting);
                    }
                    else
                    {
                        //using(UnitOfWork unitOfWork2 = new UnitOfWork)
                        //{
                        //    accounting.ID = AccountId;
                        //    unitOfWork2.accountingRepository.Update(accounting);
                        //}
                        accounting.ID = AccountId;
                        unitOfWork.accountingRepository.Update(accounting);

                    }
                    unitOfWork.Save();
                    //unitOfWork2.Save();
                    unitOfWork.Dispose();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    RtlMessageBox.Show("لطفا نوع تراکنش را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
