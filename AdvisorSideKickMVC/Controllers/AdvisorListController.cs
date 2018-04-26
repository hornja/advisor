using AdvisorSideKickMVC.Models;
using FindMyAdvisorMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdvisorSideKickMVC.Controllers
{
    public class AdvisorListController : Controller
    {
        AdvisorSidekickDb _db = new AdvisorSidekickDb();

        /// <summary>
        /// Creates ActionResult for AdvisorList
        /// </summary>
        /// <returns>View model</returns>
        [Authorize]
        public ActionResult Index()
        {
            //Local Variables
            List<AdvisorListViewModel> AdvisorListMod = new List<AdvisorListViewModel>();
            Student student = _db.Students.FirstOrDefault(st => st.Email == User.Identity.Name);
            List<Advisor> advisors = _db.Advisors.ToList();

            //Get every advisor for each department
            foreach (var department in student.Departments)
            {
                foreach (var adv in advisors)
                {
                    if (adv.DepartmentId == department.DepartmentId)
                    {
                        //Create view models
                        AdvisorListViewModel tempAdvMod = new AdvisorListViewModel(department, adv);
                        AdvisorListMod.Add(tempAdvMod);  
                    }
                }
            }
            return View("AdvisorListView", AdvisorListMod);
        }

        //public ActionResult AddAdvisor()
        //{
        //    //var model = _db.Advisors
        //    //    .Select(d => new AddAdvisorViewModel
        //    //    {
        //    //        DepartmentId = d.DepartmentId,
        //    //        DepartmentName = d.DepartmentName,
        //    //        SchoolName = d.SchoolName
        //    //    });
        //    //return View(model);
        //    AddAdvisorViewModel AddAdv = new AddAdvisorViewModel();
        //    return View("AddAdvisor", AddAdv);
        //}
    }
}