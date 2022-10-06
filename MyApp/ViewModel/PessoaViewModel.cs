using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MyApp.DomainModel.Validators;


namespace MyApp.ViewModel
{
    public class PessoaViewModel
    {
        public int Cod { get; set; }

        [Display(Name = "Nome")]
        [Required]
        [MinLength(5, ErrorMessage = "The {0} must be at least {1} characters long.")]
        [LetterPValidator('P', ErrorMessage = "{0} must contain the letter {1}")]
        public string Name { get; set; }

        [Display(Name = "Pais")]
        public string Pais { get; set; }

        [Display(Name = "Age")]
        [Required]
        [Range(1, 140, ErrorMessage = "The {0} must be between {1} and {2}")]
        public int Age { get; set; }

        public string PhotoName { get; set; }

        [Display(Name = "Foto")]
        public HttpPostedFileBase Photo { get; set; }

        public List<AnimalViewModel> Animals { get; set; }
    }
}