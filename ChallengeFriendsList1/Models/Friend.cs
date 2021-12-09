using System.ComponentModel.DataAnnotations;

namespace ChallengeFriendsList1.Models
{
    public class Friend
    {
        [Required(ErrorMessage = "You must enter an ID.")]
        public int FriendID { get; set; }
        [Required(ErrorMessage = "You must enter a name.")]
        public string FriendName { get; set; }
        [StringLength(25)]
        public string Place { get; set; }
    }
}
