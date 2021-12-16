using Microsoft.AspNetCore.Mvc;
using ChallengeFriendsList1.Models;
using System.Collections.Generic;
using ChallengeFriendsList1.Services;

namespace ChallengeFriendsList1.Controllers
{
        public class FriendController : Controller
        {    
            IListOfFriends _listOfFriends;

        //Inject service into controller
        public FriendController(IListOfFriends listOfFriends) //catches the service arguments
        {
            //Dependency Injection
            _listOfFriends = listOfFriends;
        }

        //Read Friend
          public IActionResult Index()
        {
            return View(_listOfFriends);
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

        //Update Friend
        public IActionResult FriendsDetail (int id)
        {
            Friend friend = _listOfFriends.getFriendById(id);
            return View(friend);
        }

        [HttpPost]
        public IActionResult Edit(Friend model)
        {
            if (ModelState.IsValid)
            {
                Friend friend = _listOfFriends.getFriendById(model.id);
                friend.id = model.id;
                friend.friendName = model.friendName;
                friend.age = model.age;
                friend.occupation = model.occupation;
                friend.place = model.place;
                friend.sport = model.sport;
            }

            return View();
        }

        public IActionResult Details(int id)
        {
            Friend friend = _listOfFriends.getFriendById(id);
            return View(friend);
        }

        //Delete Friend
        public IActionResult DeleteFriend(int id)
        {
            _listOfFriends.getFriendById(id);
            return RedirectToAction("Index");
        }
    }
}
