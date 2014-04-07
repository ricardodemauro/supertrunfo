using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SuperTrunfo.Modelos
{
    [DataContract]
    public class Jogador : ModelBase
    {
        private CartaCollection cartas;

        [DataMember]
        public CartaCollection Cartas
        {
            get
            {
                return this.cartas;
            }
            set
            {
                this.SetProperty(ref this.cartas, value);
            }
        }

        public int QuantidadeCartas
        {
            get
            {
                return this.Cartas.Count;
            }
        }

        public Jogador()
        {
            this.Cartas = new CartaCollection();
        }

        public Jogador(CartaCollection cartas)
        {
            this.Cartas = cartas;
        }
    }
}
