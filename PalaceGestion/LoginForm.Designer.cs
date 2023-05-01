
namespace PalaceGestion
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox_username = new System.Windows.Forms.TextBox();
            this.TextBox_password = new System.Windows.Forms.TextBox();
            this.Button_login = new System.Windows.Forms.Button();
            this.label_exit = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_username
            // 
            this.TextBox_username.Location = new System.Drawing.Point(206, 40);
            this.TextBox_username.Name = "TextBox_username";
            this.TextBox_username.Size = new System.Drawing.Size(152, 20);
            this.TextBox_username.TabIndex = 1;
            // 
            // TextBox_password
            // 
            this.TextBox_password.Location = new System.Drawing.Point(206, 67);
            this.TextBox_password.Name = "TextBox_password";
            this.TextBox_password.Size = new System.Drawing.Size(152, 20);
            this.TextBox_password.TabIndex = 2;
            this.TextBox_password.UseSystemPasswordChar = true;
            // 
            // Button_login
            // 
            this.Button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            this.Button_login.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_login.ForeColor = System.Drawing.Color.White;
            this.Button_login.Location = new System.Drawing.Point(206, 99);
            this.Button_login.Name = "Button_login";
            this.Button_login.Size = new System.Drawing.Size(150, 36);
            this.Button_login.TabIndex = 5;
            this.Button_login.Text = "login";
            this.Button_login.UseVisualStyleBackColor = false;
            this.Button_login.Click += new System.EventHandler(this.Button_login_Click);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            this.label_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_exit.Location = new System.Drawing.Point(356, 7);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(14, 13);
            this.label_exit.TabIndex = 6;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PalaceGestion.Properties.Resources.icons8_password_24;
            this.pictureBox3.Location = new System.Drawing.Point(182, 66);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(18, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PalaceGestion.Properties.Resources.icons8_user_30__1_;
            this.pictureBox2.Location = new System.Drawing.Point(182, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PalaceGestion.Properties.Resources.Sans_titre__4_;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(377, 158);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.Button_login);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TextBox_password);
            this.Controls.Add(this.TextBox_username);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Palace";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TextBox_username;
        private System.Windows.Forms.TextBox TextBox_password;
        private System.Windows.Forms.Button Button_login;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

