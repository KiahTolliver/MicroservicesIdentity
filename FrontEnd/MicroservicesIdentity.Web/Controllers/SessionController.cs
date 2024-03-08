using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroservicesIdentity.Web.Models;
using MicroservicesIdentity.Web.Service.IService;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MicroservicesIdentity.Web.Controllers
{
    public class SessionController : Controller
    {
        private readonly ISessionService _sessionService;
        public SessionController(ISessionService sessionService)
        {
            _sessionService = sessionService;
        }

        public async Task<IActionResult> SessionIndex()
        {

            List<SessionDto>? list = new();

            ResponseDto? response = await _sessionService.GetAllSessionsAsync();
            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<SessionDto>>(Convert.ToString(response.Result));
            }

            return View(list);
        }

        public async Task<IActionResult> SessionCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SessionCreate(SessionDto model)
        {
            if (ModelState.IsValid)
            {
                ResponseDto? response = await _sessionService.CreateSessionAsync(model);

                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(SessionIndex));
                }
            }
            return View(model);
        }


    }


}

