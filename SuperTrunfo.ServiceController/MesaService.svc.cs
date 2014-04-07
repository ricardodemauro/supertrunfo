using SuperTrunfo.Modelos;

namespace SuperTrunfo.ServiceController
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MesaService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MesaService.svc or MesaService.svc.cs at the Solution Explorer and start debugging.
    public class MesaService : IMesaService
    {
        public Mesa CriarMesa()
        {
            return new Mesa();
        }

        public MesaCollection ObterMesa()
        {
            return new MesaCollection();
        }

        public void KeepAliveMesa(Jogador jogador, Mesa mesa)
        {
        }

        public bool EntrarMesa(Jogador jogador, Mesa mesa)
        {
            return true;
        }
    }
}
