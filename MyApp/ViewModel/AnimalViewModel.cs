using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyApp.ViewModel
{
    public class AnimalViewModel
    {
        public int Cod { get; set; }

        public string Name { get; set; }

        public string Raca { get; set; }

        public PessoaViewModel Dono { get; set; }
    }
}
