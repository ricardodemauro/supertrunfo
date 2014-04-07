using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SuperTrunfo.Modelos
{
    [DataContract]
    public class Atributo : ModelBase
    {
        private Guid chave;
        [DataMember]
        public Guid Chave
        {
            get
            {
                return this.chave;
            }
            set
            {
                this.SetProperty(ref this.chave, value);
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

        private int valor;
        [DataMember]
        public int Valor
        {
            get
            {
                return this.valor;
            }
            set
            {
                this.SetProperty(ref this.valor, value);
            }
        }

        private bool selecionado;

        public bool Selecionado
        {
            get
            {
                return this.selecionado;
            }
            set
            {
                this.SetProperty(ref this.selecionado, value);
            }
        }
    }
}
