using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace api
{
    public static class RolesGet
    {
        [FunctionName("roles-get")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get","post", Route = "roles")] HttpRequest req,
            ILogger log)
        {
            var user = await System.Text.Json.JsonSerializer.DeserializeAsync<User>(req.Body);
            var roles = new List<string>(){ "Admin", "User" };
            //Add your own implementation to get roles based on the user access token

            return new OkObjectResult(new { roles });
        }
    }


    public record User(string UserId, string? AccessToken);
}
