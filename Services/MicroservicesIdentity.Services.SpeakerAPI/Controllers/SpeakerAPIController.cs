using AutoMapper;
using MicroservicesIdentity.Services.SpeakerAPI.Data;
using MicroservicesIdentity.Services.SpeakerAPI.Models;
using MicroservicesIdentity.Services.SpeakerAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MicroservicesIdentity.Services.SpeakerAPI.Controllers
{
    [Route("api/speaker")]
    public class SpeakerAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private IMapper _mapper;
        private ResponseDto _response;

        public SpeakerAPIController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new ResponseDto();
        }
        // GET: api/values
        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
                IEnumerable<Speaker> objList = _db.Speakers.ToList();
                _response.Result = _mapper.Map<IEnumerable<SpeakerDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ResponseDto Get(int id)
        {
            try
            {
                Speaker obj = _db.Speakers.First(u => u.Id == id);
                _response.Result = _mapper.Map<SpeakerDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPost]
        public ResponseDto Post([FromBody] SpeakerDto speakerDto)
        {
            try
            {
                Speaker obj = _mapper.Map<Speaker>(speakerDto);
                _db.Speakers.Add(obj);
                _db.SaveChanges();
                _response.Result = _mapper.Map<SpeakerDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPut]
        public ResponseDto Put([FromBody] SpeakerDto speakerDto)
        {
            try
            {
                Speaker obj = _mapper.Map<Speaker>(speakerDto);
                _db.Speakers.Update(obj);
                _db.SaveChanges();
                _response.Result = _mapper.Map<SpeakerDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpDelete]
        [Route("{id:int}")]
        public ResponseDto Delete(int id)
        {
            try
            {
                Speaker obj = _db.Speakers.First(u => u.Id == id);
                _db.Speakers.Remove(obj);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }
    }
}

