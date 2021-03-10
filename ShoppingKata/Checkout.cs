namespace ShoppingKata
{
    public class Checkout
    {
        public int TotalPrice = 0;
        public void Scan()
        {
            TotalPrice += 10;
        }
    }
}