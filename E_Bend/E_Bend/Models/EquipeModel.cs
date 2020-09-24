using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace E_Bend.Models
{
    public class EquipeModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Disputas { get; set; }
        public int Vitorias { get; set; }
        public int Derrotas { get; set; }
        public int Ano_Fund { get; set; }
        public bool Ativo { get; set; }
        public ICollection<DobradorModel> Dobrador { get; set; }
    }
}