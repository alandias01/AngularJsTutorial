using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Data.GRE
{
    public class listsObject
    {
        public string email { get; set; }
        public string listName { get; set; }
        public string word { get; set; }

        public listsObject() { }
        public listsObject(MySqlDataReader row)
        {
            email = row["email"] == DBNull.Value ? email : (string)row["email"];
            listName = row["listName"] == DBNull.Value ? listName : (string)row["listName"];
            word = row["word"] == DBNull.Value ? word : (string)row["word"];
        }
    }
}
