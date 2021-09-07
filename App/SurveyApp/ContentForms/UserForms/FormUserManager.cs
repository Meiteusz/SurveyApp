using Controllers;
using InjectionModules;
using SurveyApp.RegisterForms;

namespace SurveyApp.ContentForms.UserForms
{
    public partial class FormUserManager : MetroFramework.Forms.MetroForm
    {
        private readonly IUserBLL _userBLL;

        public FormUserManager()
        {
            InitializeComponent();

            _userBLL = new UserBLL(UserModule.ConfiguratingModule());
        }

        private void FormUserManager_Load(object sender, System.EventArgs e)
        {
            Helper.LoadDataGrid(dgvUsers, _userBLL.GetAll().Data);
        }

        private void btnRegisterUser_Click(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormRegisterUser());

        private void btnBack_Click(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormContentAdmin());
    }
}
