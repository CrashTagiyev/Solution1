using LibraryProject.Models.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Models.Entities.Concretes
{
    public class SCards:BaseEntity
    {
        public int StudentsId { get; set; }
        public int BookId { get; set; }
        public int LibsId { get; set; }


        public virtual Students StudentsIdNavigation { get; set; }
        public virtual Book BookIdNavigation { get; set; }
        public virtual Libs LibsIdNavigation { get; set; }
    }
}
