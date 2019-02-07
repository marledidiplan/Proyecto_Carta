using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CartaRepositorio : RepositorioBase<Carta>
    {
        public override bool Guardar(Carta carta)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            contexto.cartas.Add(carta);
            contexto.destinarios.Find(carta.DestinarioId).CartasRevisivas +=
        }
    }
}
