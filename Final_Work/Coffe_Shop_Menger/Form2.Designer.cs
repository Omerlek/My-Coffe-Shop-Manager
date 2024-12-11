
namespace CPPGroupProject2.Frontend.Forms
{
    partial class FormPictureBox
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
            this.pictureBoxRandomPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRandomPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxRandomPicture
            // 
            this.pictureBoxRandomPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxRandomPicture.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxRandomPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxRandomPicture.Name = "pictureBoxRandomPicture";
            this.pictureBoxRandomPicture.Size = new System.Drawing.Size(1026, 622);
            this.pictureBoxRandomPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRandomPicture.TabIndex = 0;
            this.pictureBoxRandomPicture.TabStop = false;
            this.pictureBoxRandomPicture.Click += new System.EventHandler(this.pictureBoxRandomPicture_Click);
            // 
            // FormPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 622);
            this.Controls.Add(this.pictureBoxRandomPicture);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPictureBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPictureBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRandomPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRandomPicture;
    }
}