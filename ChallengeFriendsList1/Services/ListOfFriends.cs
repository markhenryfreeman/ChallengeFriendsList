using ChallengeFriendsList1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ChallengeFriendsList1.Services
{
    public class ListOfFriends
    {
        public List<Friend> listOfFriends { get; set; }

        public ListOfFriends()
        {
            InitializedListOfFriends
        }

    }
}
