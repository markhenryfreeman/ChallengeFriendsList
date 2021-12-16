using System.ComponentModel.DataAnnotations;

namespace ChallengeFriendsList1.Models
{
    public class Friend
    {
        [Display(Name = "ID: ")]
        [Required(ErrorMessage = "You must enter an ID.")]
        public int id { get; set; }

        [Display(Name = "Name: ")]
        [Required(ErrorMessage = "You must enter a name.")]
        public string friendName { get; set; }

        [Display(Name = "Place: ")]
        [StringLength(25)]
        public string place { get; set; }

        [Display(Name = "Age: ")]
        public int age { get; set; }

        [Display(Name = "Occupation: ")]
        [Required(ErrorMessage = "You must enter an ID.")]
        public string occupation { get; set; }

        [Display(Name = "Favorite Sport: ")]
        [Required(ErrorMessage = "You must enter an ID.")]
        public string sport { get; set; }
    }
}
