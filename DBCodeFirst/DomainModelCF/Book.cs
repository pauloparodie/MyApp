using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
//ertert
namespace DBCodeFirst
{
    //bb
    /aa
    //erterter
    [Table("Book", Schema = "dbo")]
    public class Book
    {
        [Column("Cod")]
        [Key]
        public int Cod { get; set; }
//sdfsd
        [Column("Title",TypeName = "varchar(max)")]
        public string Title { get; set; }
        ///sdfsdf
    
        public int AuthorId { get; set; }
//sdfsdf
        //dgdfgdfg
        [ForeignKey("AuthorId")]
        public virtual Author Author  { get; set; }
        //sdfsdf
    }
}
