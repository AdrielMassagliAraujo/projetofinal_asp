using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projeto2.Models
{
    public class persona
    {

        [Display(Name = "Nome do Personagem:")]
        [Required(ErrorMessage = "obrigatório")]
        public String NomePersona { get; set; }

        [Display(Name = "Idade do Personagem:")]
        [Required(ErrorMessage = "obrigatório")]
        public String Idade { get; set; }

        [Display(Name = "Personalidade:")]
        [Required(ErrorMessage = "obrigatório")]
        [StringLength(80, MinimumLength = 15, ErrorMessage = "Insira de 15 a 80 caracteres")]
        public String Personalidade { get; set; }

        [Display(Name = "Frase mais dita:")]
        [Required(ErrorMessage = "obrigatório")]
        [StringLength(80, MinimumLength = 15, ErrorMessage = "Insira de 15 a 80 caracteres")]
        public String Frase { get; set; }

        [Display(Name = "Nome do Ator:")]
        [Required(ErrorMessage = "obrigatório")]
        public String NomeAtor { get; set; }

        [Display(Name = "Idade do Ator:")]
        [Required(ErrorMessage = "obrigatório")]
        public String IdadeAtor { get; set; }




    }
}