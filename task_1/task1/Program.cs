namespace task1;
class Program
{
    static void Main(string[] args)
    {
        Product pr1 = new Product();
        
        pr1.Category = "Smartphones";
        pr1.Price = 1000;

        Product pr2 = new Product();
        
        pr2.Category = "Notebooks";
        pr2.Price = 2000;

        Store store = new Store();

        Product[] products = new Product[0];

        store.Products = products;

        store.AddProduct(pr1);

        store.AddProduct(pr2);

        Console.WriteLine(store.HasProductByNo(2));

        Console.WriteLine(store.GetProductByNo(2).Category);
    }
}

