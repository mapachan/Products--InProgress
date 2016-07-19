using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductService.svc or ProductService.svc.cs at the Solution Explorer and start debugging.
    public class ProductService : IProductService 
    {
        public bool create(Product product)
        {
            using (MyProductEntities mde = new MyProductEntities())
            {
                try
                {
                    ProductEntity pe = new ProductEntity();
                    pe.Name = product.Name;
                    pe.Price = product.Price;
                    pe.Quantity = product.Quantity;
                    mde.ProductEntities.Add(pe);
                    mde.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
        }

        public bool delete(Product product)
        {
            using (MyProductEntities mde = new MyProductEntities())
            {
                try
                {
                    int id = Convert.ToInt32(product.Id);
                    ProductEntity pe = mde.ProductEntities.Single(p => p.id == id);
                    mde.ProductEntities.Remove(pe);
                    mde.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
        }

        public bool edit(Product product)
        {
            using (MyProductEntities mde = new MyProductEntities())
            {
                try
                {
                    int id = Convert.ToInt32(product.Id);
                    ProductEntity pe = mde.ProductEntities.Single(p =>p.id==id);
                    pe.Name = product.Name;
                    pe.Price = product.Price;
                    pe.Quantity = product.Quantity;
                    mde.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
        }

        public Product find(string id)
        {
            using (MyProductEntities mde = new MyProductEntities())
            {
                int nid = Convert.ToInt32(id);
                return mde.ProductEntities.Where(pe => pe.id == nid).Select(pe => new Product
                {
                    Id = pe.id,
                    Name = pe.Name,
                    Price = pe.Price.Value,
                    Quantity = pe.Quantity.Value
                }).FirstOrDefault();

            }
        }

        public Product find(int id)
        {
            using (MyProductEntities mde = new MyProductEntities())
            {
                int did = Convert.ToInt32(id);
                return mde.ProductEntities.Where(pe => pe.id==id).Select(pe => new Product
                {
                    Id = pe.id,
                    Name = pe.Name,
                    Price = pe.Price.Value,
                    Quantity = pe.Quantity.Value 
                }).FirstOrDefault();

            }
        }

        public List<Product> findAll()
        {
            using (MyProductEntities mde = new MyProductEntities())
            {
                return mde.ProductEntities.Select(pe => new Product {
                Id = pe.id,
                Name = pe.Name,
                Price= pe.Price.Value,
                Quantity = pe.Quantity.Value}).ToList();

            }
        }

        public List<string> Product()
        {
            throw new NotImplementedException();
        }
    }
}
