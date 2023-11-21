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

namespace api
{
    public static class DiscountsGet
    {
        [FunctionName("discounts-get")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "discounts")] HttpRequest req,
            ILogger log)
        {
            return new OkObjectResult(new List<Discount>
            {
                new Discount(10,"Contoso Market",30,"contoso30"),
               new Discount(20,"Tailwind Trader",20,"tailwind20"),
               new Discount(30,"Northwind-Mart",10, "northwind10")
            });
        }
    }


    public record Discount(int Id, string Store, int Percentage, string Code);
}
