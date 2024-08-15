using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Threading.Tasks;
        using Microsoft.AspNetCore.Mvc;
       // using Webapi.Models;

        namespace Webapi.Controllers
        {
            [Route("api/[controller]")]
            [ApiController]
            public class CityController : ControllerBase
            {
                public CityController()
                {
                }
        
                [HttpGet("")]
                public ActionResult<IEnumerable<string>> Getstrings()
                {
                    return new List<string> {"New York","Atlanta","New jersey" };
                }
        
            }
        }
    