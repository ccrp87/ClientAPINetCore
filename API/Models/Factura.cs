using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Factura
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public float Total { get; set; }
        public float SubTotal { get; set; }
        public int ClientId { get; set; }
    }
}
