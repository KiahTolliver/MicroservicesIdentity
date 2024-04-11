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
    public class SpeakerController : Controller
    {
        private readonly ISpeakerService _speakerService;
        public SpeakerController(ISpeakerService speakerService)
        {
            _speakerService = speakerService;
        }

        public async Task<IActionResult> SpeakerIndex()
        {

            List<SpeakerDto>? list = new();

            ResponseDto? response = await _speakerService.GetAllSpeakersAsync();
            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<SpeakerDto>>(Convert.ToString(response.Result));
            }

            return View(list);
        }

        public async Task<IActionResult> SpeakerCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SpeakerCreate(SpeakerDto model)
        {
            if (ModelState.IsValid)
            {
                ResponseDto? response = await _speakerService.CreateSpeakerAsync(model);

                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(SpeakerIndex));
                }
            }
            return View(model);
        }

        //public async Task<IActionResult> SpeakerDelete(int id)
        //{
        //    ResponseDto? response = await _speakerService.GetSpeakerByIdAsync(id);

        //    if (response != null && response.IsSuccess)
        //    {
        //        var model = JsonConvert.DeserializeObject<SpeakerDto>(Convert.ToString(response.Result));
        //        return View(model);
        //    }
        //    return NotFound();
        //}
    }
}

