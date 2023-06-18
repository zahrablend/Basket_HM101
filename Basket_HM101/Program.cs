    /*
    Create console application where you imitate shopping basket. 
    You should be able to add, remove or list items. 
    Your should know the total of the basket. Use OOP. 
    Create at least 3 different types of products.
     */


namespace Basket_HM101
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            // Create new cart
            var cart = new Cart(1);

            // Create products
            var moisturizer = new Moisturizer(1, 15)
            {
                Brand = "Oriflame",
                SkinType = SkinType.Mature,
                Description = "Moisturizer for mature skin"
            };

            var conditioner = new Conditioner(2, 6)
            {
                Brand = "Olay",
                HairType = HairType.Thin,
                Description = "Conditioner for thin hair"
            };

            var bodyMilk = new BodyMilk(3, 7)
            {
                Brand = "Oriflame",
                SkinType = SkinType.Normal,
                Description = "Body milk for normal skin"
            };
        }
    }
}