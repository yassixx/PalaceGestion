
namespace PalaceGestion
{
    partial class RoomForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_exit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_chambres = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.button_effacer = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_maj = new System.Windows.Forms.Button();
            this.button_enregistrer = new System.Windows.Forms.Button();
            this.panel_button = new System.Windows.Forms.Panel();
            this.comboBox_chambreType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_occupee = new System.Windows.Forms.RadioButton();
            this.radioButton_libre = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_chambres)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_button.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            this.label_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label_exit.ForeColor = System.Drawing.Color.White;
            this.label_exit.Location = new System.Drawing.Point(707, 9);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(20, 20);
            this.label_exit.TabIndex = 2;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_chambres);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 397);
            this.panel2.TabIndex = 25;
            // 
            // dataGridView_chambres
            // 
            this.dataGridView_chambres.AllowUserToAddRows = false;
            this.dataGridView_chambres.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            this.dataGridView_chambres.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_chambres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_chambres.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.dataGridView_chambres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_chambres.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_chambres.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_chambres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_chambres.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_chambres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_chambres.EnableHeadersVisualStyles = false;
            this.dataGridView_chambres.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.dataGridView_chambres.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_chambres.Name = "dataGridView_chambres";
            this.dataGridView_chambres.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_chambres.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_chambres.RowHeadersVisible = false;
            this.dataGridView_chambres.RowTemplate.Height = 24;
            this.dataGridView_chambres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_chambres.Size = new System.Drawing.Size(739, 397);
            this.dataGridView_chambres.TabIndex = 0;
            this.dataGridView_chambres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_chambres_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            this.label6.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(264, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Gestion des Chambres";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_exit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 47);
            this.panel1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(435, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Statut :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Numéro de Téléphone :";
            // 
            // textBox_tel
            // 
            this.textBox_tel.Location = new System.Drawing.Point(214, 527);
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(151, 20);
            this.textBox_tel.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Type de Chambre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Numéro de Chambre :";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(214, 458);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(151, 20);
            this.textBox_id.TabIndex = 14;
            // 
            // button_effacer
            // 
            this.button_effacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            this.button_effacer.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_effacer.ForeColor = System.Drawing.Color.White;
            this.button_effacer.Location = new System.Drawing.Point(551, 0);
            this.button_effacer.Name = "button_effacer";
            this.button_effacer.Size = new System.Drawing.Size(127, 46);
            this.button_effacer.TabIndex = 5;
            this.button_effacer.Text = "Effacer";
            this.button_effacer.UseVisualStyleBackColor = false;
            this.button_effacer.Click += new System.EventHandler(this.button_effacer_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            this.button_supprimer.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_supprimer.ForeColor = System.Drawing.Color.White;
            this.button_supprimer.Location = new System.Drawing.Point(407, 0);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(127, 46);
            this.button_supprimer.TabIndex = 4;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = false;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_maj
            // 
            this.button_maj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            this.button_maj.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_maj.ForeColor = System.Drawing.Color.White;
            this.button_maj.Location = new System.Drawing.Point(254, 0);
            this.button_maj.Name = "button_maj";
            this.button_maj.Size = new System.Drawing.Size(127, 46);
            this.button_maj.TabIndex = 3;
            this.button_maj.Text = "Mettre à jour";
            this.button_maj.UseVisualStyleBackColor = false;
            this.button_maj.Click += new System.EventHandler(this.button_maj_Click);
            // 
            // button_enregistrer
            // 
            this.button_enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            this.button_enregistrer.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_enregistrer.ForeColor = System.Drawing.Color.White;
            this.button_enregistrer.Location = new System.Drawing.Point(106, 0);
            this.button_enregistrer.Name = "button_enregistrer";
            this.button_enregistrer.Size = new System.Drawing.Size(127, 46);
            this.button_enregistrer.TabIndex = 2;
            this.button_enregistrer.Text = "Ajouter";
            this.button_enregistrer.UseVisualStyleBackColor = false;
            this.button_enregistrer.Click += new System.EventHandler(this.button_enregistrer_Click);
            // 
            // panel_button
            // 
            this.panel_button.Controls.Add(this.button_effacer);
            this.panel_button.Controls.Add(this.button_supprimer);
            this.panel_button.Controls.Add(this.button_maj);
            this.panel_button.Controls.Add(this.button_enregistrer);
            this.panel_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_button.Location = new System.Drawing.Point(0, 564);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(739, 46);
            this.panel_button.TabIndex = 13;
            // 
            // comboBox_chambreType
            // 
            this.comboBox_chambreType.FormattingEnabled = true;
            this.comboBox_chambreType.Location = new System.Drawing.Point(214, 493);
            this.comboBox_chambreType.Name = "comboBox_chambreType";
            this.comboBox_chambreType.Size = new System.Drawing.Size(151, 21);
            this.comboBox_chambreType.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_occupee);
            this.groupBox1.Controls.Add(this.radioButton_libre);
            this.groupBox1.Location = new System.Drawing.Point(489, 454);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 62);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // radioButton_occupee
            // 
            this.radioButton_occupee.AutoSize = true;
            this.radioButton_occupee.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_occupee.Location = new System.Drawing.Point(6, 36);
            this.radioButton_occupee.Name = "radioButton_occupee";
            this.radioButton_occupee.Size = new System.Drawing.Size(72, 17);
            this.radioButton_occupee.TabIndex = 1;
            this.radioButton_occupee.TabStop = true;
            this.radioButton_occupee.Text = "Occupée";
            this.radioButton_occupee.UseVisualStyleBackColor = true;
            // 
            // radioButton_libre
            // 
            this.radioButton_libre.AutoSize = true;
            this.radioButton_libre.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_libre.Location = new System.Drawing.Point(6, 12);
            this.radioButton_libre.Name = "radioButton_libre";
            this.radioButton_libre.Size = new System.Drawing.Size(55, 17);
            this.radioButton_libre.TabIndex = 0;
            this.radioButton_libre.TabStop = true;
            this.radioButton_libre.Text = "Libre";
            this.radioButton_libre.UseVisualStyleBackColor = true;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(739, 610);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox_chambreType);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_tel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.panel_button);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_chambres)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_button.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_chambres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Button button_effacer;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_maj;
        private System.Windows.Forms.Button button_enregistrer;
        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.ComboBox comboBox_chambreType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_occupee;
        private System.Windows.Forms.RadioButton radioButton_libre;
    }
}