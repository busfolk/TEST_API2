using System.Collections.Generic;
using UnderstandingASPNETCore2x.Data.Entities;

namespace UnderstandingASPNETCore2x.Data
{
    public interface IFooRepository
    {
        Product GetProduct(int id);
        IEnumerable<Product> GetProducts();
        bool changeProduct(Product p);
    }
}