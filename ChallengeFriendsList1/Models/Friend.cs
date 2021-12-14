using System.ComponentModel.DataAnnotations;

namespace ChallengeFriendsList1.Models
{
    public class Friend
    {
        [Display(Name = "Type Id: ")]
        [Required(ErrorMessage = "You must enter an ID.")]
        public int FriendID { get; set; }

        [Display(Name = "Type Name: ")]
        [Required(ErrorMessage = "You must enter a name.")]
        public string FriendName { get; set; }

        [Display(Name = "Type Location of friend: ")]
        [StringLength(25)]
        public string Place { get; set; }

        public int age { get; set; }
        public string occupation { get; set; }
        public string favoriteSport { get; set; }
    }
}
