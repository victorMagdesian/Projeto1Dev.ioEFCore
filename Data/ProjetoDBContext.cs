using DEVIO.PrimeiroProjeto.Models;
using Microsoft.EntityFrameworkCore;

namespace DEVIO.PrimeiroProjeto.Data
{
    public class ProjetoDBContext : DbContext
    {
        public ProjetoDBContext(DbContextOptions<ProjetoDBContext> options)
        : base(options)
        {

        }

        public Pedido ObterPedido()
        {
            return new Pedido();
        }

            public DbSet<Pedido> Pedidos { get; set; }
    }


}
