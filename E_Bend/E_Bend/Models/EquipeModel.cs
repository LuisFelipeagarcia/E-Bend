using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace E_Bend.Models
{
    public class EquipeModel
    {
        [Key]
        [Display(Name ="ID: ")]
        public int Id { get; set; }
        [Required(ErrorMessage ="Insira o nome da equipe: ")]
        [Display(Name ="Nome: ")]
        public string Nome { get; set; }
        [Display(Name = "Disputas: ")]
        public int Disputas { get; set; }
        [Display(Name = "Vitórias: ")]
        public int Vitorias { get; set; }
        [Display(Name = "Derrotas: ")]
        public int Derrotas { get; set; }
        [Required(ErrorMessage ="Insira o ano em que a equipe foi fundada! ")]
        [Display(Name ="Ano de fundação: ")]
        public int Ano_Fund { get; set; }
        [Display(Name ="Ativo: ")]
        public bool Ativo { get; set; }
        
        public ICollection<DobradorModel> Dobrador { get; set; }

        
    }
}