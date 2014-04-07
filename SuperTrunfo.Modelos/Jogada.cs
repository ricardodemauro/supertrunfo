using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SuperTrunfo.Modelos
{
    [DataContract]
    public class Jogada : ModelBase
    {
        private Guid id;

        [DataMember]
        public Guid Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.SetProperty(ref this.id, value);
            }
        }

        private Jogador jogador;

        [DataMember]
        public Jogador Jogador
        {
            get
            {
                return this.jogador;
            }
            set
            {
                this.SetProperty(ref this.jogador, value);
            }
        }

        private Mesa mesa;

        [DataMember]
        public Mesa Mesa
        {
            get
            {
                return this.mesa;
            }
            set
            {
                this.SetProperty(ref this.mesa, value);
            }
        }

        private Carta carta;

        [DataMember]
        public Carta Carta
        {
            get
            {
                return this.carta;
            }
            set
            {
                this.SetProperty(ref this.carta, value);
            }
        }
    }
}
