using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mvc4App1.Controllers;
using Student.Interface;
using Moq;
using System.Web.Mvc;
namespace Mvc4App1.Tests.Controllers
{
    [TestClass]
    public class StudentControllerTest
    {
        [TestMethod]
        public void Index()
        {
            //arrange


            var mockRep = new Mock<IFeesCalculator>();

            mockRep.Setup(x => x.CalculateFees(1));

            var controller = new StudentController(mockRep.Object);

            var result = controller.Index() as ActionResult;

            Assert.IsNotNull(result);

        }

    }
}
