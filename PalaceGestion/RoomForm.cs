using System;
using System.Drawing;
using System.Windows.Forms;

namespace PalaceGestion
{
    /// <summary>
    /// Form pour la gestion des chambres.
    /// </summary>
    public partial class RoomForm : Form
    {
        // Créer une instance de la classe RoomClass
        RoomClass room = new RoomClass();

        public RoomForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handler pour l'événement Load du formulaire.
        /// </summary>
        private void RoomForm_Load(object sender, EventArgs e)
        {
            // Afficher les types de chambre dans la combobox
            comboBox_chambreType.DataSource = room.getRoomType();
            comboBox_chambreType.DisplayMember = "Label";
            comboBox_chambreType.ValueMember = "CategoryId";

            // Afficher la liste des chambres dans le datagridview
            getRoomList();
            dataGridView_chambres.DefaultCellStyle.ForeColor = Color.Black;
        }

        /// <summary>
        /// Récupère la liste des chambres et l'affiche dans le datagridview.
        /// </summary>
        private void getRoomList()
        {
            dataGridView_chambres.DataSource = room.getRoomList();
        }

        /// <summary>
        /// Handler pour l'événement Click du bouton d'enregistrement.
        /// </summary>
        private void button_enregistrer_Click(object sender, EventArgs e)
        {
            string no = textBox_id.Text;
            int type = Convert.ToInt32(comboBox_chambreType.SelectedValue.ToString());
            string ph = textBox_tel.Text;
            string status = radioButton_libre.Checked ? "Libre" : "Occupée";

            try
            {
                if (room.addRoom(no, type, ph, status))
                {
                    MessageBox.Show("Chambre ajoutée avec succès", "Ajouter une Chambre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getRoomList();
                    button_effacer.PerformClick();
                }
                else
                {
                    MessageBox.Show("La chambre n'a pas été ajoutée", "Ajouter une Chambre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handler pour l'événement Click du bouton de nettoyage.
        /// Réinitialise les contrôles du formulaire.
        /// </summary>
        private void button_effacer_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            comboBox_chambreType.SelectedIndex = 0;
            textBox_tel.Clear();
        }

        /// <summary>
        /// Handler pour l'événement Click du bouton de mise à jour.
        /// </summary>
        private void button_maj_Click(object sender, EventArgs e)
        {
            string no = textBox_id.Text;
            int type = Convert.ToInt32(comboBox_chambreType.SelectedValue.ToString());
            string ph = textBox_tel.Text;
            string status = radioButton_libre.Checked ? "Libre" : "Occupée";

            try
            {
                if (room.editRoom(no, type, ph, status))
                {
                    MessageBox.Show("Chambre mise à jour avec succès", "Mise à jour de la Chambre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getRoomList();
                    button_effacer.PerformClick();
                }
                else
                {
                    MessageBox.Show("La chambre n'a pas été mise à jour", "Mise à jour de la Chambre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Supprimer une chambre en utilisant l'ID de la chambre.
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les arguments de l'événement.</param>
        private void button_supprimer_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "")
            {
                MessageBox.Show("Champ obligatoire - Numéro de la Chambre", "Champ Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string id = textBox_id.Text;
                    Boolean deleteGuest = room.removeRoom(id);
                    if (deleteGuest)
                    {
                        MessageBox.Show("Chambre supprimée avec succès", "Chambre Supprimée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getRoomList();
                        // vous pouvez effacer tous les textes après l'action de suppression
                        button_effacer.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("ERREUR - La chambre n'a pas été supprimée", "Erreur de Suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        /// <summary>
        /// Affichage des informations de la chambre sélectionnée dans le DataGridView dans les TextBox.
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les arguments de l'événement.</param>       
        private void dataGridView_chambres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = dataGridView_chambres.CurrentRow.Cells[0].Value.ToString();
            comboBox_chambreType.SelectedValue = dataGridView_chambres.CurrentRow.Cells[1].Value.ToString();
            textBox_tel.Text = dataGridView_chambres.CurrentRow.Cells[2].Value.ToString();
            // Pour le bouton radio
            string rButton = dataGridView_chambres.CurrentRow.Cells[3].Value.ToString();
            if (rButton.Equals("Libre"))
            {
                radioButton_libre.Checked = true;
            }
            else
            {
                radioButton_occupee.Checked = true;
            }
        }

        /// <summary>
        /// Quitter l'applcation lors du click sur le label "Exit".
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les arguments de l'événement.</param>        
        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 
        
        /// <summary>
        /// Changer la couleur du label "Exit" en rouge lorsque la souris entre dans la zone du label.
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les arguments de l'événement.</param>
        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }
    }
}

