using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CurrencyExchanger
{
    public class OperationRepository
    {
        private SqlConnection sqlConnection = DataBaseConnecter.getInstance().getConnection();

        public List<Operation> ReadAll()
        {
            List<Operation> result = new List<Operation>();
            SqlDataReader sqlReader;
            SqlCommand command = new SqlCommand("SELECT * FROM [Operations]", sqlConnection);
            sqlReader = command.ExecuteReader();

            try
            {
                while (sqlReader.Read())
                {
                    Operation operation = new Operation();
                    operation.Username = Convert.ToString(sqlReader["username"]);
                    operation.Operations = Convert.ToString(sqlReader["operation"]);
                    operation.Amount = Convert.ToString(sqlReader["amount"]);
                    operation.Sign = Convert.ToString(sqlReader["sign"]);
                    operation.Date = Convert.ToString(sqlReader["date"]);
                    result.Add(operation);
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

        public bool Write(Operation operation)
        {
            if (sqlConnection == null)
                return false;

            SqlCommand command = new SqlCommand("INSERT INTO [Operations] (username,operation,amount,sign,date)VALUES(@username,@operation,@amount,@sign,@date)", sqlConnection);

            command.Parameters.AddWithValue("username", operation.Username);
            command.Parameters.AddWithValue("operation", operation.Operations);
            command.Parameters.AddWithValue("amount", operation.Amount);
            command.Parameters.AddWithValue("sign", operation.Sign);
            command.Parameters.AddWithValue("date", DateTime.Now.ToString("dd/MM/yyyy"));

            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
    }
}
