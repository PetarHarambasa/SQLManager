using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLManager.Models
{
    public class Database
    {
        public string Name { get; set; }

        public override string ToString()=> Name;
    }
}
