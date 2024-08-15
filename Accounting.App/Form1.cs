using Accounting.App.OpenAccounting;
using Accounting.Utility.Convertor;
using Accounting.ViewModel.AccountViewModel;
using Accounting.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers frmCustomers = new frmCustomers();
            frmCustomers.ShowDialog();
        }

        private void btnNewAccounting_Click(object sender, EventArgs e)
        {
            frmNewAccounting frmNewAccounting = new frmNewAccounting();
            frmNewAccounting.ShowDialog();
        }

        private void btnReportPay_Click(object sender, EventArgs e)
        {
            frmReport frmReport = new frmReport();
            frmReport.TypeId = 2;
            frmReport.ShowDialog();
        }

        private void btnReportRecieve_Click(object sender, EventArgs e)
        {
            frmReport frmReport = new frmReport();
            frmReport.TypeId = 1;
            frmReport.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Hide();
            frmLogin frmlogin = new frmLogin();
            if (frmlogin.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                slblDate.Text = DateTime.Now.ToPersianDate();
                slblTime.Text = DateTime.Now.ToString("HH:MM:ss");
                Report();
            }
            else
            {
                Application.Exit();
            }

        }

        void Report()
        {
            AccountViewModel Report = Account.AccountModel();
            lblPay.Text = Report.pay.ToString("#,0");
            lblRecive.Text = Report.recieve.ToString("#,0");
            lblBalance.Text = Report.AccountBalance.ToString("#,0");
        }

        private void TimerTlbTime_Tick(object sender, EventArgs e)
        {
            slblTime.Text = DateTime.Now.ToString("HH:MM:ss");
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            frmLogin frmlogin = new frmLogin();
            frmlogin.isEdit = true;
            frmlogin.ShowDialog();
        }

        private void btnReportingRefresh_Click(object sender, EventArgs e)
        {
            Report();
        }
    }
}
