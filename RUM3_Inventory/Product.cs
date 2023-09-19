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
    internal class Product
    {
        private readonly int id;
        private string Name { get; set; }

        public Product(int id, string name)
        {
            this.id = id;
            Name = name;
        }

        public string GetName() { return Name; }

        public int Id { get { return id; } }

        public string GetProductInfo()
        {
            return $"Name: {Name} ID: {Id}";
        }
    }
}
