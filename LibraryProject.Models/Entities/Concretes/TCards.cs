using LibraryProject.Models.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Models.Entities.Concretes
{
    public class TCards:BaseEntity
    {
        public int TeachersId { get; set; }
        public int  BookId { get; set; }
        public int LibsId { get; set; }

        public virtual Teachers TeachersIdNavigation { get; set; }
        public virtual Book BookIdNavigation { get; set; }
        public virtual Libs LibsIdNavigation { get; set; }
    }
}
