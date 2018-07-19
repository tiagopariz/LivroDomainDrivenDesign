using Microsoft.VisualStudio.TestTools.UnitTesting;
using UmDesignDirigidoPorModelos.Domain.Models;

namespace UmDesignDirigidoPorModelos.Tests
{
    [TestClass]
    public class NetTests
    {
        [TestMethod]
        public void TestBusRuleAssignment()
        {
            var a0 = new Net("a0");
            var a1 = new Net("a1");
            var a = new Bus("a"); // Barra não é conceitualmente dependente
            a.AddNet(a0);         // do recoonhecimento baseado na nomenclatura e, po isso,
            a.AddNet(a0);         // seus testes não devem ser nenhum desses.
        }
    }
}
