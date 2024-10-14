using AsyncWebApi.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            //run the logging code in a new throw-away thread
            //we can do this because there is no return value
            //and the new thread doesn't need synchronization
            Task.Run(() => Logger.Log("Call to main method"));
            
            //run the data access code in a new thread and store the reference
            //we do this, because we need to wait for the result
            //and return it
            var dataAccessTask = Task.Run(()=> ProductDataAccess.GetProducts());
            
            //return the result
            return dataAccessTask.Result;
        }
    }
}