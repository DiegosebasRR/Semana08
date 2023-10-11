using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data1;
using Entety2;
namespace Business1
{
    public class BProduct
    {
        public List<Product> GetByName(string Name)
        {
           
            DProduct data = new DProduct();
            var products = data.Get();
            var result= products.Where(x=>x.name == Name).ToList();
            //lambda          

            return result;
        }
        public List<Product> Get()
        {
            

            DProduct data = new DProduct();
            var products = data.Get();
            
            return products;
        }
    }
}
