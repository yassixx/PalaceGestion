using MySql.Data.MySqlClient;
using System.Data;

namespace PalaceGestion
{
    /// <summary>
    /// Classe représentant la logique métier pour la gestion des chambres.
    /// </summary>
    class RoomClass
    {
        /// <summary>
        /// Instance de la classe DBConnect pour interagir avec la base de données.
        /// </summary>
        readonly DBConnect connect = new DBConnect();

        /// <summary>
        /// Récupère tous les types de chambres disponibles.
        /// </summary>
        /// <returns>DataTable contenant les types de chambres.</returns>
        public DataTable getRoomType()
        {
            // On défini la requête SQL à exécuter
            string selectQuery = "SELECT * FROM `category`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            // On retourne le résultat sous forme de DataTable
            return table;
        }

        /// <summary>
        /// Récupère la liste de toutes les chambres.
        /// </summary>
        /// <returns>DataTable contenant toutes les chambres.</returns>
        public DataTable getRoomList()
        {
            string selectQuery = "SELECT * FROM `room`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            // On retourne le résultat sous forme de DataTable
            return table;
        }

        /// <summary>
        /// Ajoute une nouvelle chambre.
        /// </summary>
        /// <param name="no">Numéro de la chambre.</param>
        /// <param name="type">Type de la chambre.</param>
        /// <param name="phone">Numéro de téléphone de la chambre.</param>
        /// <param name="status">Statut de la chambre.</param>
        /// <returns>Booléen indiquant si l'ajout a réussi.</returns>
        public bool addRoom(string no, int type, string phone, string status)
        {
            string insertQuerry = "INSERT INTO `room`(`RoomId`, `RoomType`, `RoomPhone`, `RoomStatus`) VALUES (@no,@type,@ph,@sts)";
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            //@no,@type,@ph,@sts
            command.Parameters.Add("@no", MySqlDbType.VarChar).Value = no;
            command.Parameters.Add("@type", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@sts", MySqlDbType.VarChar).Value = status;

            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                // La chambre a été ajoutée avec succès
                return true;
            }
            else
            {
                connect.CloseCon();
                // L'ajout de la chambre a échoué
                return false;
            }
        }

        /// <summary>
        /// Modifie une chambre existante.
        /// </summary>
        /// <param name="no">Numéro de la chambre.</param>
        /// <param name="type">Type de la chambre.</param>
        /// <param name="phone">Numéro de téléphone de la chambre.</param>
        /// <param name="status">Statut de la chambre.</param>
        /// <returns>Booléen indiquant si la modification a réussi.</returns>
        public bool editRoom(string no, int type, string phone, string status)
        {
            string editQuerry = "UPDATE `room` SET `RoomType`=@type,`RoomPhone`=@ph,`RoomStatus`=@sts WHERE `RoomId`=@no";
            MySqlCommand command = new MySqlCommand(editQuerry, connect.GetConnection());
            //@no,@type,@ph,@sts
            command.Parameters.Add("@no", MySqlDbType.VarChar).Value = no;
            command.Parameters.Add("@type", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@sts", MySqlDbType.VarChar).Value = status;

            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                // La chambre a été modifiée avec succès
                return true;
            }
            else
            {
                connect.CloseCon();
                // La modification de la chambre a échoué
                return false;
            }
        }

        /// <summary>
        /// Supprime une chambre.
        /// </summary>
        /// <param name="id">Identifiant de la chambre à supprimer.</param>
        /// <returns>Booléen indiquant si la suppression a réussi.</returns>        
        public bool removeRoom(string id)
        {
            string insertQuerry = "DELETE FROM room WHERE RoomId=@id";
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            //@id
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                // La chambre a été supprimée avec succès
                return true;
            }
            else
            {
                connect.CloseCon();
                // La suppression de la chambre a échoué
                return false;
            }
        }
    }
}
