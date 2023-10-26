using LibraryProject.Models.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryProject.Models.Entities.Concretes
{
    public class Students:BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int GroupId { get; set; }
        public int Term { get; set; }

        //Navigation Property
        public Group GroupIdNavigation { get; set; } = null!;
    }
}
