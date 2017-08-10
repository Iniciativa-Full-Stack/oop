using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meetup.POO.Dominio.Entidade
{
    public class Bicicleta : Veiculo
    {
        public string Marca { get; set; }

        public override string Acelerar()
        {
            return "Bora pedalar galera....rs!!";
        }

        public override void Frear()
        {
            base.Frear();
        }
    }

    public struct Marcas
    {
        public static string Caloi { get { return "Caloi"; } }
        public static string Monark { get { return "Monark"; } }
    }
}
