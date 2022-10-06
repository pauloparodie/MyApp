using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace MyApp.DomainModel.Entities
{
    public class Animal
    {
        [Key]
        public int Cod { get; set; }
        [Required]
        public string Name { get; set; }
        public string Raca { get; set; }
        public Nullable<int> DonoCod { get; set; }

        [ForeignKey("DonoCod")]
        public virtual Pessoa Dono { get; set; }
    }
}
