namespace RUM3_Inventory
{
    /**
    * Dagens uppgift:
    * Skapa en klass Product med id (readonly), name, etc..
    * Skapa en klass Inventory med array av produkter.
    * Inventory ska ha metoderna:
    * AddProduct(Product product)
    * GetProductByIndex(int index)
    * GetProductById(int id)
    * GetProductByName(string name)
    */
    internal class Inventory
    {
        private int lastIndex = 0;
        private static Product[] products;

        public Inventory(int inventorySize)
        {
            products = new Product[inventorySize];
        }

        public void AddProduct(Product product)
        {
            if (lastIndex < products.Length)
            {
                products[lastIndex] = product;
                lastIndex++;
            }
            else
            {
                Console.WriteLine("Inventory full");
                Console.Write("\nPress ENTER to continue...");
                Console.ReadLine();
            }
        }

        public string GetProductByIndex(int index)
        {
            if (index < products.Length)
            {
                return products[index].GetProductInfo();
            }
            return "Index out of range";
        }

        public string GetProductById(int id)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Id == id)
                {
                    return products[i].GetProductInfo();
                }
            }
            return "Product not found";
        }

        public string GetProductByName(string name)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].GetName() == name)
                {
                    return products[i].GetProductInfo();
                }
            }
            return "Product not found";
        }
    }
}
