using System;
using System.Linq;// пишем запросы для работы с коллекциями
namespace Store.Memory
{
    public class ProductRepository : IProductRepository
    {
        private readonly Product[] products = new[]
        { 
            new Product (1, "Water"),
            new Product(2, "Bread"),
            new Product(3, "Maslo and Bread"),
        };

        public Product[] GetAllByTitle(string titlePart)
        {
            return products.Where(product => product.Title.Contains(titlePart))
                .ToArray();
        }
    }
}
