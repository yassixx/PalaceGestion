
namespace PalaceGestion
{
    partial class ReservationForm
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
            this.dataGridView_reserv = new System.Windows.Forms.DataGridView();
            this.label_exit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_reservId = new System.Windows.Forms.TextBox();
            this.button_effacer = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_maj = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.panel_button = new System.Windows.Forms.Panel();
            this.comboBox_chambreType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_ChambreNo = new System.Windows.Forms.ComboBox();
            this.textBox_clientId = new System.Windows.Forms.TextBox();
            this.dateTimePicker_dateArrivee = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_dateDepart = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_reserv)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_button.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_reserv
            // 
            this.dataGridView_reserv.AllowUserToAddRows = false;
            this.dataGridView_reserv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_reserv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_reserv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_reserv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.dataGridView_reserv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_reserv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_reserv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_reserv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_reserv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_reserv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_reserv.EnableHeadersVisualStyles = false;
            this.dataGridView_reserv.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_reserv.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_reserv.Name = "dataGridView_reserv";
            this.dataGridView_reserv.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_reserv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_reserv.RowHeadersVisible = false;
            this.dataGridView_reserv.RowTemplate.Height = 24;
            this.dataGridView_reserv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_reserv.Size = new System.Drawing.Size(738, 361);
            this.dataGridView_reserv.TabIndex = 0;
            this.dataGridView_reserv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_reserv_CellClick);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            this.label_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label_exit.ForeColor = System.Drawing.Color.White;
            this.label_exit.Location = new System.Drawing.Point(706, 8);
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
            this.label6.Location = new System.Drawing.Point(269, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Gestion des Réservations";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_reserv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 361);
            this.panel2.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_exit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 47);
            this.panel1.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(375, 484);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Date de Départ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(375, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Date d\'Arrivée : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Type de Chambre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Id du Client :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Id de Réservation :";
            // 
            // textBox_reservId
            // 
            this.textBox_reservId.Location = new System.Drawing.Point(197, 419);
            this.textBox_reservId.Name = "textBox_reservId";
            this.textBox_reservId.Size = new System.Drawing.Size(145, 20);
            this.textBox_reservId.TabIndex = 14;
            // 
            // button_effacer
            // 
            this.button_effacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            this.button_effacer.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_effacer.ForeColor = System.Drawing.Color.White;
            this.button_effacer.Location = new System.Drawing.Point(514, 4);
            this.button_effacer.Name = "button_effacer";
            this.button_effacer.Size = new System.Drawing.Size(100, 47);
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
            this.button_supprimer.Location = new System.Drawing.Point(390, 4);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(101, 49);
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
            this.button_maj.Location = new System.Drawing.Point(273, 4);
            this.button_maj.Name = "button_maj";
            this.button_maj.Size = new System.Drawing.Size(101, 48);
            this.button_maj.TabIndex = 3;
            this.button_maj.Text = "Mettre à jour";
            this.button_maj.UseVisualStyleBackColor = false;
            this.button_maj.Click += new System.EventHandler(this.button_maj_Click);
            // 
            // button_ajouter
            // 
            this.button_ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            this.button_ajouter.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ajouter.ForeColor = System.Drawing.Color.White;
            this.button_ajouter.Location = new System.Drawing.Point(147, 4);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(104, 47);
            this.button_ajouter.TabIndex = 2;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = false;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // panel_button
            // 
            this.panel_button.Controls.Add(this.button_effacer);
            this.panel_button.Controls.Add(this.button_supprimer);
            this.panel_button.Controls.Add(this.button_maj);
            this.panel_button.Controls.Add(this.button_ajouter);
            this.panel_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_button.Location = new System.Drawing.Point(0, 558);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(738, 53);
            this.panel_button.TabIndex = 13;
            // 
            // comboBox_chambreType
            // 
            this.comboBox_chambreType.FormattingEnabled = true;
            this.comboBox_chambreType.Location = new System.Drawing.Point(197, 491);
            this.comboBox_chambreType.Name = "comboBox_chambreType";
            this.comboBox_chambreType.Size = new System.Drawing.Size(145, 21);
            this.comboBox_chambreType.TabIndex = 27;
            this.comboBox_chambreType.SelectedIndexChanged += new System.EventHandler(this.comboBox_chambreType_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 527);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Numéro de Chambre :";
            // 
            // comboBox_ChambreNo
            // 
            this.comboBox_ChambreNo.FormattingEnabled = true;
            this.comboBox_ChambreNo.Location = new System.Drawing.Point(197, 526);
            this.comboBox_ChambreNo.Name = "comboBox_ChambreNo";
            this.comboBox_ChambreNo.Size = new System.Drawing.Size(145, 21);
            this.comboBox_ChambreNo.TabIndex = 29;
            // 
            // textBox_clientId
            // 
            this.textBox_clientId.Location = new System.Drawing.Point(197, 454);
            this.textBox_clientId.Name = "textBox_clientId";
            this.textBox_clientId.Size = new System.Drawing.Size(145, 20);
            this.textBox_clientId.TabIndex = 30;
            // 
            // dateTimePicker_dateArrivee
            // 
            this.dateTimePicker_dateArrivee.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_dateArrivee.Location = new System.Drawing.Point(493, 437);
            this.dateTimePicker_dateArrivee.Name = "dateTimePicker_dateArrivee";
            this.dateTimePicker_dateArrivee.Size = new System.Drawing.Size(145, 20);
            this.dateTimePicker_dateArrivee.TabIndex = 31;
            // 
            // dateTimePicker_dateDepart
            // 
            this.dateTimePicker_dateDepart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_dateDepart.Location = new System.Drawing.Point(494, 483);
            this.dateTimePicker_dateDepart.Name = "dateTimePicker_dateDepart";
            this.dateTimePicker_dateDepart.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker_dateDepart.TabIndex = 32;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(738, 611);
            this.Controls.Add(this.dateTimePicker_dateDepart);
            this.Controls.Add(this.dateTimePicker_dateArrivee);
            this.Controls.Add(this.textBox_clientId);
            this.Controls.Add(this.comboBox_ChambreNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_chambreType);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_reservId);
            this.Controls.Add(this.panel_button);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(52)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_reserv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_button.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_reserv;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_reservId;
        private System.Windows.Forms.Button button_effacer;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_maj;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.ComboBox comboBox_chambreType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_ChambreNo;
        private System.Windows.Forms.TextBox textBox_clientId;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateArrivee;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateDepart;
    }
}