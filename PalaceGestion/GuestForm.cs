using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalaceGestion
{
    /// <summary>
    /// Classe définissant le formulaire pour la gestion des clients.
    /// </summary>
    public partial class GuestForm : Form
    {
        // Création d'une instance de la classe GuestClass
        readonly GuestClass guest = new GuestClass();

        /// <summary>
        /// Constructeur de la classe GuestForm.
        /// </summary>
        public GuestForm()
        {
            // Initialisation des composants du formulaire
            InitializeComponent();
        }

        /// <summary>
        /// Méthode appelée lorsque le formulaire est chargé.
        /// </summary>
        private void GuestForm_Load(object sender, EventArgs e)
        {
            // Changement de la couleur du texte dans le DataGridView lors du chargement du formulaire
            dataGridView_guest.DefaultCellStyle.ForeColor = Color.Black;
            // Appel de la méthode pour obtenir les données à afficher dans le DataGridView
            getTable();
        }

        /// <summary>
        /// Méthode pour récupérer les données des clients à afficher dans le DataGridView.
        /// </summary>
        private void getTable()
        {
            // Récupération des données des clients pour les afficher dans le DataGridView
            dataGridView_guest.DataSource = guest.getClient();
        }

        /// <summary>
        /// Méthode appelée lorsque le bouton 'Effacer' est cliqué.
        /// </summary>
        private void button_effacer_Click(object sender, EventArgs e)
        {
            // Effacement du contenu des TextBox
            textBox_id.Clear();
            textBox_prenom.Clear();
            textBox_nom.Clear();
            textBox_tel.Clear();
            textBox_ville.Clear();
        }

        /// <summary>
        /// Méthode pour enregistrer un nouveau client.
        /// </summary>
        //rajoute pour test unitaire isole
        public bool EnregistrerNouveauClient(string id, string prenom, string nom, string phone, string city)
        {
            // Tentative d'insertion du nouveau client
            bool insertGuest = guest.insertClient(id, prenom, nom, phone, city);

            return insertGuest;
        }

        /// <summary>
        /// Méthode appelée lorsque le bouton 'Enregistrer' est cliqué.
        /// </summary>        
        private void button_enregistrer_Click(object sender, EventArgs e)
        {
            // Vérification que les champs obligatoires sont remplis
            if (textBox_id.Text == "" || textBox_prenom.Text == "" || textBox_tel.Text == "")
            {
                MessageBox.Show("Champ obligatoire - Id, prénom et numéro de téléphone : ", "Champ obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    // Récupération des données des TextBox
                    string id = textBox_id.Text;
                    string prenom = textBox_prenom.Text;
                    string nom = textBox_nom.Text;
                    string phone = textBox_tel.Text;
                    string city = textBox_ville.Text;

                    // Tentative d'insertion du nouveau client
                    bool insertGuest = EnregistrerNouveauClient(id, prenom, nom, phone, city);
                    if (insertGuest)
                    {
                        // Si l'insertion est réussie, affichage d'un message de confirmation et mise à jour de la table
                        MessageBox.Show("Nouveau client enregistré avec succès", "Client Enregistré", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getTable();
                        // Effacement du contenu des TextBox après l'enregistrement 
                        button_effacer.PerformClick();
                    }
                    else
                    {
                        // Si l'insertion échoue, affichage d'un message d'erreur
                        MessageBox.Show("ERREUR - Le client n'a pas été enregistré avec succès", "Erreur d'Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    // En cas d'exception, affichage du message d'erreur correspondant
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Méthode appelée lorsque le bouton 'Supprimer' est cliqué.
        /// </summary>
        private void button_supprimer_Click(object sender, EventArgs e)
        {
            // Vérification que le champ Id est rempli
            if (textBox_id.Text == "")
            {
                MessageBox.Show("Champ obligatoire - Id", "Champ Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    // Récupération de l'Id du client à supprimer
                    string id = textBox_id.Text;
                    // Tentative de suppression du client
                    Boolean deleteGuest = guest.removeGuest(id);
                    if (deleteGuest)
                    {
                        // Si la suppression est réussie, affichage d'un message de confirmation et mise à jour de la table
                        MessageBox.Show("Client supprimé avec succès", "Client Supprimé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getTable();
                        // Effacement du contenu des TextBox après la suppression 
                        button_effacer.PerformClick();
                    }
                    else
                    {
                        // Si la suppression échoue, affichage d'un message d'erreur
                        MessageBox.Show("ERREUR - Le client n'a pas été supprimé", "Erreur de Suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // En cas d'exception, affichage du message d'erreur correspondant
                    MessageBox.Show(ex.Message);
                }

            }
        }


        /// <summary>
        /// Méthode appelée lorsque le bouton 'Mettre à jour' est cliqué.
        /// </summary>
        private void button_maj_Click(object sender, EventArgs e)
        {
            // Vérification que les champs obligatoires sont remplis
            if (textBox_id.Text == "" || textBox_prenom.Text == "" || textBox_tel.Text == "")
            {
                MessageBox.Show("Champ obligatoire - Id, prénom et numéro de téléphone:", "Champ Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    // Récupération des données des TextBox
                    string id = textBox_id.Text;
                    string prenom = textBox_prenom.Text;
                    string nom = textBox_nom.Text;
                    string phone = textBox_tel.Text;
                    string city = textBox_ville.Text;

                    // Tentative de mise à jour des données du client
                    Boolean editGuest = guest.editGuest(id, prenom, nom, phone, city);
                    if (editGuest)
                    {
                        // Si la mise à jour est réussie, affichage d'un message de confirmation et mise à jour de la table
                        MessageBox.Show("Les données du client ont été mises à jour avec succès", "Mise à jour réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getTable();
                        // Effacement du contenu des TextBox après la mise à jour
                        button_effacer.PerformClick();
                    }
                    else
                    {
                        // Si la mise à jour échoue, affichage d'un message d'erreur
                        MessageBox.Show("ERREUR - Les données du client n'ont pas été mises à jour", "Erreur de Mise à Jour", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // En cas d'exception, affichage du message d'erreur correspondant
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Méthode appelée lorsque l'utilisateur clique sur une cellule du DataGridView.
        /// </summary>
        private void dataGridView_guest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Affichage des données du client sélectionné dans les TextBox correspondantes
            textBox_id.Text = dataGridView_guest.CurrentRow.Cells[0].Value.ToString();
            textBox_prenom.Text = dataGridView_guest.CurrentRow.Cells[1].Value.ToString();
            textBox_nom.Text = dataGridView_guest.CurrentRow.Cells[2].Value.ToString();
            textBox_tel.Text = dataGridView_guest.CurrentRow.Cells[3].Value.ToString();
            textBox_ville.Text = dataGridView_guest.CurrentRow.Cells[4].Value.ToString();
        }

        /// <summary>
        /// Méthode appelée lorsque l'utilisateur clique sur 'Exit'.
        /// </summary>
        private void label_exit_Click(object sender, EventArgs e)
        {
            // Fermeture de l'application
            Application.Exit();
        }

        /// <summary>
        /// Méthode appelée lorsque la souris entre dans le label 'Exit'.
        /// </summary>
        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            // Changement de la couleur du texte du label 'Exit' en rouge
            label_exit.ForeColor = Color.Red;
        }
    }
}

