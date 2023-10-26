using LibraryProject.Models.Entities.Abstracts;

namespace LibraryProject.Models.Entities.Concretes
{
    public class Groups:BaseEntity
    {
        public string Name { get; set; }
        public int FacultiesId { get; set; }

        //Navigation property
        public Faculties FacultiesIdNavigation { get; set; } = null!;
    }
}
