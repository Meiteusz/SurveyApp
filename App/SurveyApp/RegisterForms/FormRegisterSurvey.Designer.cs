
namespace SurveyApp.RegisterForms
{
    partial class FormRegisterSurvey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterSurvey));
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pbLocalImage = new System.Windows.Forms.PictureBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.btnLocalImage = new MetroFramework.Controls.MetroButton();
            this.dtpOpeningDate = new MetroFramework.Controls.MetroDateTime();
            this.ofdLocalImage = new System.Windows.Forms.OpenFileDialog();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnRegister = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocalImage)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(541, 87);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 19);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Local Image";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(89, 316);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Adress";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(89, 158);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Description";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(89, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Opening Date";
            // 
            // pbLocalImage
            // 
            this.pbLocalImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLocalImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbLocalImage.ErrorImage")));
            this.pbLocalImage.Image = global::SurveyApp.Properties.Resources.Insert_Image_Here;
            this.pbLocalImage.Location = new System.Drawing.Point(541, 110);
            this.pbLocalImage.Name = "pbLocalImage";
            this.pbLocalImage.Size = new System.Drawing.Size(228, 223);
            this.pbLocalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLocalImage.TabIndex = 1;
            this.pbLocalImage.TabStop = false;
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAdress.Location = new System.Drawing.Point(89, 338);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(369, 27);
            this.txtAdress.TabIndex = 13;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.Location = new System.Drawing.Point(89, 180);
            this.txtDescription.MaxLength = 250;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(369, 115);
            this.txtDescription.TabIndex = 12;
            this.txtDescription.Text = "";
            // 
            // btnLocalImage
            // 
            this.btnLocalImage.Location = new System.Drawing.Point(541, 337);
            this.btnLocalImage.Name = "btnLocalImage";
            this.btnLocalImage.Size = new System.Drawing.Size(228, 28);
            this.btnLocalImage.TabIndex = 11;
            this.btnLocalImage.Text = "Open Image";
            this.btnLocalImage.UseSelectable = true;
            this.btnLocalImage.Click += new System.EventHandler(this.btnLocalImage_Click);
            // 
            // dtpOpeningDate
            // 
            this.dtpOpeningDate.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpOpeningDate.Location = new System.Drawing.Point(89, 110);
            this.dtpOpeningDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpOpeningDate.Name = "dtpOpeningDate";
            this.dtpOpeningDate.Size = new System.Drawing.Size(369, 29);
            this.dtpOpeningDate.TabIndex = 10;
            // 
            // ofdLocalImage
            // 
            this.ofdLocalImage.FileName = "openFileDialog1";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(89, 421);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(156, 58);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(613, 421);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(156, 58);
            this.btnRegister.TabIndex = 20;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseSelectable = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // FormRegisterSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 502);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pbLocalImage);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnLocalImage);
            this.Controls.Add(this.dtpOpeningDate);
            this.Name = "FormRegisterSurvey";
            this.Text = "Register Survey";
            ((System.ComponentModel.ISupportInitialize)(this.pbLocalImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pbLocalImage;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.RichTextBox txtDescription;
        private MetroFramework.Controls.MetroButton btnLocalImage;
        private MetroFramework.Controls.MetroDateTime dtpOpeningDate;
        private System.Windows.Forms.OpenFileDialog ofdLocalImage;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnRegister;
    }
}