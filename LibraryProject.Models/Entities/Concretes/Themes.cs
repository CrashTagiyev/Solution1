using LibraryProject.Models.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Models.Entities.Concretes
{
    public class Themes:BaseEntity
    {
        public string Name { get; set; }


        //Navigation
         public virtual ICollection<Book> Books { get; set; }
    }
}
