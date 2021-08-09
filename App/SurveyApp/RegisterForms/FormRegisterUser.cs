using Controllers;
using InjectionModules;
using Models.Enums;
using System;
using System.Windows.Forms;

namespace SurveyApp.RegisterForms
{
    public partial class FormRegisterUser : MetroFramework.Forms.MetroForm
    {
        private readonly IUserBLL _userBLL;

        public FormRegisterUser()
        {
            InitializeComponent();
            _userBLL = new UserBLL(Module.ConfiguratingModule());
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var response = _userBLL.Insert(_userBLL.Create(txtName.Text, UserTypeVerifier(), txtCpf.Text, txtEmail.Text, txtLogin.Text, txtPassword.Text));

            MessageBox.Show(response.Messege);
        }

        private byte UserTypeVerifier()  //Clean later
        {
            if (rbAnalist.Checked)
                return ((byte)UserTypes.Analist);
            return ((byte)UserTypes.Operator);
        }
    }
}
