using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace INF272___Practical_2__Kukhanya_Study_Group_New_Layout_.Controllers
{
    public class StudyGroupPeopleController : Controller
    {
        // GET: StudyGroupPeople
        public ActionResult People()
        {
            List<Models.StudyGroupPeople> People = new List<Models.StudyGroupPeople>();

            People.Add(new Models.StudyGroupPeople { StudentNumber = "u21598569", Name = "Kukhanya", Surname = "Cweba", EmailAddress = "u21598569@tuks.co.za", MyLink = "~/HTML/Kukhanya.html" });
            People.Add(new Models.StudyGroupPeople { StudentNumber = "u24765347", Name = "John", Surname = "Devereux", EmailAddress = "u24765347@tuks.co.za", MyLink = "~/HTML/John.html" });
            People.Add(new Models.StudyGroupPeople { StudentNumber = "u22765432", Name = "Kevin", Surname = "Knox", EmailAddress = "u22765432@tuks.co.za", MyLink = "~/HTML/Kevin.html" });
            People.Add(new Models.StudyGroupPeople { StudentNumber = "u19876543", Name = "Joyce", Surname = "Hendricks", EmailAddress = "u19876543@tuks.co.za", MyLink = "~/HTML/Joyce.html" });
            People.Add(new Models.StudyGroupPeople { StudentNumber = "u23145676", Name = "Benjamin", Surname = "Fournier", EmailAddress = "u23145676@tuks.co.za", MyLink = "~/HTML/Benjamin.html" });

            return View(People);
        }
    }
}