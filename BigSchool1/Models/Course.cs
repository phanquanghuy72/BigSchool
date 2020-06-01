using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool1.Models
{
    public class Course
    {
        internal string LecturerId;

        public int Id { get; set; }
        public ApplicationUser Lecturer { get; set; }
        [Required]
        [StringLength(255)]
        public string Place { get; set; }
        public DateTime Datetime { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }
    }
}