using DEVIO.PrimeiroProjeto.Models;

namespace DEVIO.PrimeiroProjeto.Data
{
    public class PedidoRepository : IPedidoRepository
    {
        
        public Pedido ObterPedido()
        {
            return new Pedido();
        }

    }

    public interface IPedidoRepository
    {
        Pedido ObterPedido();
    }
}