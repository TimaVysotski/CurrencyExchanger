using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CurrencyExchanger
{
    public class SettingsRepository
    {
        private SqlConnection sqlConnection = DataBaseConnecter.getInstance().getConnection();
        public Settings getOfCurrentUsername(string username)
        {
            SqlDataReader sqlReader;
            SqlCommand command = new SqlCommand("SELECT * FROM [Settings] WHERE username = '" + username + "'", sqlConnection);
            sqlReader = command.ExecuteReader();
            Settings settings = new Settings();

            try
            {
                if (sqlReader.Read())
                {
                    settings.Id = Convert.ToInt32(sqlReader["Id"]);
                    settings.MaxBuy = Convert.ToInt32(sqlReader["maxBuy"]);
                    settings.MaxSell = Convert.ToInt32(sqlReader["maxSell"]);
                    settings.LimitationDate = Convert.ToString(sqlReader["limitationDate"]);
                    settings.CurrentBuyDate = Convert.ToInt32(sqlReader["currentBuyDate"]);
                    settings.CurrentSellDate = Convert.ToInt32(sqlReader["currentSellDate"]);
                    settings.Username = Convert.ToString(sqlReader["username"]);
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

            return settings;
        }

        public bool Write(Settings settings)
        {
            if (sqlConnection == null)
                return false;

            SqlCommand command = new SqlCommand("INSERT INTO [Settings] (maxSell,maxBuy,limitationDate,currentSellDate,currentBuyDate,username)VALUES(@maxSell,@maxBuy,@limitationDate,@currentSellDate,@currentBuyDate,@username)", sqlConnection);

            command.Parameters.AddWithValue("maxSell", settings.MaxSell);
            command.Parameters.AddWithValue("maxBuy", settings.MaxBuy);
            command.Parameters.AddWithValue("limitationDate", settings.LimitationDate);
            command.Parameters.AddWithValue("currentSellDate", settings.CurrentSellDate);
            command.Parameters.AddWithValue("currentBuyDate", settings.CurrentBuyDate);
            command.Parameters.AddWithValue("username", settings.Username);

            return Convert.ToBoolean(command.ExecuteNonQuery());
        }

        public bool Update(Settings settings)
        {
            if (sqlConnection == null)
                return false;

            SqlCommand command = new SqlCommand("UPDATE Settings SET maxSell = @maxSell, maxBuy = @maxBuy, limitationDate = @limitationDate, currentSellDate = @currentSellDate, currentBuyDate = @currentBuyDate, username = @username WHERE Id = '" + settings.Id + "'", sqlConnection);

            command.Parameters.AddWithValue("maxSell", settings.MaxSell);
            command.Parameters.AddWithValue("maxBuy", settings.MaxBuy);
            command.Parameters.AddWithValue("limitationDate", settings.LimitationDate);
            command.Parameters.AddWithValue("currentSellDate", settings.CurrentSellDate);
            command.Parameters.AddWithValue("currentBuyDate", settings.CurrentBuyDate);
            command.Parameters.AddWithValue("username", settings.Username);

            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
    }
}
