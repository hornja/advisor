using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdvisorSideKickMVC.Models;

namespace ASTesting.Models
{
    [TestClass]
    public class AddPreferenceTest
    {
        [TestMethod]
        public void ShouldSetAttributesForViewModel()
        {
            int testDepartmentId = "1";
            string testDepartmentName = "History";
			string testSchoolName = "Virginia Tech"

            var sut = new AddPreferenceViewModel(testDepartmentId, testDepartmentName, testSchoolName);

            Assert.AreEqual(testDepartmentId, sut.DepartmentId);
            Assert.AreEqual(testDepartmentName, sut.DepartmentName);
			Assert.AreEqual(testSchoolName, sut.SchoolName)
        }
    }
}
