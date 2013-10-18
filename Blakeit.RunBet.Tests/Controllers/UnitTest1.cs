using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Blakeit.RunBet.Controllers;

namespace Blakeit.RunBet.Tests.Controllers
{
    [TestClass]
    public class RunnersControllerTests
    {
        [TestMethod]
        public void CanGetAListOfRunners()
        {
            var runners = new RunnersController().GetRunners();
            Assert.AreEqual(1, runners.Count);
        }

        [TestMethod]
        public void CanPlaceABet()
        {
            var id = 1;// "mblake";
            var span = new TimeSpan(1, 35, 45);
            var vm = new RunnersController().MakeBet(id, span);
            
        }
    }
}
