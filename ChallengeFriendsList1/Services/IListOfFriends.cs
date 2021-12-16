using ChallengeFriendsList1.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeFriendsList1.Services


{
    public interface IListOfFriends
    {
        public List<Friend> listOfFriends { get; set; }
        public void InitializeListOfFriends();
        public Friend getFriendById(int id);
        public void deleteFriendById(int id);
    }
}