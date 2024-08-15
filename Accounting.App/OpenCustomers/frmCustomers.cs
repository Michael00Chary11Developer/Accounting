using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.App.OpenCustomers;
using Accounting.DataLayer.Context;

namespace Accounting.App
{
    public partial class frmCustomers : Form
    {

        public frmCustomers()
        {
            InitializeComponent();
        }

        private void btnRefreshCustomer_Click(object sender, EventArgs e)
        {
            txtSearchCustomer.Text = string.Empty;
            bindGrid();
        }

        void bindGrid()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                dgvCustomers.AutoGenerateColumns = false;
                dgvCustomers.DataSource = unitOfWork.customerRepository.GetAllCustomers();
            }

        }

        void SearchResult()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                dgvCustomers.DataSource = unitOfWork.customerRepository.GetCustomersByFilter(txtSearchCustomer.Text);
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            SearchResult();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            bindGrid();
        }

        private void txtSearch_Change(object sender, EventArgs e)
        {
            SearchResult();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    string fullName = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
                    if (RtlMessageBox.Show($"آیا از حذف {fullName} مطمینید", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        int customerId = int.Parse(dgvCustomers.CurrentRow.Cells[0].Value.ToString());
                        unitOfWork.customerRepository.DeleteCustomerById(customerId);
                        unitOfWork.Save();
                        bindGrid();
                    }
                }
            }
            else
            {
                if (RtlMessageBox.Show("لطفا یک شخص را برای حذف انتخاب کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    txtSearchCustomer.Text = string.Empty;
                    bindGrid();
                }
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddOrEdit frmAdd = new frmAddOrEdit();
            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                bindGrid();
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                frmAddOrEdit frmEdit = new frmAddOrEdit();
                int customerId = int.Parse(dgvCustomers.CurrentRow.Cells[0].Value.ToString());
                frmEdit.customerId = customerId;
                if (frmEdit.ShowDialog() == DialogResult.OK)
                {
                    bindGrid();
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا یک شخص را برای ویرایش انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
