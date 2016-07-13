using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLiteNetExtensions.Attributes;

namespace RunningLogDbModel.Model
{
    public class Runs
    {
        [SQLite.Net.Attributes.PrimaryKey]
        public int IdRuns { get; set; }
        public DateTime Giorno { get; set; }
        public decimal Lunghezza { get; set; }
        public TimeSpan Durata { get; set; }
        public string Commenti { get; set; }
        public int FrequenzaCardiacaMedia { get; set; }

        
    }
}
