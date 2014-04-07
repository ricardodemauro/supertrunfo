using SuperTrunfo.Modelos;

namespace SuperTrunfo.ServiceController
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "JogaService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select JogaService.svc or JogaService.svc.cs at the Solution Explorer and start debugging.
    public class JogaService : IJogaService
    {
        public CartaCollection ObterCartas(Mesa mesa, Jogador jogador)
        {
            return new CartaCollection();
        }

        public bool Jogar(Mesa mesa, Jogador jogador, Carta atributo)
        {
            return true;
        }

        public Jogada KeepAlive(Mesa mesa, Jogador jogador)
        {
            return new Jogada();
        }
    }
}
