using System;
using System.Drawing;
using System.Windows.Forms;

namespace PalaceGestion
{
    /// <summary>
    /// Formulaire de gestion des réservations d'hôtel.
    /// Permet d'ajouter, supprimer, mettre à jour et afficher les réservations existantes.
    /// </summary>
    public partial class ReservationForm : Form
    {

        RoomClass room = new RoomClass(); 
        ReservationClass reservation = new ReservationClass();
        /// <summary>
        /// Constructeur par défaut de la classe ReservationForm.
        /// Initialise les composants et affiche la liste des réservations.
        /// </summary>
        public ReservationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Chargement initial du formulaire.
        /// </summary>
        private void ReservationForm_Load(object sender, EventArgs e)
        {
            // Pour afficher le type de chambre dans la combobox
            comboBox_chambreType.DataSource = room.getRoomType();
            comboBox_chambreType.DisplayMember = "Label";
            comboBox_chambreType.ValueMember = "CategoryId";

            // Pour afficher le numéro de la chambre en fonction du type de chambre
            // et afficher que la chambre est disponible
            int type = Convert.ToInt32(comboBox_chambreType.SelectedValue.ToString());
            comboBox_ChambreNo.DataSource = reservation.roomByType(type);
            comboBox_ChambreNo.DisplayMember = "RoomId";
            comboBox_ChambreNo.ValueMember = "RoomId";

            // Pour afficher la liste des réservations dans le DataGridView
            getReservTable();
            dataGridView_reserv.DefaultCellStyle.ForeColor = Color.Black;
        }

        /// <summary>
        /// Fonction pour afficher la liste des réservations dans le DataGridView.
        /// </summary>
        public void getReservTable()
        {
            dataGridView_reserv.DataSource = reservation.getReserv();
        }

        /// <summary>
        /// Événement appelé lorsque la valeur sélectionnée dans la combobox "Type de chambre" est modifiée.
        /// </summary>
        private void comboBox_chambreType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Pour afficher le numéro de la chambre en fonction du type de chambre
            // et afficher que la chambre est disponible
            try
            {
                int type = Convert.ToInt32(comboBox_chambreType.SelectedValue.ToString());
                comboBox_ChambreNo.DataSource = reservation.roomByType(type);
                comboBox_ChambreNo.DisplayMember = "RoomId";
                comboBox_ChambreNo.ValueMember = "RoomId";
            }
            catch (Exception)
            {
                // Ne rien faire
            }
        }

        /// <summary>
        /// Événement appelé lorsqu'on clique sur le bouton "Ajouter".
        /// Ajoute une nouvelle réservation avec les informations saisies par l'utilisateur.
        /// </summary>
        private void button_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                string guestId = textBox_clientId.Text;
                string roomNo = comboBox_ChambreNo.SelectedValue.ToString();
                DateTime dIn = dateTimePicker_dateArrivee.Value;
                DateTime dOut = dateTimePicker_dateDepart.Value;

                // La date d'arrivée doit être égale ou supérieure à la date d'aujourd'hui et
                // la date de départ doit être égale ou supérieure à la date d'arrivée
                if (dIn < DateTime.Today)
                {
                    MessageBox.Show("La date d'arrivée de la réservation doit être aujourd'hui ou après", "Date invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dOut < dIn)
                {
                    MessageBox.Show("La date de départ de la réservation doit être la même que la date d'arrivée ou après", "Date invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (reservation.addReserv(guestId, roomNo, dIn, dOut) && reservation.setReservRoom(roomNo, "Occupé"))
                    {
                        getReservTable();
                        MessageBox.Show("Nouvelle réservation ajoutée avec succès", "Ajout de réservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("La réservation n'a pas été ajoutée avec succès", "Erreur de réservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors de l'ajout de la réservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gère le clic sur le bouton "Supprimer" pour supprimer une réservation.
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les données d'événement.</param>
        private void button_supprimer_Click(object sender, EventArgs e)
        {
            int reserId = Convert.ToInt32(textBox_reservId.Text);
            string rno = comboBox_ChambreNo.Text;

            try
            {
                if (reservation.removeReserv(reserId) && reservation.setReservRoom(rno, "Libre"))
                {
                    getReservTable();
                    MessageBox.Show("La réservation a été supprimée avec succès", "Suppression de la réservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors de la suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gère le clic sur le bouton "Effacer" pour effacer les champs de saisie de la réservation.
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les données d'événement.</param>
        private void button_effacer_Click(object sender, EventArgs e)
        {
            textBox_reservId.Clear();
            textBox_clientId.Clear();
            comboBox_chambreType.SelectedValue = 1;
            dateTimePicker_dateArrivee.Value = DateTime.Now;
            dateTimePicker_dateDepart.Value = DateTime.Now;
        }

        /// <summary>
        /// Gère le clic sur le bouton "Mise à jour" pour mettre à jour une réservation.
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les données d'événement.</param>
        private void button_maj_Click(object sender, EventArgs e)
        {
            try
            {
                int reservId = Convert.ToInt32(textBox_reservId.Text);
                string guestId = textBox_clientId.Text;
                string roomNo = comboBox_ChambreNo.SelectedValue.ToString();
                DateTime dIn = dateTimePicker_dateArrivee.Value;
                DateTime dOut = dateTimePicker_dateDepart.Value;

                // La date d'arrivée doit être égale ou supérieure à la date d'aujourd'hui et
                // la date de départ doit être égale ou supérieure à la date d'arrivée, n'est-ce pas ?
                if (dIn < DateTime.Today)
                {
                    MessageBox.Show("La date d'arrivée de la réservation doit être aujourd'hui ou après", "Date invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dOut < dIn)
                {
                    MessageBox.Show("La date de départ de la réservation doit être la même que la date d'arrivée ou après", "Date invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (reservation.editReserv(reservId, guestId, roomNo, dIn, dOut) && reservation.setReservRoom(roomNo, "Occupée"))
                    {
                        getReservTable();
                        MessageBox.Show("La réservation a été modifiée avec succès", "Mise à jour de la réservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("La réservation n'a pas été modifiée avec succès", "Erreur de mise à jour", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors de la mise à jour de la réservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gère le clic sur une cellule de la grille de données des réservations pour afficher les détails de la réservation dans les champs correspondants.
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les données d'événement.</param>
        private void dataGridView_reserv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_reservId.Text = dataGridView_reserv.CurrentRow.Cells[0].Value.ToString();
            textBox_clientId.Text = dataGridView_reserv.CurrentRow.Cells[1].Value.ToString();

            string rno = dataGridView_reserv.CurrentRow.Cells[2].Value.ToString();
            comboBox_chambreType.SelectedValue = reservation.typeByRoomNo(rno);
            comboBox_ChambreNo.Text = rno;

            dateTimePicker_dateArrivee.Text = dataGridView_reserv.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker_dateDepart.Text = dataGridView_reserv.CurrentRow.Cells[4].Value.ToString();
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
