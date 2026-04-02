using Microsoft.Data.SqlClient;

namespace Database_ASM_music_store
{
    public static class DatabaseHelper
    {
        // Connection string based on SSMS screenshot: Server=MSI, Windows Authentication
        // Adjust 'Initial Catalog' if the database name is different.
        private static readonly string ConnectionString = "Server=MSI;Initial Catalog=JessesDelight;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
