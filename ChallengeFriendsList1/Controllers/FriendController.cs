using Microsoft.AspNetCore.Mvc;
using ChallengeFriendsList1.Models;
using System.Collections.Generic;
using ChallengeFriendsList1.Services;

namespace ChallengeFriendsList1.Controllers
{
        public class FriendController : Controller
        {    
            IListOfFriends _listOfFriends;

        public FriendController(IListOfFriends myListService)
        {
            _listOfFriends = myListService;
        }

          public IActionResult Index()
        {

            List<Friend> friendsList = new List<Friend>()
            {
                new Friend() {FriendID = 1, FriendName = "John", Place = "Boston"},
                new Friend() {FriendID = 2, FriendName = "Mike", Place = "Austin"},
                new Friend() {FriendID = 3, FriendName = "Steve", Place = "Houston"}
            };   

            ListOfFriends ActualList = new ListOfFriends();
            ActualList.listOfFriends = friendsList;

            return View(ActualList);
        }
        [HttpGet]
        public IActionResult InsertNewFriend()
        {
            return View();
        }

        // CREATE FRIENDS
        [HttpPost]
        public IActionResult InsertNewFriend(Friend friend)
        {
            if (ModelState.IsValid)
            {
                _listOfFriends.listOfFriends.Add(friend);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult FriendsDetail (int id)
        {
            Friend friend = _listOfFriends.getFriendById(id);
            return View(friend);
        }

        public IActionResult DeleteFriend(int id)
        {
            Friend friend = _listOfFriends.getFriendById(id);
            _listOfFriends.listOfFriends.Remove(friend);
            return RedirectToAction("Index");
        }

        public IActionResult EditFriend(int id)
        {
            Friend friend = _listOfFriends.getFriendsById(id);
            return View(friend);
        }

        [HttpPost]
        public IActionResult EditFriend(Friend friend)
        {
            Friend backupOffriend = _listOfFriends.getFriendById(friend.FriendID);
            _listOfFriends
            return View(friend);
        }
    }
}
