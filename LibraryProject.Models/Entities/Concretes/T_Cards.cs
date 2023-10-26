using LibraryProject.Models.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Models.Entities.Concretes
{
    public class T_Cards : BaseEntity
    {
        public int TeacherId { get; set; }
        public int BookId { get; set; }
        public int LibId { get; set; }

        //Navigation Property
        public Teachers TeacherIdNavigation { get; set; } = null!;
        public Book BookIdNavigation { get; set; } = null!;
        public Libs Libs { get; set; } = null!;
    }
}
