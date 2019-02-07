using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Destinario
    {
        [Key]
        public int DestinarioId { get; set; }
        public string Nombre { get; set; }
        public int CartasRevisivas { get; set; }

        public Destinario()
        {
            DestinarioId = 0;
            Nombre = string.Empty;
            CartasRevisivas = 0;
        }
    }
}
