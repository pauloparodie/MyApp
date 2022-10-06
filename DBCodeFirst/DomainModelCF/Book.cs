using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DBCodeFirst
{//erterter
    [Table("Book", Schema = "dbo")]
    public class Book
    {
        [Column("Cod")]
        [Key]
        public int Cod { get; set; }

        [Column("Title",TypeName = "varchar(max)")]//dfgdfgd
        public string Title { get; set; }
    
        public int AuthorId { get; set; }

        [ForeignKey("AuthorId")]//sfgdfg
        public virtual Author Author  { get; set; }
    }
}
