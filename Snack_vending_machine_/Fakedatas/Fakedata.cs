using Newtonsoft.Json;
using Snack_vending_machine_.Models;
using System.Collections.Generic;
using System.IO;

namespace Snack_vending_machine_.Fakedatas
{
    public class Fakedata
    {
        public static List<Product> products = new List<Product>()
        {
            new Product("cola.png",2.50f,5),
            new Product("fanta.png",1.50f,4),
            new Product("sprite.png",3.50f,7),
            //new Product(,1.70f,9),
            //new Product(,1.70f,9),
            //new Product(,1.70f,9),
            //new Product(,1.70f,9),
        
        };

    }
}
