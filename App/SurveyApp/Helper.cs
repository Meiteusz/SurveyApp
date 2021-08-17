using System.Collections;
using System.Windows.Forms;

namespace SurveyApp
{
    public abstract class Helper // --> Class helper to controls forms
    {
        public static Form OwnerForm { get; private set; }
        public static void SetOwnerForm(Form ownerForm) => OwnerForm = ownerForm;

        public static void ChangeForm(Form closeForm, Form openForm)
        {
            closeForm.Hide();
            openForm.ShowDialog();
            closeForm.Close();
        }

        public static void ShowHidePassword(CheckBox cb, TextBox txtPassword)
        {
            if (cb.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                cb.Text = "Hide Password";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                cb.Text = "Show Password";
            }
        }

        public static void LoadDataGrid(DataGridView dgv, IEnumerable dataList)
        {
            dgv.DataSource = dataList;
            dgv.Columns["Id"].Visible = false;
        }
    }
}
