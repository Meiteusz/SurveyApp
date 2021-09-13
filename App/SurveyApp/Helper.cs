using System.Collections;
using System.Windows.Forms;

namespace SurveyApp
{
    public abstract class Helper // --> Class helper to controls of forms
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

        public static void ResizeColumns(DataGridView dgv, int sizeWidth)
        {
            for (int i = 0; i < dgv.Columns.Count; i++)
                dgv.Columns[i].Width = sizeWidth;
        }

        public static string ImageCheck(string fileName)
        {
            string defaultImage = @"D:\WorkSpace\Vs\SurveyApp\App\SurveyApp\Resources\resim-yok-png-.jpg";

            if (fileName.Equals(string.Empty))
                return defaultImage; // --> Default image / improving to Surveys/Resources/resim-yok-png-.jpg
            return fileName;
        }
    }
}
