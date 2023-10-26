using LibraryProject.Models.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Models.Entities.Concretes
{
    public class Departments:BaseEntity
    {
        public string Name { get; set; }

        //Navigation properties
        public ICollection<Teachers> Teachers { get; set; } = null!;
    }
}
