using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class FacturaDetalle
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public float Valor { get; set; }
        public float Iva { get; set; }
        public int FacturaId { get; set; }
    }
}
