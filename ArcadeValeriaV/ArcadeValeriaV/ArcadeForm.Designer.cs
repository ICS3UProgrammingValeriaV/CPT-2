namespace ArcadeValeriaV
{
    partial class frmSplashScreen
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
            this.components = new System.ComponentModel.Container();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tmrBurn = new System.Windows.Forms.Timer(this.components);
            this.picCompany = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::ArcadeValeriaV.Properties.Resources.fireText2;
            this.picLogo.Location = new System.Drawing.Point(13, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(560, 386);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // tmrBurn
            // 
            this.tmrBurn.Tick += new System.EventHandler(this.tmrBurn_Tick);
            // 
            // picCompany
            // 
            this.picCompany.BackColor = System.Drawing.Color.Transparent;
            this.picCompany.Image = global::ArcadeValeriaV.Properties.Resources.GameVille9;
            this.picCompany.Location = new System.Drawing.Point(33, 404);
            this.picCompany.Name = "picCompany";
            this.picCompany.Size = new System.Drawing.Size(490, 130);
            this.picCompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCompany.TabIndex = 1;
            this.picCompany.TabStop = false;
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArcadeValeriaV.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(585, 560);
            this.Controls.Add(this.picCompany);
            this.Controls.Add(this.picLogo);
            this.Name = "frmSplashScreen";
            this.Text = "Arcade by Valeria V";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Timer tmrBurn;
        private System.Windows.Forms.PictureBox picCompany;
    }
}

