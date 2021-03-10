using Xunit;
namespace ShoppingKata.Tests.UntouchableTests
{
    public class GivenOneAppleIsScanned
    {
        [Fact]
        public void ThenTheTotalPriceIsTen()
        {
            var checkout = new Checkout();
            checkout.Scan();
            Assert.StrictEqual(10, checkout.TotalPrice);
        }
    }

}