﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidades
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha{ get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        
        

        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
