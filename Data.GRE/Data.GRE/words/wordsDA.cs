using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.GRE
{
    public class wordsDa
    {
        //string constr = "server=127.0.0.2;port=3306;uid=root;pwd=nsxr;database=gre;";
        string constr = "Database=gre;Data Source=us-cdbr-azure-east-c.cloudapp.net;User Id=bc696b0dd57bd8;Password=f3f41da1;";

        public void Load(ICollection<wordsObject> collection)
        {            
            string sql = "select * from words ";

            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataReader row = cmd.ExecuteReader())
                    {
                        while (row.Read())
                        {
                            wordsObject w = new wordsObject(row);
                            collection.Add(w);
                        }
                    }

                }
                catch (MySqlException e)
                {
                    throw;
                }

            }
        }

        public void LoadByWord(ICollection<wordsObject> collection, string word)
        {
            string sql = "select * from words where word=@word";

            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataReader row = cmd.ExecuteReader())
                    {
                        cmd.Parameters.AddWithValue("@word", word);
                        while (row.Read())
                        {
                            wordsObject w = new wordsObject(row);
                            collection.Add(w);
                        }
                    }

                }
                catch (MySqlException e)
                {
                    throw;
                }

            }

        }



    }


    
}
