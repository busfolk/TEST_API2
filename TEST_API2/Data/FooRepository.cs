using System.Collections.Generic;
using System.Linq;
using TEST_API2;
using UnderstandingASPNETCore2x.Data.Entities;

namespace UnderstandingASPNETCore2x.Data
{
    public class FooRepository : IFooRepository
    {
        private FooContext _fooContext;

        public IGreeter _greeter { get; }

        public FooRepository(FooContext fooContext, IGreeter greeter)
        {
            _fooContext = fooContext;
            _greeter = greeter;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _fooContext.Products.OrderBy(p => p.Name).ToList();
            
        }

        public Product GetProduct(int id)
        {
            //return _fooContext.Products.Where(p => p.Id == id).FirstOrDefault();
            var p = _fooContext.Products.Find(id);
            string prompt = _greeter.GetMessageOfTheDay();
            p.Name = p.Name + " " + prompt;
            return p;
        }

        public bool changeProduct(Product p)
        {
            p.Name = "Bigfoot";
            

            return true;
        }
    }
}
