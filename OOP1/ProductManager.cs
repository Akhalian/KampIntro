namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            System.Console.WriteLine(product.ProductName + " eklendi.");

        }
        public void Update(Product product)
        {
            System.Console.WriteLine(product.ProductName + " güncellendi.");
        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public void Topla(int sayi1, int sayi2)
        {
            System.Console.WriteLine(sayi1 + sayi2);
        }
    }
}
