using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Value_Objects;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var name = new Name("Teste", "Teste");
            foreach (var not in name.Notifications)
            {
                // not.Message;
            }
        }
    }
}