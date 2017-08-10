using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meetup.POO.Dominio.Interface;

namespace Meetup.POO.Dominio.Entidade
{
    public class Moto : Veiculo, ILicenciamento
    {
        public Moto()
        {

        }

        public Moto(int QtdePassageiros)
        {
            this.QtdePassageiros = QtdePassageiros;
        }

        public override string Acelerar()
        {

        }

        public override void Frear()
        {
            base.Frear();
        }

        public string Licenciar()
        {
            return "Anualmente temos que fazer o licenciamento da moto!!";
        }
    }

    public struct Yamaha
    {
        public static string RD350 { get { return "RD350"; } }
    }

    public struct Honda
    {
        public static string CBX450 { get { return "CBX450"; } }
    }
}
