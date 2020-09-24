using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Bend.Models
{
    public class DobradorModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Ano_Cad { get; set; }
        public string Elemento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public EquipeModel Equipe { get; set; }
    }
}