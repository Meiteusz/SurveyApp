using Controllers;
using InjectionModules;
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
            _userBLL = new UserBLL(UserModule.ConfiguratingModule());
            cbmUserTypes.DataSource = _userBLL.GetUserTypes();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var response = _userBLL.Insert(_userBLL.Create(txtName.Text, (byte)cbmUserTypes.SelectedIndex, txtCpf.Text, txtLogin.Text, txtEmail.Text, _userBLL.EncryptPassword(txtPassword.Text).Data));
            
            MessageBox.Show(response.Message);
        }
        private void btnBack_Click(object sender, EventArgs e) => Helper.ChangeForm(this, new FormContentAdmin());

        private void btnPassword_Click(object sender, EventArgs e) 
        {
            new FormPassword().ShowDialog();
            txtPassword.Text = FormPassword.Password;
        }

        private void cbShowHidePassword_CheckedChanged(object sender, EventArgs e) => Helper.ShowHidePassword(cbShowHidePassword, txtPassword);
    }
}
