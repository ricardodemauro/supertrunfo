using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SuperTrunfo.Modelos;

namespace SuperTrunfo.ServiceController
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MesaService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MesaService.svc or MesaService.svc.cs at the Solution Explorer and start debugging.
    public class MesaService : IMesaService
    {
        public Mesa CriarMesa()
        {
            throw new NotImplementedException();
        }

        public MesaCollection ObterMesa()
        {
            throw new NotImplementedException();
        }

        public void KeepAliveMesa(Jogador jogador, Mesa mesa)
        {
            throw new NotImplementedException();
        }

        public bool EntrarMesa(Jogador jogador, Mesa mesa)
        {
            throw new NotImplementedException();
        }
    }
}
