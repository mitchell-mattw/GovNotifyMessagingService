using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessagingService.Models;
using MessagingService.Services;
using Microsoft.AspNetCore.Mvc;
using Notify.Models.Responses;

namespace MessagingService.Controllers
{
    [Route("api/[controller]")]
    public class NotifyController : Controller
    {
        private readonly IEmailNotifyService _emailNotifyService;


        public NotifyController(IEmailNotifyService emailNotifyService)
        {
            _emailNotifyService = emailNotifyService;

        }


        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "ASP NET CORE", "WEB API" };
        }

        [HttpPost]
        public IActionResult Post([FromBody] TemplateOptions options)
        {
            if (options == null)
            {
                // return BadRequest();
                return BadRequest();
            }

            EmailNotificationResponse response;

            try
            {
                response = _emailNotifyService.SendEmail(options);
                // Log response????
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            //TODO
            //return CreatedAtRoute("GetTodo", new { id = item.Id }, item);
            return Ok(response.id);
        }

    }
}