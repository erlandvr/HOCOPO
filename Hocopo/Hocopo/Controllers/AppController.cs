using Hocopo.Models;
using Hocopo.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hocopo.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;

        public AppController(IMailService mailService)
        {
            _mailService = mailService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("Contact")]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost("Contact")]
        public IActionResult Contact(ContactModel model)
        {  
            if (ModelState.IsValid)
            {
                // send email to me    
                _mailService.SendMessage("erland@gmail.com", $"From: {model.Email}, Description: {model.Description}", $"Duration: {model.Duration}");
                ViewBag.UserMessage = "Welcome to the dark society, enjoy your coding!";
                ModelState.Clear();
            }
          
            return View();
        }

        [HttpGet("About")]
        public IActionResult About()
        {
            return View();
        }
    }   
}
