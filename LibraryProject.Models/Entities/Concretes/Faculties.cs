using LibraryProject.Models.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Models.Entities.Concretes
{
    public class Faculties : BaseEntity
    {
        public string Name { get; set; }

        //navigation
        public virtual ICollection<Departments> departments { get; set; }
    }
}
