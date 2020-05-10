namespace PFE
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Code = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Oublie_Mot_De_Passe = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Email.ForeColor = System.Drawing.Color.Black;
            this.Email.HintForeColor = System.Drawing.Color.Empty;
            this.Email.HintText = "";
            this.Email.isPassword = false;
            this.Email.LineFocusedColor = System.Drawing.Color.Blue;
            this.Email.LineIdleColor = System.Drawing.Color.Gray;
            this.Email.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Email.LineThickness = 3;
            this.Email.Location = new System.Drawing.Point(18, 125);
            this.Email.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(199, 38);
            this.Email.TabIndex = 0;
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Code
            // 
            this.Code.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Code.ForeColor = System.Drawing.Color.Black;
            this.Code.HintForeColor = System.Drawing.Color.Empty;
            this.Code.HintText = "";
            this.Code.isPassword = false;
            this.Code.LineFocusedColor = System.Drawing.Color.Blue;
            this.Code.LineIdleColor = System.Drawing.Color.Gray;
            this.Code.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Code.LineThickness = 3;
            this.Code.Location = new System.Drawing.Point(18, 189);
            this.Code.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(199, 38);
            this.Code.TabIndex = 1;
            this.Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Oublie_Mot_De_Passe
            // 
            this.Oublie_Mot_De_Passe.AutoSize = true;
            this.Oublie_Mot_De_Passe.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Oublie_Mot_De_Passe.Location = new System.Drawing.Point(48, 297);
            this.Oublie_Mot_De_Passe.Name = "Oublie_Mot_De_Passe";
            this.Oublie_Mot_De_Passe.Size = new System.Drawing.Size(120, 15);
            this.Oublie_Mot_De_Passe.TabIndex = 2;
            this.Oublie_Mot_De_Passe.TabStop = true;
            this.Oublie_Mot_De_Passe.Text = "Oublie Mot De Passe";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(50, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(210, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 24);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(237, 337);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Oublie_Mot_De_Passe);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.Email);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox Email;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Code;
        private System.Windows.Forms.LinkLabel Oublie_Mot_De_Passe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}