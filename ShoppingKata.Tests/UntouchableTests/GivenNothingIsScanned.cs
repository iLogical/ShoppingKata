using Xunit;
namespace ShoppingKata.Tests.UntouchableTests
{
    public class GivenNothingIsScanned
    {
        [Fact]
        public void ThenTheTotalPriceIsZero()
        {
            var checkout = new Checkout();
            Assert.StrictEqual(0, checkout.TotalPrice);
        }
    }
}