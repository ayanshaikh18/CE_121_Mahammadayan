using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab9_.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext context;
        public ProductRepository(AppDbContext context)
        {
            this.context = context;
        }
        Product IProductRepository.Add(Product Product)
        {
            context.Products.Add(Product);
            context.SaveChanges();
            return Product;
        }

        Product IProductRepository.Delete(int id)
        {
            Product Product = context.Products.Find(id);
            if (Product != null)
            {
                context.Products.Remove(Product);
                context.SaveChanges();
            }
            return Product;
        }

        IEnumerable<Product> IProductRepository.GetAllProducts()
        {
            return context.Products;

        }

        Product IProductRepository.GetProduct(int id)
        {
            return context.Products.Find(id);
        }

        Product IProductRepository.Update(Product ProductModified)
        {
            var Product = context.Products.Attach(ProductModified);
            Product.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return ProductModified;
        }
    }
}
