
namespace PalaceGestion
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_chambres = new System.Windows.Forms.Button();
            this.button_reception = new System.Windows.Forms.Button();
            this.button_clients = new System.Windows.Forms.Button();
            this.button_tableauDeBord = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_cover = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_cover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_logout);
            this.panel1.Controls.Add(this.button_chambres);
            this.panel1.Controls.Add(this.button_reception);
            this.panel1.Controls.Add(this.button_clients);
            this.panel1.Controls.Add(this.button_tableauDeBord);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 800);
            this.panel1.TabIndex = 0;
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            this.button_logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_logout.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.ForeColor = System.Drawing.Color.White;
            this.button_logout.Location = new System.Drawing.Point(0, 660);
            this.button_logout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(173, 129);
            this.button_logout.TabIndex = 5;
            this.button_logout.Text = "Déconnexion";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_chambres
            // 
            this.button_chambres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            this.button_chambres.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_chambres.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_chambres.ForeColor = System.Drawing.Color.White;
            this.button_chambres.Location = new System.Drawing.Point(0, 531);
            this.button_chambres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_chambres.Name = "button_chambres";
            this.button_chambres.Size = new System.Drawing.Size(173, 129);
            this.button_chambres.TabIndex = 4;
            this.button_chambres.Text = "Chambres";
            this.button_chambres.UseVisualStyleBackColor = false;
            this.button_chambres.Click += new System.EventHandler(this.button_chambres_Click);
            // 
            // button_reception
            // 
            this.button_reception.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            this.button_reception.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_reception.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reception.ForeColor = System.Drawing.Color.White;
            this.button_reception.Location = new System.Drawing.Point(0, 402);
            this.button_reception.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_reception.Name = "button_reception";
            this.button_reception.Size = new System.Drawing.Size(173, 129);
            this.button_reception.TabIndex = 3;
            this.button_reception.Text = "Réception";
            this.button_reception.UseVisualStyleBackColor = false;
            this.button_reception.Click += new System.EventHandler(this.button_reception_Click);
            // 
            // button_clients
            // 
            this.button_clients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            this.button_clients.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_clients.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clients.ForeColor = System.Drawing.Color.White;
            this.button_clients.Location = new System.Drawing.Point(0, 273);
            this.button_clients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_clients.Name = "button_clients";
            this.button_clients.Size = new System.Drawing.Size(173, 129);
            this.button_clients.TabIndex = 2;
            this.button_clients.Text = "Clients";
            this.button_clients.UseVisualStyleBackColor = false;
            this.button_clients.Click += new System.EventHandler(this.button_clients_Click);
            // 
            // button_tableauDeBord
            // 
            this.button_tableauDeBord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            this.button_tableauDeBord.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_tableauDeBord.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tableauDeBord.ForeColor = System.Drawing.Color.White;
            this.button_tableauDeBord.Location = new System.Drawing.Point(0, 144);
            this.button_tableauDeBord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_tableauDeBord.Name = "button_tableauDeBord";
            this.button_tableauDeBord.Size = new System.Drawing.Size(173, 129);
            this.button_tableauDeBord.TabIndex = 1;
            this.button_tableauDeBord.Text = "Tableau de bord";
            this.button_tableauDeBord.UseVisualStyleBackColor = false;
            this.button_tableauDeBord.Click += new System.EventHandler(this.button_tableauDeBord_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 144);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PalaceGestion.Properties.Resources.Sans_titre__9_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_cover
            // 
            this.panel_cover.Controls.Add(this.pictureBox4);
            this.panel_cover.Controls.Add(this.pictureBox3);
            this.panel_cover.Controls.Add(this.pictureBox2);
            this.panel_cover.Controls.Add(this.label_exit);
            this.panel_cover.Controls.Add(this.label1);
            this.panel_cover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_cover.Location = new System.Drawing.Point(0, 0);
            this.panel_cover.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_cover.Name = "panel_cover";
            this.panel_cover.Size = new System.Drawing.Size(1006, 800);
            this.panel_cover.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PalaceGestion.Properties.Resources.Sans_titre__15_;
            this.pictureBox4.Location = new System.Drawing.Point(587, 350);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(403, 436);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PalaceGestion.Properties.Resources._189_131_52;
            this.pictureBox3.Location = new System.Drawing.Point(0, 350);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(563, 436);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PalaceGestion.Properties.Resources.Sans_titre__11_;
            this.pictureBox2.Location = new System.Drawing.Point(0, 97);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(989, 233);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            this.label_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label_exit.ForeColor = System.Drawing.Color.White;
            this.label_exit.Location = new System.Drawing.Point(963, 11);
            this.label_exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(20, 20);
            this.label_exit.TabIndex = 1;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(284, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.label1.Size = new System.Drawing.Size(295, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = " Système de Gestion Hôtelière";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_cover);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(194, 0);
            this.panel_main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1006, 800);
            this.panel_main.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(173, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(21, 800);
            this.panel2.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_cover.ResumeLayout(false);
            this.panel_cover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_cover;
        private System.Windows.Forms.Button button_chambres;
        private System.Windows.Forms.Button button_reception;
        private System.Windows.Forms.Button button_clients;
        private System.Windows.Forms.Button button_tableauDeBord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}