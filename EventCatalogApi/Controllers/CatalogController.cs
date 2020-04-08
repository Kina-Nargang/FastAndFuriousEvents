using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventCatalogApi.Data;
using EventCatalogApi.Domain;
using EventCatalogApi.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace EventCatalogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly EventContext _context;
        private readonly IConfiguration _config;
        public CatalogController(EventContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> Events(
            [FromQuery]int pageIndex = 0, 
            [FromQuery]int pageSize = 6)
        {
            var eventsCount = await _context.EventDatails.LongCountAsync();

            var events = await _context.EventDatails
                                    .Skip(pageIndex * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            events = ChangePictureUrl(events);


            var model = new PaginatedEventViewModel<EventDetail>
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                Count = eventsCount,
                Events = events
            };

            return Ok(model);
        }

        private List<EventDetail> ChangePictureUrl(List<EventDetail> events)
        {
            events.ForEach(
                e => e.PictureUrl =
                        e.PictureUrl.Replace("http://externalcatalogbaseurltobereplaced", 
                                              _config["ExternalCatalogBaseUrl"])
                        );

            return events;
        }
    }
}