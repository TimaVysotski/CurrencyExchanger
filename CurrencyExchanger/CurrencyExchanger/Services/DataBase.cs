using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyExchanger
{
    public class DataBase
    {
        private SqlConnection sqlConnection;
        static DataBase instance;
        public DataBase()
        {
            string connectingString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\dev\CurrencyExchanger\CurrencyExchanger\CurrencyExchanger\DB\Database1.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectingString);
            sqlConnection.Open();
        }

        public static DataBase getInstance()
        {
            if(instance == null)
                instance = new DataBase();
            return instance;
        }

        public List<string> ReadOperations()
        {
            List<string> result = new List<string>();
            
            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [Operations]", sqlConnection);

            sqlReader = command.ExecuteReader();

            try
            {
                while (sqlReader.Read())
                {
                    result.Add(
                        Convert.ToString(sqlReader["username"]) + " | " +
                        "Operation:" +
                        Convert.ToString(sqlReader["operation"]) + " " +
                        Convert.ToString(sqlReader["amount"]) + "" +
                        Convert.ToString(sqlReader["sign"]) + " | " +
                        "Date:" + "  " +
                        Convert.ToString(sqlReader["date"]));
                }
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.ToString(), exeption.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }

            return result;
        }

        public bool WriteOperation(Operation operation)
        {
            if (sqlConnection == null)
                return false;

            SqlCommand command = new SqlCommand("INSERT INTO [Operations] (username,operation,amount,sign,date)VALUES(@username,@operation,@amount,@sign,@date)", sqlConnection);

            command.Parameters.AddWithValue("username", operation.Username);
            command.Parameters.AddWithValue("operation", operation.Operations);
            command.Parameters.AddWithValue("amount", operation.Amount);
            command.Parameters.AddWithValue("sign", operation.Sign);
            command.Parameters.AddWithValue("date", DateTime.Now);

            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
    }
}
