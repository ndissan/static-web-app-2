using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Company.Function
{
    public static class UrlRedirect
    {
        [FunctionName("UrlRedirect")]
        public static IActionResult Run(HttpRequest req, ILogger log)
        {
            return new RedirectResult("https://www.gs1au.org/nlr", true);
        }
    }
}
