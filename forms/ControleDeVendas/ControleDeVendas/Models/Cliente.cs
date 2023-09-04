using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeVendas.Models
{
    public class Cliente:ModeloBase
    {
        public string Nome { get; set; } = string.Empty;

        public string Sobrenome { get; set; } = string.Empty;

        public string RG { get; set; } = string.Empty;

        public string CPF { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Telefone { get; set; } = string.Empty;

        public string Celular { get; set; } = string.Empty;

        public string CEP { get; set; } = string.Empty;

        public int IdBairro { get; set; } = 0;

        public int IdLogradouro { get; set; } = 0;

        public int IdMunicipio { get; set; } = 0;

        public int Numero { get; set; } = 0;

        public string Complemento { get; set; }

        public int idEstado { get; set; } = 0;
    }
}
