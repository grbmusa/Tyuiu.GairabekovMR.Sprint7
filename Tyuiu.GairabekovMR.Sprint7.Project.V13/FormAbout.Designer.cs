
namespace Tyuiu.GairabekovMR.Sprint7.Project.V13
{
    partial class FormAbout_GMR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_GMR));
            this.textBoxInfo_GMR = new System.Windows.Forms.TextBox();
            this.buttonExit_GMR = new System.Windows.Forms.Button();
            this.labelAbout_GMR = new System.Windows.Forms.Label();
            this.labelCompany_GMR = new System.Windows.Forms.Label();
            this.pictureBoxAva_GMR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva_GMR)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInfo_GMR
            // 
            this.textBoxInfo_GMR.BackColor = System.Drawing.Color.Green;
            this.textBoxInfo_GMR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo_GMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfo_GMR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxInfo_GMR.Location = new System.Drawing.Point(250, 58);
            this.textBoxInfo_GMR.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxInfo_GMR.Multiline = true;
            this.textBoxInfo_GMR.Name = "textBoxInfo_GMR";
            this.textBoxInfo_GMR.ReadOnly = true;
            this.textBoxInfo_GMR.Size = new System.Drawing.Size(369, 288);
            this.textBoxInfo_GMR.TabIndex = 1;
            this.textBoxInfo_GMR.TabStop = false;
            this.textBoxInfo_GMR.Text = resources.GetString("textBoxInfo_GMR.Text");
            // 
            // buttonExit_GMR
            // 
            this.buttonExit_GMR.BackColor = System.Drawing.Color.Lime;
            this.buttonExit_GMR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit_GMR.Location = new System.Drawing.Point(-9, 350);
            this.buttonExit_GMR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit_GMR.Name = "buttonExit_GMR";
            this.buttonExit_GMR.Size = new System.Drawing.Size(638, 22);
            this.buttonExit_GMR.TabIndex = 2;
            this.buttonExit_GMR.TabStop = false;
            this.buttonExit_GMR.Text = "Выйти";
            this.buttonExit_GMR.UseVisualStyleBackColor = false;
            this.buttonExit_GMR.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAbout_GMR
            // 
            this.labelAbout_GMR.AutoSize = true;
            this.labelAbout_GMR.Font = new System.Drawing.Font("MV Boli", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAbout_GMR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelAbout_GMR.Location = new System.Drawing.Point(329, 3);
            this.labelAbout_GMR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAbout_GMR.MinimumSize = new System.Drawing.Size(167, 52);
            this.labelAbout_GMR.Name = "labelAbout_GMR";
            this.labelAbout_GMR.Size = new System.Drawing.Size(179, 52);
            this.labelAbout_GMR.TabIndex = 3;
            this.labelAbout_GMR.Text = "About Uss";
            // 
            // labelCompany_GMR
            // 
            this.labelCompany_GMR.AutoSize = true;
            this.labelCompany_GMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCompany_GMR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelCompany_GMR.Location = new System.Drawing.Point(8, 6);
            this.labelCompany_GMR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCompany_GMR.MinimumSize = new System.Drawing.Size(200, 49);
            this.labelCompany_GMR.Name = "labelCompany_GMR";
            this.labelCompany_GMR.Size = new System.Drawing.Size(317, 49);
            this.labelCompany_GMR.TabIndex = 4;
            this.labelCompany_GMR.Text = "TyuiuGeoGraphics";
            // 
            // pictureBoxAva_GMR
            // 
            this.pictureBoxAva_GMR.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pictureBoxAva_GMR.Location = new System.Drawing.Point(8, 58);
            this.pictureBoxAva_GMR.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxAva_GMR.Name = "pictureBoxAva_GMR";
            this.pictureBoxAva_GMR.Size = new System.Drawing.Size(238, 288);
            this.pictureBoxAva_GMR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAva_GMR.TabIndex = 0;
            this.pictureBoxAva_GMR.TabStop = false;
            // 
            // FormAbout_GMR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(623, 370);
            this.Controls.Add(this.labelCompany_GMR);
            this.Controls.Add(this.labelAbout_GMR);
            this.Controls.Add(this.buttonExit_GMR);
            this.Controls.Add(this.textBoxInfo_GMR);
            this.Controls.Add(this.pictureBoxAva_GMR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout_GMR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О нас";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva_GMR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxInfo_GMR;
        private System.Windows.Forms.Button buttonExit_GMR;
        private System.Windows.Forms.Label labelAbout_GMR;
        private System.Windows.Forms.Label labelCompany_GMR;
        private System.Windows.Forms.PictureBox pictureBoxAva_GMR;
    }
}