using System;
using System.Drawing;
using System.Windows.Forms;

namespace PalaceGestion
{
    /// <summary>
    /// Classe principale de l'application.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Constructeur de la classe MainForm.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gestionnaire d'événement pour le clic sur le bouton 'tableauDeBord'.
        /// </summary>
        private void button_tableauDeBord_Click(object sender, EventArgs e)
        {
            // Effacement et ajout de contrôles sur le panel_main
            panel_main.Controls.Clear();
            panel_main.Controls.Add(panel_cover);
        }


        /// <summary>
        /// Gestionnaire d'événement pour le clic sur le bouton 'clients'.
        /// </summary>
        private void button_clients_Click(object sender, EventArgs e)
        {
            // Effacement des contrôles sur le panel_main et ajout du formulaire 'GuestForm'
            panel_main.Controls.Clear();
            GuestForm guest = new GuestForm();
            guest.TopLevel = false;
            guest.Dock = DockStyle.Fill;
            guest.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(guest);
            guest.Show();
        }

        /// <summary>
        /// Gestionnaire d'événement pour le clic sur le bouton 'reception'.
        /// </summary>
        private void button_reception_Click(object sender, EventArgs e)
        {
            // Effacement des contrôles sur le panel_main et ajout du formulaire 'ReservationForm'
            panel_main.Controls.Clear();
            ReservationForm reservation = new ReservationForm();
            reservation.TopLevel = false;
            reservation.Dock = DockStyle.Fill;
            reservation.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(reservation);
            reservation.Show();
        }

        /// <summary>
        /// Gestionnaire d'événement pour le clic sur le bouton 'chambres'.
        /// </summary>
        private void button_chambres_Click(object sender, EventArgs e)
        {
           
            // Effacement des contrôles sur le panel_main et ajout du formulaire 'RoomForm'
            panel_main.Controls.Clear();
            RoomForm room = new RoomForm();
            room.TopLevel = false;
            room.Dock = DockStyle.Fill;
            room.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(room);
            room.Show();
        }

        /// <summary>
        /// Gestionnaire d'événement pour le clic sur le label 'exit'.
        /// </summary>
        private void label_exit_Click(object sender, EventArgs e)
        {
            // Termine l'application
            Application.Exit();
        }

        /// <summary>
        /// Gestionnaire d'événement pour le survol de la souris sur le label 'exit'.
        /// </summary>
        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            // Change la couleur du texte en rouge
            label_exit.ForeColor = Color.Red;
        }

        /// <summary>
        /// Gestionnaire d'événement lorsque la souris quitte le label 'exit'.
        /// </summary>
        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            // Rétablit la couleur du texte en blanc
            label_exit.ForeColor = Color.White;
        }

        /// <summary>
        /// Gestionnaire d'événement pour le clic sur le bouton 'logout'.
        /// </summary>
        private void button_logout_Click(object sender, EventArgs e)
        {
            // Crée une nouvelle instance de 'LoginForm', cache la fenêtre actuelle et affiche le formulaire de connexion
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }
    }
}
