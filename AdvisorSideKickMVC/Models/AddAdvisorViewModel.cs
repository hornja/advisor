using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdvisorSideKickMVC.Models
{
    public class AddAdvisorViewModel
    {
        public Department Dept { get; set; }
        public Advisor AdvisorListEntry { get; set; }

        public AddAdvisorViewModel()
        {
        }

        public AddAdvisorViewModel(Department dpt, Advisor adv)
        {
            Dept = dpt;
            AdvisorListEntry = adv;
        }


    }
}