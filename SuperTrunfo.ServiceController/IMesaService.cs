﻿using SuperTrunfo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SuperTrunfo.ServiceController
{
    [ServiceContract]
    interface IMesaService
    {
        [OperationContract]
        Mesa CriarMesa();

        [OperationContract]
        MesaCollection ObterMesa();

        [OperationContract]
        void KeepAliveMesa(Jogador jogador, Mesa mesa);

        [OperationContract]
        bool EntrarMesa(Jogador jogador, Mesa mesa);
    }
}
