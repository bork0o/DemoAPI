using NetCoreDemoAPI.Controllers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreDemoAPITests.ControllersTests
{
    [TestFixture]
    public class ValuesControllerTest
    {
        protected ValuesController controller { get; private set; }

        [SetUp]
        public virtual void SetUp()
        {
            this.controller = new ValuesController();
        }

        [TestCase(2)]
        public void AssertAreEqual(int id)
        {
            Assert.That(id, Is.Not.Null);
            var value = controller.Get(id);
            Assert.AreEqual(value, "value");
        }
    }
}
