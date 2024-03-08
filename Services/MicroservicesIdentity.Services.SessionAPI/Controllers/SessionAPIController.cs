using AutoMapper;
using MicroservicesIdentity.Services.SessionAPI.Data;
using MicroservicesIdentity.Services.SessionAPI.Models;
using MicroservicesIdentity.Services.SessionAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MicroservicesIdentity.Services.SessionAPI.Controllers
{
    [Route("api/session")]
    public class SessionAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private IMapper _mapper;
        private ResponseDto _response;

        public SessionAPIController(AppDbContext db, IMapper mapper)
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
                IEnumerable<Session> objList = _db.Sessions.ToList();
                _response.Result = _mapper.Map<IEnumerable<SessionDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

        // GET api/values/5
        [HttpGet]
        [Route("{id:int}")]
        public ResponseDto Get(int id)
        {
            try
            {
                Session obj = _db.Sessions.First(u => u.Id == id);
                _response.Result = _mapper.Map<SessionDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        // POST api/values
        [HttpPost]
        public ResponseDto Post([FromBody] SessionDto sessionDto)
        {
            try
            {
                Session obj = _mapper.Map<Session>(sessionDto);
                _db.Sessions.Add(obj);
                _db.SaveChanges();
                _response.Result = _mapper.Map<SessionDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        // PUT api/values/5
        [HttpPut]
        public ResponseDto Put([FromBody] SessionDto sessionDto)
        {
            try
            {
                Session obj = _mapper.Map<Session>(sessionDto);
                _db.Sessions.Update(obj);
                _db.SaveChanges();
                _response.Result = _mapper.Map<SessionDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        // DELETE api/values/5
        [HttpDelete]
        [Route("{id:int}")]
        public ResponseDto Delete(int id)
        {
            try
            {
                Session obj = _db.Sessions.First(u => u.Id == id);
                _db.Sessions.Remove(obj);
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

