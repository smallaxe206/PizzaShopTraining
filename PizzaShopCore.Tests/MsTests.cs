using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PizzaShopCore.Tests
{
    [TestClass]
    public class MsTests
    {
        [TestMethod]
        public void SampleTestMethod()
        {
            Assert.Fail("It's not implemented, silly.");
        }


        [TestMethod]
        public void ReturnAPizza()
        {
            //ARRANGE
            IPizza subjectUnderTest = new Pizza();
            
            //ACT
            subjectUnderTest.Create();

            //ASSERT
            Assert.IsTrue(subjectUnderTest.IsCreated);
        }
    }

    public class Pizza : IPizza
    {
	    public bool IsCreated { get; set; }

	    public void Create()
	    {
		    IsCreated = true;
	    }

    }

    public interface IPizza
    {
	    bool IsCreated { get; set; }

	    void Create();
    }
}
