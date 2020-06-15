using BigSchool1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BigSchool1.Controllers
{
    public class FollwingsController : ApiController
    {
        private readonly ApplicationDbContext _dbContext;
        public FollwingsController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Follow(FollowingDto followingDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Following.Any(f => f.FollowerId == userId && f.FolloweeId == followingDto.FolloweeId))
                return BadRequest("Follwing already exists!");
            var folowing = new Following
            {
                FollwerId = userId,
                FollweeId = followingDto.FolloweeId
            };
            _dbContext.Following.Add(folowing);
            _dbContext.SaveChanges();
        }
    }
}
