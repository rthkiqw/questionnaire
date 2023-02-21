using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;

namespace questionnaire
{
    public class Database
    {
        private static NpgsqlConnection conn;
        public static void Connect(string host, string port, string user, string pass, string dbname)
        {
            string cs = string.Format("Server={0};Port={1};User ID={2};Password={3};Database={4}", host, port, user, pass, dbname);

            conn = new NpgsqlConnection(cs);
            conn.Open();
        }

        public static NpgsqlCommand GetCommand(string sql)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = conn;
            command.CommandText = sql;
            return command;
        }
    }
}