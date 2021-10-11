
namespace SurveyApp
{
    partial class FormContentAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContentAdmin));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUserManager = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblUsersCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblUserType);
            this.panel2.Controls.Add(this.btnSettings);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1094, 107);
            this.panel2.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(93, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(121, 23);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "User Name";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.Location = new System.Drawing.Point(944, 54);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 53);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SurveyApp.Properties.Resources.user__1_;
            this.pictureBox1.Location = new System.Drawing.Point(23, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 65);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserType.ForeColor = System.Drawing.Color.White;
            this.lblUserType.Location = new System.Drawing.Point(93, 58);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(82, 18);
            this.lblUserType.TabIndex = 7;
            this.lblUserType.Text = "User Type";
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.Location = new System.Drawing.Point(944, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(150, 50);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Settings  ";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnUserManager);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 517);
            this.panel1.TabIndex = 8;
            // 
            // btnUserManager
            // 
            this.btnUserManager.BackColor = System.Drawing.Color.Gray;
            this.btnUserManager.FlatAppearance.BorderSize = 0;
            this.btnUserManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManager.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUserManager.ForeColor = System.Drawing.Color.White;
            this.btnUserManager.Location = new System.Drawing.Point(0, 208);
            this.btnUserManager.Name = "btnUserManager";
            this.btnUserManager.Size = new System.Drawing.Size(299, 76);
            this.btnUserManager.TabIndex = 10;
            this.btnUserManager.Text = "User\'s Manager";
            this.btnUserManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManager.UseVisualStyleBackColor = false;
            this.btnUserManager.Click += new System.EventHandler(this.btnUserManager_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(91, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 124);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Firebrick;
            this.panel7.Controls.Add(this.lblUsersCount);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(554, 191);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(85, 122);
            this.panel7.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "0";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(392, 191);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 122);
            this.panel4.TabIndex = 10;
            // 
            // lblUsersCount
            // 
            this.lblUsersCount.AutoSize = true;
            this.lblUsersCount.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsersCount.ForeColor = System.Drawing.Color.White;
            this.lblUsersCount.Location = new System.Drawing.Point(21, 40);
            this.lblUsersCount.Name = "lblUsersCount";
            this.lblUsersCount.Size = new System.Drawing.Size(44, 45);
            this.lblUsersCount.TabIndex = 10;
            this.lblUsersCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Users Count";
            // 
            // FormContentAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 624);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormContentAdmin";
            this.Load += new System.EventHandler(this.FormContentAdmin_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnUserManager;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblUsersCount;
        private System.Windows.Forms.Label label2;
    }
}