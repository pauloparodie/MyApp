using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
/*teste*/
namespace DBCodeFirst
{
    [Table("Author",Schema ="dbo")]
    public class Author
    {
        //aa
	    /*sdfs*/
	    /*dfsd*/
	    //dfgdf
	    //sdfs
        public Author()
        {
		//ddfg
		//dfdf
		//sdftgdrt
			int were=1;
            Books = new List<Book>();
        }

        [Column("Cod")]
        [Key]
        public int Cod { get; set; }

        [Column("Name", TypeName = "varchar(max)")]
        public string Name { get; set; }

        [Column("Age")]
        public Nullable<int> Age { get; set; }

        [Column("AgeRequired", TypeName = "int")]
        [Required]
        public int AgeRequired { get; set; }

        [Column("Country")]
        public string Country { get; set; }


        public virtual List<Book> Books { get; set; }
    }
}
