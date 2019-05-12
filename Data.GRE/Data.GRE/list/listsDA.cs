using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.GRE
{
    public class listsDa
    {
        public void Load(ICollection<listsObject> collection)
        {
            //string constr = "server=127.0.0.1;port=3306;uid=root;pwd=nsxr;database=gre;";
            string constr = "Database=gre;Data Source=us-cdbr-azure-east-c.cloudapp.net;User Id=bc696b0dd57bd8;Password=f3f41da1;";
            string sql = "select * from lists";

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
                            listsObject w = new listsObject(row);
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
