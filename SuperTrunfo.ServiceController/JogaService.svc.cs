using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SuperTrunfo.Modelos;

namespace SuperTrunfo.ServiceController
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "JogaService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select JogaService.svc or JogaService.svc.cs at the Solution Explorer and start debugging.
    public class JogaService : IJogaService
    {
        public CartaCollection ObterCartas(Mesa mesa, Jogador jogador)
        {
            throw new NotImplementedException();
        }

        public bool Jogar(Mesa mesa, Jogador jogador, Carta atributo)
        {
            throw new NotImplementedException();
        }

        public Jogada KeepAlive(Mesa mesa, Jogador jogador)
        {
            throw new NotImplementedException();
        }
    }
}
