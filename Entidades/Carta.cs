using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carta
    {
        public int CartaId { get; set; }
        public DateTime Fecha { get; set; }
        public int DestinarioId { get; set; }
        public string Cuerpo { get; set; }

        public Carta()
        {
            CartaId = 0;
            Fecha = DateTime.Now;
            DestinarioId = 0;
            Cuerpo = string.Empty;
        }
    }
}
