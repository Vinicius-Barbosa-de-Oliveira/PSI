using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelo.Cadastros
{
    public class Fabricante
    {
        public long FabricanteId { get; set; }
        public string nome { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}