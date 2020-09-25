using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Bend.Models
{
    public class DobradorModel
    {
        [Key]
        [Display(Name ="ID: ")]
        public int Id { get; set; }
        [Required(ErrorMessage ="Informe o nome do Dobrador: ")]
        [Display(Name ="Nome: ")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="Informe o ano de Cadastro: ")]
        [Display(Name ="Cadastro: ")]
        public int Ano_Cad { get; set; }
        [Required(ErrorMessage ="Informe o elemento de dobra: ")]
        [Display(Name ="Elemento: ")]
        public string Elemento { get; set; }
        [Display(Name ="Telefone: ")]
        public string Telefone { get; set; }
        [EmailAddress(ErrorMessage ="Insira um email válido!")]
        [Display(Name ="Email: ")]
        public string Email { get; set; }
        public EquipeModel Equipe { get; set; }

        public int? EquipeId { get; set; }
    }
}