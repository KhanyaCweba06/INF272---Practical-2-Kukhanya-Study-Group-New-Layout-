using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace INF272___Practical_2__Kukhanya_Study_Group_New_Layout_.Models
{
    public class StudyGroupPeople
    {
        [Display(Name = "Student Number")]
        public string StudentNumber { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Link To Personal Page")]
        public string MyLink { get; set; }
    }
}