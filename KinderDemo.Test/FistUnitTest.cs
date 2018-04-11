using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KinderDemo.Test
{
    [TestClass]
    public class FistUnitTest
    {
        [TestMethod]
        public void FirstTestMethod()
        {
            var viewModel = new MainViewModel();

            var expectedMainText = "Kinder Demo";

            Assert.AreEqual(expectedMainText, viewModel.MainText);
        }
    }
}
