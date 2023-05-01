
namespace PalaceGestion
{
    partial class GuestForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_button = new System.Windows.Forms.Panel();
            this.button_effacer = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_maj = new System.Windows.Forms.Button();
            this.button_enregistrer = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_prenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ville = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_exit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_guest = new System.Windows.Forms.DataGridView();
            this.panel_button.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_guest)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_button
            // 
            this.panel_button.Controls.Add(this.button_effacer);
            this.panel_button.Controls.Add(this.button_supprimer);
            this.panel_button.Controls.Add(this.button_maj);
            this.panel_button.Controls.Add(this.button_enregistrer);
            this.panel_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_button.Location = new System.Drawing.Point(0, 743);
            this.panel_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(1005, 57);
            this.panel_button.TabIndex = 0;
            // 
            // button_effacer
            // 
            this.button_effacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            this.button_effacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_effacer.ForeColor = System.Drawing.Color.White;
            this.button_effacer.Location = new System.Drawing.Point(717, 0);
            this.button_effacer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_effacer.Name = "button_effacer";
            this.button_effacer.Size = new System.Drawing.Size(169, 71);
            this.button_effacer.TabIndex = 6;
            this.button_effacer.Text = "Effacer";
            this.button_effacer.UseVisualStyleBackColor = false;
            this.button_effacer.Click += new System.EventHandler(this.button_effacer_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            this.button_supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_supprimer.ForeColor = System.Drawing.Color.White;
            this.button_supprimer.Location = new System.Drawing.Point(524, 0);
            this.button_supprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(169, 71);
            this.button_supprimer.TabIndex = 4;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = false;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_maj
            // 
            this.button_maj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            this.button_maj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_maj.ForeColor = System.Drawing.Color.White;
            this.button_maj.Location = new System.Drawing.Point(335, 0);
            this.button_maj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_maj.Name = "button_maj";
            this.button_maj.Size = new System.Drawing.Size(169, 71);
            this.button_maj.TabIndex = 3;
            this.button_maj.Text = "Mettre à jour";
            this.button_maj.UseVisualStyleBackColor = false;
            this.button_maj.Click += new System.EventHandler(this.button_maj_Click);
            // 
            // button_enregistrer
            // 
            this.button_enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            this.button_enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_enregistrer.ForeColor = System.Drawing.Color.White;
            this.button_enregistrer.Location = new System.Drawing.Point(148, 0);
            this.button_enregistrer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_enregistrer.Name = "button_enregistrer";
            this.button_enregistrer.Size = new System.Drawing.Size(169, 71);
            this.button_enregistrer.TabIndex = 2;
            this.button_enregistrer.Text = "Enregistrer";
            this.button_enregistrer.UseVisualStyleBackColor = false;
            this.button_enregistrer.Click += new System.EventHandler(this.button_enregistrer_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(284, 594);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(218, 22);
            this.textBox_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(120)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(145, 594);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numéro d\'ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(120)))), ((int)(((byte)(33)))));
            this.label2.Location = new System.Drawing.Point(179, 633);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prénom :";
            // 
            // textBox_prenom
            // 
            this.textBox_prenom.Location = new System.Drawing.Point(284, 633);
            this.textBox_prenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_prenom.Name = "textBox_prenom";
            this.textBox_prenom.Size = new System.Drawing.Size(219, 22);
            this.textBox_prenom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(120)))), ((int)(((byte)(33)))));
            this.label3.Location = new System.Drawing.Point(129, 674);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nom de famille :";
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(284, 674);
            this.textBox_nom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(219, 22);
            this.textBox_nom.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(120)))), ((int)(((byte)(33)))));
            this.label4.Location = new System.Drawing.Point(567, 597);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Téléphone :";
            // 
            // textBox_tel
            // 
            this.textBox_tel.Location = new System.Drawing.Point(673, 592);
            this.textBox_tel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(219, 22);
            this.textBox_tel.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(120)))), ((int)(((byte)(33)))));
            this.label5.Location = new System.Drawing.Point(605, 634);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ville :";
            // 
            // textBox_ville
            // 
            this.textBox_ville.Location = new System.Drawing.Point(673, 630);
            this.textBox_ville.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_ville.Name = "textBox_ville";
            this.textBox_ville.Size = new System.Drawing.Size(219, 22);
            this.textBox_ville.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_exit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 74);
            this.panel1.TabIndex = 11;
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
            this.label_exit.TabIndex = 2;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            this.label6.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(328, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Gestion des Clients du Palace";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_guest);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 496);
            this.panel2.TabIndex = 12;
            // 
            // dataGridView_guest
            // 
            this.dataGridView_guest.AllowUserToAddRows = false;
            this.dataGridView_guest.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_guest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_guest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_guest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.dataGridView_guest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_guest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_guest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_guest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_guest.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_guest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_guest.EnableHeadersVisualStyles = false;
            this.dataGridView_guest.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.dataGridView_guest.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_guest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_guest.Name = "dataGridView_guest";
            this.dataGridView_guest.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_guest.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_guest.RowHeadersVisible = false;
            this.dataGridView_guest.RowTemplate.Height = 24;
            this.dataGridView_guest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_guest.Size = new System.Drawing.Size(1005, 496);
            this.dataGridView_guest.TabIndex = 0;
            this.dataGridView_guest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_guest_CellClick);
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1005, 800);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_ville);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_tel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_prenom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.panel_button);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GuestForm";
            this.Text = "GuestForm";
            this.Load += new System.EventHandler(this.GuestForm_Load);
            this.panel_button.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_guest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_prenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ville;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_maj;
        private System.Windows.Forms.Button button_enregistrer;
        private System.Windows.Forms.DataGridView dataGridView_guest;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Button button_effacer;
    }
}