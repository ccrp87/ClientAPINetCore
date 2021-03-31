using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{

    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Valor { get; set; }
        public double Stock { get; set; }
        public double Iva { get; set; }
        public int TiendaId { get; set; }
    }
}
