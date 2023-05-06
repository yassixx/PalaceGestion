using MySql.Data.MySqlClient;

namespace PalaceGestion
{
    class DBConnect
    {

        private readonly MySqlConnection connection = new MySqlConnection("**********************");

        // Créez une connexion à la base de données MySQL avec les informations d'identification spécifiées
        //private readonly MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hotel_data");
        //bdd de test
        // private readonly MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hotel-data_test");

        /// <summary>
        /// Cette méthode retourne la connexion à la base de données
        /// </summary>
        /// <returns>MySqlConnection</returns>
        public MySqlConnection GetConnection()
        {
            return connection;
        }

        /// <summary>
        /// Cette méthode ouvre la connexion à la base de données si elle est fermée
        /// </summary>
        public void OpenCon()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        /// <summary>
        /// Cette méthode ferme la connexion à la base de données si elle est ouverte
        /// </summary>
        public void CloseCon()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
