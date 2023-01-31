using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {   
        [Key]
        public int Id { get; set; }

        [Display(Name ="Profile Picture URL")]
        [Required(ErrorMessage ="Profile picture required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name required")]
        [StringLength(50,MinimumLength =3, ErrorMessage ="Full name length between 3 and 50")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography required")]
        public string Bio { get; set; }

        //Relationship
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
