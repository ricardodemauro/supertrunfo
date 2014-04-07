﻿using SuperTrunfo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SuperTrunfo.Service
{
    [ServiceContract]
    public interface IJogar
    {
        [OperationContract]
        CartaCollection ObterCartas(Mesa mesa, Jogador jogador);

        [OperationContract]
        bool Jogar(Mesa mesa, Jogador jogador, Carta atributo);

        [OperationContract]
        Jogada KeepAlive(Mesa mesa, Jogador jogador);
    }
}
