using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConstructionCompany.DataAdapters
{ 
    //Класс предназначен для упрощения одних и тех же операций с базой данных
    public abstract class DataAdapter
    {
        protected MySqlConnection Connection;
        protected List<Dictionary<String, String>> GetQueryResult(string query)
        {
            List<Dictionary<String, String>> result = new List<Dictionary<string, string>>();
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Dictionary<string, string> row = new Dictionary<string, string>();
                    
                    for (int i = 0; i < reader.FieldCount; i++)
                        row.Add(reader.GetName(i), reader.GetString(i));
                    
                    result.Add(row);
                }
            }
            return result;
        }
        
        protected int Execute(string query)
        {
            Console.WriteLine("=========" + query);
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            return cmd.ExecuteNonQuery();
        }
        protected int Execute(MySqlCommand cmd)
        {
            cmd.Connection = Connection;
            return cmd.ExecuteNonQuery();
        }
        protected long InsertRow(MySqlCommand cmd)
        {
            cmd.Connection = Connection;
            cmd.ExecuteNonQuery();
            return cmd.LastInsertedId;
        }
        protected long InsertRow(string query)
        {
            Console.WriteLine("--------" + query);
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.ExecuteNonQuery();
            return cmd.LastInsertedId;
        }
        
        protected Dictionary<string, string> GetIndexedList(string query)
        {
            Dictionary<String, String> result = new Dictionary<string, string>();
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                    result.Add(reader.GetString(0), reader.GetString(1));
            }
            return result;
        }
        public DataAdapter(MySqlConnection connection)
        {
            this.Connection = connection;
        }
    }
}
