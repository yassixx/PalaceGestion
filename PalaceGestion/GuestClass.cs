using MySql.Data.MySqlClient;
using System.Data;
using Serilog;

namespace PalaceGestion
{
    /// <summary>
    /// Dans cette classe :
    /// Ajouter un nouveau client
    /// Mettre à jour un client
    /// Supprimer un client
    /// Obtenir toutes les fonctions pour GuestForm
    /// </summary>
    class GuestClass
    {
        readonly DBConnect connect = new DBConnect();

        // Crée une fonction pour insérer un nouveau client
        public bool insertClient(string id, string prenom, string nom, string phone, string city)
        {
            /// <summary>
            /// Insère un nouveau client dans la base de données.
            /// </summary>
            /// <param name="id">L'identifiant du client.</param>
            /// <param name="prenom">Le prénom du client.</param>
            /// <param name="nom">Le nom du client.</param>
            /// <param name="phone">Le numéro de téléphone du client.</param>
            /// <param name="city">La ville du client.</param>
            /// <returns>Retourne true si l'insertion réussit, false sinon.</returns>
            Log.Debug("insertClient - Tentative d'insertion d'un nouveau client : ID={id}, Prenom={prenom}, Nom={nom}, Phone={phone}, City={city}", id, prenom, nom, phone, city);
            // Définit la requête SQL pour insérer un nouveau client
            string insertQuerry = "INSERT INTO `guest`(`GuestId`, `GuestPrenom`, `GuestNom`, `GuestPhone`, `GuestCity`) VALUES(@id,@prenom,@nom,@ph,@city)";
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            //@id,@nom,@prenom,@ph,@city
            // Ajoute des paramètres à la requête SQL
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = prenom;
            command.Parameters.Add("@nom", MySqlDbType.VarChar).Value = nom;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@city", MySqlDbType.VarChar).Value = city;

            // Ouvre la connexion à la base de données
            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                // Ferme la connexion à la base de données et retourne true si l'insertion est réussie
                connect.CloseCon();
                Log.Debug("insertClient - Client inséré avec succès : ID={id}", id);
                return true;
            }
            else
            {
                // Ferme la connexion à la base de données et retourne false si l'insertion a échoué
                connect.CloseCon();
                Log.Debug("insertClient - Échec de l'insertion du client : ID={id}", id);
                return false;
            }

        }

        /// <summary>
        /// Modifie les informations d'un client existant dans la base de données.
        /// </summary>
        /// <param name="id">L'identifiant du client à modifier.</param>
        /// <param name="prenom">Le nouveau prénom du client.</param>
        /// <param name="nom">Le nouveau nom du client.</param>
        /// <param name="phone">Le nouveau numéro de téléphone du client.</param>
        /// <param name="city">La nouvelle ville du client.</param>
        /// <returns>Retourne true si la modification réussit, false sinon.</returns>
        public bool editGuest(string id, string prenom, string nom, string phone, string city)
        {
            Log.Debug("editGuest - Tentative de modification d'un client : ID={id}, Prenom={prenom}, Nom={nom}, Phone={phone}, City={city}", id, prenom, nom, phone, city);
            // Définit la requête SQL pour modifier un client
            string editQuerry = "UPDATE `guest` SET `GuestPrenom`=@prenom,`GuestNom`=@nom,`GuestPhone`=@ph,`GuestCity`=@city WHERE `GuestId`=@id";
            MySqlCommand command = new MySqlCommand(editQuerry, connect.GetConnection());
            //@id,@fname,@lname,@ph,@ct
            // Ajoute des paramètres à la requête SQL
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = prenom;
            command.Parameters.Add("@nom", MySqlDbType.VarChar).Value = nom;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@city", MySqlDbType.VarChar).Value = city;
            // Ouvre la connexion à la base de données
            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                // Ferme la connexion à la base de données et retourne true si la modification est réussie
                connect.CloseCon();
                Log.Debug("editGuest - Client modifié avec succès : ID={id}", id);
                return true;
            }
            else
            {
                // Ferme la connexion à la base de données et retourne false si la modification a échoué
                connect.CloseCon();
                Log.Debug("editGuest - Échec de la modification du client : ID={id}", id);
                return false;
            }
        }

        /// <summary>
        /// Supprime un client de la base de données.
        /// </summary>
        /// <param name="id">L'identifiant du client à supprimer.</param>
        /// <returns>Retourne true si la suppression réussit, false sinon.</returns>
        public bool removeGuest(string id)
        {
            Log.Debug("removeGuest - Tentative de suppression d'un client : ID={id}", id);

            // Définit la requête SQL pour supprimer un client
            string insertQuerry = "DELETE FROM `guest` WHERE `GuestId`=@id";
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            //@id
            // Ajoute le paramètre à la requête SQL
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            // Ouvre la connexion à la base de données
            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                // Ferme la connexion à la base de données et retourne true si la suppression est réussie
                connect.CloseCon();
                Log.Debug("removeGuest - Client supprimé avec succès : ID={id}", id);
                return true;
            }
            else
            {
                // Ferme la connexion à la base de données et retourne false si la suppression a échoué
                connect.CloseCon();
                Log.Debug("removeGuest - Échec de la suppression du client : ID={id}", id);
                return false;
            }
        }

        /// <summary>
        /// Obtient la liste des clients de la base de données.
        /// </summary>
        /// <returns>Un DataTable contenant la liste des clients.</returns>        
        public DataTable getClient()
        {
            Log.Debug("getClient - Récupération de la liste des clients.");
            // Définit la requête SQL pour obtenir tous les clients
            string selectQuery = "SELECT * FROM `guest`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            // Remplit le DataTable avec les résultats de la requête SQL
            adapter.SelectCommand = command;
            adapter.Fill(table);

            // Retourne le DataTable
            return table;
        }
    }
}