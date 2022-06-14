using System;
using System.Collections.Generic;

namespace Ventas.Models
{
    public partial class Modelo
    {
        public Modelo()
        {
            Autos = new HashSet<Auto>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<Auto> Autos { get; set; }
    }
}
