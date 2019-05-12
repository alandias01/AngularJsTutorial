using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Data.GRE
{
    public class wordsObject
    {
        public string word { get; set; }
        public string definition { get; set; }
        public string type { get; set; }

        public wordsObject() { }
        public wordsObject(MySqlDataReader row)
        {
            word = row["word"] == DBNull.Value ? word : (string)row["word"];
            definition = row["definition"] == DBNull.Value ? definition : (string)row["definition"];
            type = row["type"] == DBNull.Value ? type : (string)row["type"];
        }
    }
}
