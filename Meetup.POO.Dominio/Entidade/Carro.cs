using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using Meetup.POO.Dominio.Interface;

namespace Meetup.POO.Dominio.Entidade
{
    public class Carro : Veiculo, ILicenciamento
    {
        //Construtor
        public Carro()
        {

        }

        public Carro(Color cor)
        {
            this.Cor = cor;
        }

        public override string Acelerar()
        {
            return "A aceleração do carro é feita artavés de pedal!!";
        }

        public override void Frear()
        {
            throw new NotImplementedException();
        }

        public string Licenciar()
        {
            return "Anualmente temos que fazer o licenciamento do carro!!";
        }

        public void AbrirPortaMalas()
        {

        }
    }

    public struct Volkswagen
    {
        public static string Gol { get { return "Gol"; } }
        public static string Voyage { get { return "Voyage"; } }
    }

    public struct Fiat
    {
        public static string Uno { get { return "Uno"; } }
        public static string Palio { get { return "Palio"; } }
    }
}
