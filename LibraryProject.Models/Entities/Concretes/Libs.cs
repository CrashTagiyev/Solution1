using LibraryProject.Models.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Models.Entities.Concretes
{
    public class Libs:BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        //navigation
        public ICollection<S_Cards> Scards { get; set; } = null!;
        public ICollection<T_Cards> Tcards { get; set; } = null!;
    }
}
