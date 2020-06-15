using BigSchool1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BigSchool1.Controllers
{
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;
        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Attend([FromBody] int courseId)
        {
            var attendance = new Attendance
            {
                CoureId = courseId,
                AttendeeId = User.Identity.GetUserId()
            };
            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();
            return OK();
        }

    }
}
