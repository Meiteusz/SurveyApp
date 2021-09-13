using Controllers;
using InjectionModules;
using SurveyApp.ContentForms.AdminForms;
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
            Helper.ResizeColumns(dgvUsers, 173);
            dgvUsers.Columns["Password"].Visible = false;
        }

        private void btnRegisterUser_Click(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormRegisterUser());

        private void btnBack_Click(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormContentAdmin());

        private void dgvUsers_CellMouseDoubleClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e) 
        {
            UserSetting.SetActualUser(_userBLL.GetById((int)dgvUsers.CurrentRow.Cells[0].Value).Data);
            new FormViewUser().ShowDialog();
        }
    }
}
