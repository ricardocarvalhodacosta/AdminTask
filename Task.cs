using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TaskManager
{
    public class Task
    {
        public string Projeto { get; set; }
        public string Descricao { get; set; }
        public DateTime Data1 { get; set; }
        public DateTime Data2 { get; set; }
        public bool Status { get; set; }
    }
}
