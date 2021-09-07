
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocalImage)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(698, 101);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 19);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Local Image";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(180, 373);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Adress";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(180, 198);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Description";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(180, 101);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Opening Date";
            // 
            // pbLocalImage
            // 
            this.pbLocalImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLocalImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLocalImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbLocalImage.ErrorImage")));
            this.pbLocalImage.InitialImage = global::SurveyApp.Properties.Resources.Insert_Image_Here;
            this.pbLocalImage.Location = new System.Drawing.Point(698, 124);
            this.pbLocalImage.Name = "pbLocalImage";
            this.pbLocalImage.Size = new System.Drawing.Size(228, 223);
            this.pbLocalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLocalImage.TabIndex = 1;
            this.pbLocalImage.TabStop = false;
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAdress.Location = new System.Drawing.Point(180, 395);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(369, 27);
            this.txtAdress.TabIndex = 13;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.Location = new System.Drawing.Point(180, 220);
            this.txtDescription.MaxLength = 250;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(369, 115);
            this.txtDescription.TabIndex = 12;
            this.txtDescription.Text = "";
            // 
            // btnLocalImage
            // 
            this.btnLocalImage.Location = new System.Drawing.Point(698, 351);
            this.btnLocalImage.Name = "btnLocalImage";
            this.btnLocalImage.Size = new System.Drawing.Size(228, 28);
            this.btnLocalImage.TabIndex = 11;
            this.btnLocalImage.Text = "Upload  Image";
            this.btnLocalImage.UseSelectable = true;
            this.btnLocalImage.Click += new System.EventHandler(this.btnLocalImage_Click);
            // 
            // dtpOpeningDate
            // 
            this.dtpOpeningDate.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpOpeningDate.Location = new System.Drawing.Point(180, 123);
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
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Image = global::SurveyApp.Properties.Resources.close;
            this.btnBack.Location = new System.Drawing.Point(180, 519);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(172, 71);
            this.btnBack.TabIndex = 30;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnRegister
            // 
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.Image = global::SurveyApp.Properties.Resources._checked;
            this.btnRegister.Location = new System.Drawing.Point(377, 519);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(172, 71);
            this.btnRegister.TabIndex = 29;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click_1);
            // 
            // FormRegisterSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 624);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegister);
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
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRegister;
    }
}