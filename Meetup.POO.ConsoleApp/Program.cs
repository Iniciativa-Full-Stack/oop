using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Meetup.POO.Dominio.Entidade;
using Meetup.POO.Dominio;

namespace Meetup.POO.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string retorno = string.Empty;

            Veiculo carro = new Carro();
            carro.Cor = Color.Red;
            carro.QtdePassageiros = 5;
            carro.Modelo = Volkswagen.Gol;

            retorno = carro.Acelerar();

            var moto = new Moto(2);
            moto.Modelo = Yamaha.RD350;
            moto.Cor = Color.Black;

            retorno = moto.Acelerar();

            var bicicleta = new Bicicleta();
            bicicleta.QtdePassageiros = 1;
            bicicleta.Marca = Marcas.Caloi;

            retorno = bicicleta.Acelerar();
        }
    }
}
