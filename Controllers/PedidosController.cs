using System;
using DEVIO.PrimeiroProjeto.Data;
using Microsoft.AspNetCore.Mvc;

namespace DEVIO.PrimeiroProjeto.Controllers
{
    public class PedidosController : Controller
    {
        private readonly ProjetoDBContext PedidosContext;

        public PedidosController(ProjetoDBContext pedidosContext)
        {
            PedidosContext = pedidosContext;
        }

        [Route("pedidos")]
        public IActionResult Index()
        {
            var pedido = PedidosContext.ObterPedido();
            
            PedidosContext.Pedidos.Add(pedido);
            PedidosContext.SaveChanges();

            var teste = PedidosContext.Pedidos.Find(pedido.Id); 
            

            return View();
        }
    }
}