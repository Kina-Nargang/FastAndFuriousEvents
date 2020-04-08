using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventCatalogApi.Controllers
{
    // Route will be:  http://localhostXXXX/api/pic
    [Route("api/[controller]")]
    [ApiController]
    public class PicController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;
        public PicController(IWebHostEnvironment env)
        {
            _env = env;
        }

        [HttpGet("{id}")]
        public IActionResult GetImage(int id)
        {
            // use IWebHostEnvironment to get webroot folder path
            var webRoot = _env.WebRootPath;
            // combine the path with picture name
            var path = Path.Combine($"{webRoot}/Pics/", $"Event{id}.jpg");
            // change pictures into bytes
            var buffer = System.IO.File.ReadAllBytes(path);
            // return(send) it as an image file back
            return File(buffer, "image/jpeg");
        }
    }
}