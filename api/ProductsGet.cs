using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ShopAtHome
{
    public static class ProductsGet
    {
        [FunctionName("products-get")]
        public static async Task<IActionResult> Get(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "products")] HttpRequest req,
            ILogger log)
        {
           return new OkObjectResult(new List<Product> { new Product(10, "T-Shirt", "SWA fanclub branded T-Shirt", 1),
                      new Product(20, "Mug", "SWA fanclub branded Mug", 1),
                      new Product(30, "Poster", "SWA fanclub branded Poster", 1)}); 
        } 
    }

    public record Product(int Id, string Name, string Description, int Quantity);

}
