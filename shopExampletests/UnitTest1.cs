using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebSales.Models;
using Moq;

namespace shopExampletests
{
    [TestClass]
    public class UnitTest1
    {
        private Mock<IStockEngine> _stockMock;

        [TestMethod]
        public void ProcessSale_ItemExists_ReturnsCorrectDiscount()
        {
            //arrange
            _stockMock = new Mock<IStockEngine>();
            _stockMock.Setup(x => x.LookupItem(1)).Returns( new StockData {Cost = 0.99M} );
            
            //act
            var subject = new SalesProcessor(_stockMock.Object);
            var result = subject.ProcessSale(1);

            //assert
            Assert.AreEqual((0.99M * 0.75M), result);
            Assert.AreEqual(1, _stockMock.Invocations.Count);
        }
    }
}
