using System;
using System.Collections.Generic;

namespace Ventas.Models
{
    public partial class Auto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int? Anho { get; set; }
        public int IdMarca { get; set; }

        public virtual Modelo IdMarcaNavigation { get; set; } = null!;
    }
}
