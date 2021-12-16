using ChallengeFriendsList1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeFriendsList1.Services
{
    public class ListOfFriends: IListOfFriends
    {
        public List<Friend> listOfFriends { get; set; }

        public ListOfFriends()
        {
            InitializeListOfFriends();
        }

        public void InitializeListOfFriends()
        {
            listOfFriends = new List<Friend>()
            {
                new Friend(){id = 1, friendName = "John", place = "Texas", age = 23, occupation = "Engineer", sport = "Baseball"},
                new Friend(){id = 2, friendName = "Leo", place = "New York", age = 30, occupation = "Lawyer", sport = "Football"},
                new Friend(){id = 3, friendName = "Jane", place = "California", age = 28, occupation = "Doctor", sport = "Soccer"},
            };
        }

        public Friend getFriendById(int id) 
        {
            Friend friend = this.listOfFriends.FirstOrDefault(friend => friend.id == id);
            return friend;
        }

        public void deleteFriendById(int id)
        {
            Friend friend = getFriendById(id);
            this.listOfFriends.Remove(friend);
        }

    }
}
