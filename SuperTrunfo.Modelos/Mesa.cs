using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SuperTrunfo.Modelos
{
    [DataContract]
    public class Mesa : ModelBase
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

        private JogadorCollection jogadores;

        [DataMember]
        public JogadorCollection Jogadores
        {
            get
            {
                return this.jogadores;
            }
            set
            {
                this.SetProperty(ref this.jogadores, value);
            }
        }

        public Mesa(JogadorCollection jogadores)
        {
            this.Jogadores = jogadores;
        }

        public Mesa()
        {
            this.Jogadores = new JogadorCollection();
        }
    }
}
