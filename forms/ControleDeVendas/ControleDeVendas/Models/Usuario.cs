using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeVendas.Models
{
    public class Usuario: ModeloBase
    {
        public string Nome { get; set; } = string.Empty;

        public string NomeUsuario { get; set; } = string.Empty;

        public string Credencial { get; set; } = string.Empty;

    }
}
