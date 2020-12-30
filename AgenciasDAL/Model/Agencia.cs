using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciasDAL.Model
{
    public class Agencia
    {
        public Guid Id { get; set; }
        public string Numero { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public override string ToString() =>
            $"{Numero} - {Nome}".Trim();
    }
}
