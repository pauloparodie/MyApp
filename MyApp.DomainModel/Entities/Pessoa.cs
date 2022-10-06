using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MyApp.DomainModel.Validators;


namespace MyApp.DomainModel.Entities
{
    public class Pessoa
    {
        public Pessoa()
        {
            this.Animals = new List<Animal>();
        }

        [Key]
        public int Cod { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "The {0} must be at least {1} characters long.")]
        [LetterPValidator('P', ErrorMessage = "{0} must contain the letter {1}")]
        public string Name { get; set; }
        [Required]
        [Range(1, 140, ErrorMessage = "The {0} must be between {1} and {2}")]
        public int Age { get; set; }
        public string Pais { get; set; }
        public string PhotoName { get; set; }

        public virtual List<Animal> Animals { get; set; }
    }
}
