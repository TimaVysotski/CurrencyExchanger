using System.Data.SqlClient;


namespace CurrencyExchanger
{
    public class DataBaseConnecter
    {
        private SqlConnection sqlConnection;
        static DataBaseConnecter instance;
        public DataBaseConnecter()
        {
            string connectingString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\dev\CurrencyExchanger\CurrencyExchanger\CurrencyExchanger\Repositories\Database1.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectingString);
            sqlConnection.Open();
        }

        public static DataBaseConnecter getInstance()
        {
            if (instance == null)
                instance = new DataBaseConnecter();
            return instance;
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
