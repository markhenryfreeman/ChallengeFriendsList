using Microsoft.AspNetCore.Mvc;
using ChallengeFriendsList1.Models;
using System.Collections.Generic;

namespace ChallengeFriendsList1.Controllers
{
    public class FriendController : Controller
    {

        public IActionResult Index()
        {
            List<Friend> FriendsList = new List<Friend>()
            {
                new Friend() {FriendID = 1, FriendName = "John", Place = "Boston"},
                new Friend() {FriendID = 2, FriendName = "Mike", Place = "Austin"},
                new Friend() {FriendID = 3, FriendName = "Steve", Place = "Houston"}
            };

            ListOfFriends ActualList = new ListOfFriends();
            ActualList.listOfFriends = FriendsList;

            return View(ActualList);
        }
        [HttpGet]
        public IActionResult InsertNewFriend()
        {
            return View();
        }
        [HttpPost]
        public IActionResult InsertNewFriend(Friend friend)
        {
            return View();
        }

    }
}
