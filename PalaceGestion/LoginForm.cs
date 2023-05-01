using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Serilog;

namespace PalaceGestion
{
    /// <summary>
    /// Formulaire d'authentification de l'utilisateur.
    /// </summary>
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Instance de la classe DBConnect pour interagir avec la base de données.
        /// </summary>
        DBConnect connect = new DBConnect();

        /// <summary>
        /// Constructeur de la classe LoginForm.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gestionnaire d'événements pour le clic sur le label_exit.
        /// </summary>
        private void label_exit_Click(object sender, EventArgs e)
        {
            // Fermeture de l'application
            Application.Exit();
        }

        /// <summary>
        /// Gestionnaire d'événements pour le survol du label_exit.
        /// </summary>
        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        /// <summary>
        /// Gestionnaire d'événements pour le clic sur le bouton de connexion.
        /// </summary>        
        private void Button_login_Click(object sender, EventArgs e)
        {
            // Vérification si le nom d'utilisateur et le mot de passe ont été saisis
            if (TextBox_username.Text.Trim().Equals("") || TextBox_password.Text == "")
            {
                // Affichage d'un message d'erreur si les champs sont vides
                MessageBox.Show("Entrez votre nom d'utilisateur et votre mot de passe", "Information Manquante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Création d'une nouvelle table de données
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                // Définition de la requête SQL pour sélectionner l'utilisateur avec le nom d'utilisateur et le mot de passe donnés
                string selectquery = "SELECT * FROM `users` WHERE `username` = @usn AND `password`=@pass";
                MySqlCommand command = new MySqlCommand(selectquery, connect.GetConnection());

                // Ajout des paramètres à la requête SQL
                command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = TextBox_username.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = TextBox_password.Text;

                // Execution de la requête SQL
                adapter.SelectCommand = command;
                adapter.Fill(table);

                // Vérification si le nom d'utilisateur et le mot de passe existent dans la base de données
                if (table.Rows.Count > 0)
                {
                    // Si oui, affichage                  
                    // du formulaire principal et fermeture du formulaire de connexion
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                {
                    // Si non, affichage d'un message d'erreur
                    MessageBox.Show("Votre nom d'utilisateur et votre mot de passe n'existent pas", "Information Erronée", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.Debug("usn pass ne correspondent pas BD " + TextBox_username.Text + " " + TextBox_password);
                }
            }
        }

     
    }
}
