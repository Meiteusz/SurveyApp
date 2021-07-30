using System.Windows.Forms;

namespace SurveyApp
{
    public static class Helper
    {
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

        public static void ChangeForm(Form closeForm, Form openForm)
        {
            closeForm.Hide();
            openForm.ShowDialog();
            closeForm.Close();
        }
    }
}
