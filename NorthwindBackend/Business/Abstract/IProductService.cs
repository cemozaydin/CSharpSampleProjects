using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    interface IProductService
    {
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
        Product GetById(int productId);
        List<Product> GetAll();
        List<Product> GetAllByCategory(int categoryId);
    }
}
