using Interfaces;
using Interfaces.Interfaces;
using NSubstitute;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        //Testing PMB services
        [Test]
        public void TestingPMB()
        {
            ILService pmb = DemoFactoryDesign.GetServiceInstace(0);
            string expected = "PMB Services";

            var nsub = Substitute.For<ILService>();
            nsub.GetServiceName().Returns(expected);

            Assert.AreEqual(expected: expected, pmb.GetServiceName());
            Assert.That(nsub.GetServiceName(), Is.EqualTo("PMB Services"));
        }
        //Testing Dedicated services
        [Test]
        public void TestingDedicated()
        {
            ILService dedicated = DemoFactoryDesign.GetServiceInstace(1);
            string expected = "Dedicated Services";

            var nsub = Substitute.For<ILService>();
            nsub.GetServiceName().Returns(expected);

            Assert.AreEqual(expected: expected, dedicated.GetServiceName());
        }
        //Testing Generic services
        [Test]
        public void TestingGeneric()
        {
            ILService generic = DemoFactoryDesign.GetServiceInstace(3);
            string expected = "Generic Services";

            var nsub = Substitute.For<ILService>();
            nsub.GetServiceName().Returns(expected);

            Assert.AreEqual(expected: expected, generic.GetServiceName());
        }
    }
}