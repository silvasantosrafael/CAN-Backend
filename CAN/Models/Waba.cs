using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CAN.Models
{
    public class Waba
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<NumeroWaba> Numeros { get; set; }
        public long BmID { get; set; }
        public string Cliente { get; set; }
    }
}