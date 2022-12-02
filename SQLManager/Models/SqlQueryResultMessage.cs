using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLManager.Models
{
    public class SqlQueryResultMessage
    {
        public int RecordsAffected { get; set; }
        public DataTable Table { get; set; }
        public DateTime CompletionTime { get; set; }
    }
}
