using Xunit;
namespace ShoppingKata.Tests.UntouchableTests
{
    public class GivenTwoApplesAreScanned
    {
        [Fact]
        public void ThenTheTotalPriceIsTwenty()
        {
            var checkout = new Checkout();
            checkout.Scan();
            checkout.Scan();
            Assert.StrictEqual(20, checkout.TotalPrice);
        }
    }
}