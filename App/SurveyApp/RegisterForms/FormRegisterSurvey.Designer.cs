
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnLocalImage = new MetroFramework.Controls.MetroButton();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.ofdLocalImage = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocalImage)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(544, 115);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 19);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Local Image";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(92, 361);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Adress";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(92, 196);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Description";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(92, 113);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Date";
            // 
            // pbLocalImage
            // 
            this.pbLocalImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLocalImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbLocalImage.ErrorImage")));
            this.pbLocalImage.Image = global::SurveyApp.Properties.Resources.Insert_Image_Here;
            this.pbLocalImage.Location = new System.Drawing.Point(544, 138);
            this.pbLocalImage.Name = "pbLocalImage";
            this.pbLocalImage.Size = new System.Drawing.Size(228, 223);
            this.pbLocalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLocalImage.TabIndex = 1;
            this.pbLocalImage.TabStop = false;
            this.pbLocalImage.Click += new System.EventHandler(this.pbLocalImage_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(92, 383);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(369, 27);
            this.textBox1.TabIndex = 13;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(92, 218);
            this.richTextBox1.MaxLength = 250;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(369, 115);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // btnLocalImage
            // 
            this.btnLocalImage.Location = new System.Drawing.Point(544, 367);
            this.btnLocalImage.Name = "btnLocalImage";
            this.btnLocalImage.Size = new System.Drawing.Size(228, 43);
            this.btnLocalImage.TabIndex = 11;
            this.btnLocalImage.Text = "Open a image";
            this.btnLocalImage.UseSelectable = true;
            this.btnLocalImage.Click += new System.EventHandler(this.btnLocalImage_Click);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroDateTime1.Location = new System.Drawing.Point(92, 138);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(369, 29);
            this.metroDateTime1.TabIndex = 10;
            // 
            // ofdLocalImage
            // 
            this.ofdLocalImage.FileName = "openFileDialog1";
            // 
            // FormRegisterSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 502);
            this.Controls.Add(this.pbLocalImage);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnLocalImage);
            this.Controls.Add(this.metroDateTime1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MetroFramework.Controls.MetroButton btnLocalImage;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private System.Windows.Forms.OpenFileDialog ofdLocalImage;
    }
}