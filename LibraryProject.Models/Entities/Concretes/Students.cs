using LibraryProject.Models.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Models.Entities.Concretes
{
    public class Students:BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public int GroupsId { get; set; }

        public virtual Groups GroupsIdNavigation { get; set; }
    }
}
