using Accounting.DataLayer;
using Accounting.DataLayer.Context;
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
    public partial class frmLogin : Form
    {
        public bool isEdit = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    if (isEdit == true)
                    {
                        var login = unitOfWork.loginRepository.Get().First();
                        login.UserName = txtUserName.Text;
                        login.Password = txtPassword.Text;
                        unitOfWork.loginRepository.Update(login);
                        unitOfWork.Save();
                        Application.Restart();
                    }
                    else
                    {
                        if (unitOfWork.loginRepository.Get(l => l.UserName == txtUserName.Text && l.Password == txtPassword.Text).Any())
                        {
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            RtlMessageBox.Show("چنین کاربری با چنین مشخصاتی یافت نشد",
                                               "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (isEdit == true)
            {
                this.Text = "تنظیمات ورود برنامه";
                btnLogin.Text = "ذخیره تغییرات";
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    //Login login = new Login()
                    //{
                    //    UserName = txtUserName.Text,
                    //    Password = txtPassword.Text
                    //};
                    //unitofWork.loginRepository.Update(login);
                    Login login = unitofWork.loginRepository.Get().First();
                    txtUserName.Text = login.UserName;
                    txtPassword.Text = login.Password;
                }
            }
        }
    }
}
