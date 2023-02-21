using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace questionnaire
{
    public class Account
    {
        public string login { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string role { get; set; }

        public void New(Account account)
        {
            try
            {
                NpgsqlCommand cmd = Database.GetCommand("INSERT INTO \"Account\" (name, password, role) VALUES (@1, @2, @3)");
                cmd.Parameters.AddWithValue("@1", NpgsqlTypes.NpgsqlDbType.Varchar, account.name);
                cmd.Parameters.AddWithValue("@2", NpgsqlTypes.NpgsqlDbType.Varchar, account.role);
                cmd.Parameters.AddWithValue("@2", NpgsqlTypes.NpgsqlDbType.Varchar, account.password);
                int result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public bool GetAccount(Account account)
        {
            NpgsqlCommand cmd = Database.GetCommand("SELECT FROM \"Account\" * WHERE login =@1 AND password = @2");
            cmd.Parameters.AddWithValue("@1", NpgsqlTypes.NpgsqlDbType.Varchar, account.login);
            cmd.Parameters.AddWithValue("@2", NpgsqlTypes.NpgsqlDbType.Varchar, account.password);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                return false;
            }
            reader.Close();
            return true;
        }
    }
}
