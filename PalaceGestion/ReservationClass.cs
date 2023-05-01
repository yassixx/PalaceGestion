using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace PalaceGestion
{
    /// <summary>
    /// Cette classe est responsable de la gestion des réservations dans la base de données.
    /// </summary>
    class ReservationClass    
    {

        /// <summary>
        /// Instance de la classe DBConnect pour établir la connexion avec la base de données.
        /// </summary>
        readonly DBConnect connect = new DBConnect();

        /// <summary>
        /// Retourne un DataTable contenant les chambres disponibles en fonction du type de chambre.
        /// </summary>
        /// <param name="type">Type de chambre.</param>
        /// <returns>DataTable avec les chambres disponibles.</returns>
        public DataTable roomByType(int type)
        {
            // La requête SQL
            string selectQuery = "SELECT * FROM `room` WHERE `RoomType`=@type AND `RoomStatus` ='Libre'";
            // Crée une commande SQL
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            // Ajoute le paramètre à la commande SQL
            command.Parameters.Add("@type", MySqlDbType.Int32).Value = type;
            // Crée un adaptateur SQL
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            // Crée un nouveau DataTable
            DataTable table = new DataTable();
            // Remplit le DataTable
            adapter.Fill(table);
            // Retourne le DataTable
            return table;
        }

        /// <summary>
        /// Retourne le type de chambre en fonction du numéro de chambre.
        /// </summary>
        /// <param name="rno">Numéro de chambre.</param>
        /// <returns>Type de chambre.</returns>
        public int typeByRoomNo(string rno)
        {
            // La requête SQL
            string selectQuery = "SELECT `RoomType` FROM `room` WHERE `RoomId`=@rno";
            // Crée une commande SQL
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            // Ajoute le paramètre à la commande SQL
            command.Parameters.Add("@rno", MySqlDbType.VarChar).Value = rno;
            // Crée un adaptateur SQL
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            // Crée un nouveau DataTable
            DataTable table = new DataTable();
            // Remplit le DataTable
            adapter.Fill(table);
            // Convertit et retourne le type de la chambre
            return Convert.ToInt32(table.Rows[0][0].ToString());
        }

        /// <summary>
        /// Retourne un DataTable contenant toutes les réservations.
        /// </summary>
        /// <returns>DataTable avec toutes les réservations.</returns>
        public DataTable getReserv()
        {
            // La requête SQL
            string selectQuery = "SELECT * FROM `reservation`";
            // Crée une commande SQL
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            // Crée un adaptateur SQL
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            // Crée un nouveau DataTable
            DataTable table = new DataTable();

            // Configure l'adaptateur SQL
            adapter.SelectCommand = command;
            // Remplit le DataTable
            adapter.Fill(table);

            // Retourne le DataTable
            return table;
        }

        /// <summary>
        /// Ajoute une nouvelle réservation.
        /// </summary>
        /// <param name="guestId">ID du client.</param>
        ///  /// <param name="roomNo">Numéro de la chambre.</param>
        /// <param name="dateIn">Date d'arrivée.</param>
        /// <param name="dateOut">Date de départ.</param>
        /// <returns>Booléen indiquant si l'ajout a réussi.</returns>
        public bool addReserv(string guestId, string roomNo, DateTime dateIn, DateTime dateOut)
        {
            // La requête SQL
            string insertQuerry = "INSERT INTO `reservation`(`GuestId`, `RoomNo`, `DateIn`, `DateOut`) VALUES (@Gid,@Rno,@Din,@Dout)";
            // Crée une commande SQL
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());

            // Ajoute les paramètres à la commande SQL
            command.Parameters.Add("@Gid", MySqlDbType.VarChar).Value = guestId;
            command.Parameters.Add("@Rno", MySqlDbType.VarChar).Value = roomNo;
            command.Parameters.Add("@Din", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@Dout", MySqlDbType.Date).Value = dateOut;

            // Ouvre la connexion à la base de données
            connect.OpenCon();
            // Exécute la commande SQL et vérifie si la requête a réussi
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }
        }

        /// <summary>
        /// Met à jour le statut d'une chambre lorsqu'elle est réservée.
        /// </summary>
        /// <param name="rno">Numéro de chambre.</param>
        /// <param name="sts">Nouveau statut de la chambre.</param>
        /// <returns>Booléen indiquant si la mise à jour a réussi.</returns>
        public bool setReservRoom(string rno, string sts)
        {
            // La requête SQL
            string updateQuery = "UPDATE `room` SET `RoomStatus`=@sts WHERE `RoomId`=@rno";
            // Crée une commande SQL
            MySqlCommand command = new MySqlCommand(updateQuery, connect.GetConnection());

            // Ajoute les paramètres à la commande SQL
            command.Parameters.Add("@rno", MySqlDbType.VarChar).Value = rno;
            command.Parameters.Add("@sts", MySqlDbType.VarChar).Value = sts;
            // Ouvre la connexion à la base de données
            connect.OpenCon();
            // Exécute la commande SQL et vérifie si la requête a réussi
            if (command.ExecuteNonQuery() == 1)
            {
                // Ferme la connexion à la base de données
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }
        }

        /// <summary>
        /// Modifie une réservation existante.
        /// </summary>
        /// <param name="reserId">ID de la réservation.</param>
        /// <param name="guestId">ID du client.</param>
        /// <param name="roomNo">Numéro de la chambre.</param>
        /// <param name="dateIn">Date d'arrivée.</param>
        /// <param name="dateOut">Date de départ.</param>
        /// <returns>Booléen indiquant si la modification a réussi.</returns>
        public bool editReserv(int reserId, string guestId, string roomNo, DateTime dateIn, DateTime dateOut)
        {
            // La requête SQL
            string insertQuerry = "UPDATE `reservation` SET `GuestId`=@Gid,`RoomNo`=@Rno,`DateIn`=@Din,`DateOut`=@Dout WHERE `RecevId`=@rid";
            // Crée une commande SQL
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            // Ajoute les paramètres à la commande SQL
            command.Parameters.Add("@rid", MySqlDbType.Int32).Value = reserId;
            command.Parameters.Add("@Gid", MySqlDbType.VarChar).Value = guestId;
            command.Parameters.Add("@Rno", MySqlDbType.VarChar).Value = roomNo;
            command.Parameters.Add("@Din", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@Dout", MySqlDbType.Date).Value = dateOut;

            // Ouvre la connexion à la base de données
            connect.OpenCon();
            // Exécute la commande SQL et vérifie si la requête a réussi
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }
        }

        /// <summary>
        /// Supprime une réservation.
        /// </summary>
        /// <param name="id">ID de la réservation.</param>
        /// <returns>Booléen indiquant si la suppression a réussi.</returns>
        public bool removeReserv(int id)
        {
            // La requête SQL
            string insertQuerry = "DELETE FROM `reservation` WHERE `RecevId`=@id";
            // Crée une commande SQL
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            // Ajoute le paramètre à la commande SQL
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            // Ouvre la connexion à la base de données
            connect.OpenCon();
            // Exécute la commande SQL et vérifie si la requête a réussi
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }
        }
    }
}

