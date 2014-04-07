using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SuperTrunfo.Modelos
{
    [DataContract]
    public class JogadorCollection : ObservableCollection<Jogador>
    {
    }
}
