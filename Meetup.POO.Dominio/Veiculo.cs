using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Meetup.POO.Dominio
{
    public abstract class Veiculo
    {
        private Color _cor;
        public Color Cor 
        {
            get { return _cor; }
            set { _cor = value; }
        }

        public string Modelo { get; set; }
        public int QtdePassageiros { get; set; }

        public virtual string Acelerar()
        {
            return "Aceleração padrão!!";
        }

        public virtual void Frear()
        {

        }
    }
}
