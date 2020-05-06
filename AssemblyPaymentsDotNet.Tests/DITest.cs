using NUnit.Framework;
using AssemblyPaymentsDotNet.DI;
using AssemblyPaymentsDotNet.Interfaces;
using Unity;

namespace AssemblyPaymentsDotNet.Tests
{
    public class DITest
    {
        [Test]
        public void TestDIContainer()
        {
            var container = new UnityContainer();
            InitUnityContainer.Init(container);
            var userService = container.Resolve<IUserRepository>();
            Assert.IsNotNull(userService);
        }
    }
}
