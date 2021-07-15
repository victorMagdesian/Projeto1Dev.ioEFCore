using System;
using System.ComponentModel.DataAnnotations;

namespace DEVIO.PrimeiroProjeto.Models
{
    public class Pedido
    {
        [Key]
        public Guid Id { get; set; }

        public Pedido()
        {
            Id = Guid.NewGuid();
        }
        
    }
}