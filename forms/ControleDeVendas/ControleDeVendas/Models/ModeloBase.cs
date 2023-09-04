using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeVendas.Models
{
    public class ModeloBase
    {
        public int Id { get; set; }

        public DateTime CriadoEm { get; set;  }

        public DateTime AtualizadoEm { get; set; }
    }
}
