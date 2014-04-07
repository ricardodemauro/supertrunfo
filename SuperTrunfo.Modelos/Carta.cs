using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SuperTrunfo.Modelos
{
    [DataContract]
    public class Carta : ModelBase
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

        private string nome;

        [DataMember]
        public string Nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                this.SetProperty(ref this.nome, value);
            }
        }

        private string descricao;

        [DataMember]
        public string Descricao
        {
            get
            {
                return this.descricao;
            }
            set
            {
                this.SetProperty(ref this.descricao, value);
            }
        }


        private Uri pathImagem;

        [DataMember]
        public Uri PathImagem
        {
            get
            {
                return this.pathImagem;
            }
            set
            {
                this.SetProperty(ref this.pathImagem, value);
            }
        }

        private AtributoCollection atributos;

        [DataMember]
        public AtributoCollection Atributos
        {
            get
            {
                return this.atributos;
            }
            set
            {
                this.SetProperty(ref this.atributos, value);
            }
        }
    }
}
