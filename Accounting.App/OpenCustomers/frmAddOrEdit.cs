using Accounting.DataLayer.Context;
using Accounting.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace Accounting.App.OpenCustomers
{
    public partial class frmAddOrEdit : Form
    {
        public int customerId = 0;
        UnitOfWork unitOfWork = new UnitOfWork();
        public frmAddOrEdit()
        {
            InitializeComponent();
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pcCustomers.ImageLocation = openFile.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                string imageName = Guid.NewGuid().ToString() + Path.GetExtension(pcCustomers.ImageLocation);
                string path = Application.StartupPath + "/Images/" + imageName;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                pcCustomers.Image.Save(path + imageName);

                Customers customers = new Customers()
                {
                    FullName = txtFullName.Text,
                    MobilePhoneNumber = txtMobilePhoneNumber.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    CustomerImage = imageName

                };
                if (customerId == 0)
                {
                    unitOfWork.customerRepository.InsertCustomers(customers);
                }
                else
                {
                    customers.CustomerID = customerId;
                    unitOfWork.customerRepository.UpdateCustomers(customers);
                }

                unitOfWork.Save();

                DialogResult = DialogResult.OK;
            }
        }

        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {
            if (customerId != 0)
            {
                this.Text = "ویرایش شخص";
                btnSave.Text = "ویرایش";
                var customers = unitOfWork.customerRepository.GetCustomerByID(customerId);
                txtAddress.Text = customers.Address;
                txtEmail.Text = customers.Email;
                txtFullName.Text = customers.FullName;
                txtMobilePhoneNumber.Text = customers.MobilePhoneNumber;
                pcCustomers.ImageLocation = Application.StartupPath + "/Images/" + pcCustomers.ImageLocation;
            }
        }
    }
}
