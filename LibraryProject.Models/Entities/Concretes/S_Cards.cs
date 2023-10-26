using LibraryProject.Models.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Models.Entities.Concretes
{
    public class S_Cards:BaseEntity
    {
        public int StudentsId { get; set; }
        public int BookId { get; set; }
        public int LibsId { get; set; }

        //Navigation
        public Students StudentsIdNavigation { get; set; } = null!;
        public Book BookIdNavigation { get; set; } = null!;
        public Libs LibsIdNavigation { get; set; } = null!;
    }
}
