
namespace SurveyApp
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cbShowHidePassword = new System.Windows.Forms.CheckBox();
            this.btnPassword = new System.Windows.Forms.Button();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLogin.Location = new System.Drawing.Point(218, 60);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PlaceholderText = "Login";
            this.txtLogin.Size = new System.Drawing.Size(298, 27);
            this.txtLogin.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(218, 121);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(244, 27);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // cbShowHidePassword
            // 
            this.cbShowHidePassword.AutoSize = true;
            this.cbShowHidePassword.BackColor = System.Drawing.Color.Transparent;
            this.cbShowHidePassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbShowHidePassword.ForeColor = System.Drawing.Color.Black;
            this.cbShowHidePassword.Location = new System.Drawing.Point(387, 154);
            this.cbShowHidePassword.Name = "cbShowHidePassword";
            this.cbShowHidePassword.Size = new System.Drawing.Size(129, 24);
            this.cbShowHidePassword.TabIndex = 5;
            this.cbShowHidePassword.Text = "Show Password";
            this.cbShowHidePassword.UseVisualStyleBackColor = false;
            this.cbShowHidePassword.CheckedChanged += new System.EventHandler(this.cbShowHidePassword_CheckedChanged);
            // 
            // btnPassword
            // 
            this.btnPassword.BackColor = System.Drawing.Color.Red;
            this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPassword.Location = new System.Drawing.Point(462, 120);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(55, 29);
            this.btnPassword.TabIndex = 6;
            this.btnPassword.UseVisualStyleBackColor = false;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnLogin.Location = new System.Drawing.Point(218, 199);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(122, 47);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 307);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.cbShowHidePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "FormLogin";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox cbShowHidePassword;
        private System.Windows.Forms.Button btnPassword;
        private MetroFramework.Controls.MetroButton btnLogin;
    }
}

