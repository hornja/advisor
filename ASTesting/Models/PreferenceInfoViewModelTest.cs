using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdvisorSideKickMVC.Models;

namespace ASTesting.Models
{
    [TestClass]
    public class PreferenceInfoViewModelTest
    {
        [TestMethod]
        public void ShouldSetAttributesForViewModel()
        {
            string testSchoolName = "Milligan";
            string testDepartmentName = "Nursing";
            int testAdvisorCount = 8;

            var sut = new PreferenceInfoViewModel(testSchoolName, testDepartmentName, testAdvisorCount);

            Assert.AreEqual(testSchoolName, sut.SchoolName);
            Assert.AreEqual(testDepartmentName, sut.DepartmentName);
            Assert.AreEqual(testAdvisorCount, sut.AdvisorCount);
        }
    }
}
