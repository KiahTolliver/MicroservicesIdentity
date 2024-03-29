﻿using AutoMapper;
using MicroservicesIdentity.Services.EventAPI.Data;
using MicroservicesIdentity.Services.EventAPI.Models;
using MicroservicesIdentity.Services.EventAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MicroservicesIdentity.Services.EventAPI.Controllers
{
    [Route("api/event")]
    [ApiController]
    public class EventAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private IMapper _mapper;
        private ResponseDto _response;

        public EventAPIController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new ResponseDto();
        }

        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
                IEnumerable<Event> objList = _db.Events.ToList();
                _response.Result = _mapper.Map<IEnumerable<EventDto>>(objList);
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
                Event obj = _db.Events.First(u => u.Id == id);
                _response.Result = _mapper.Map<EventDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPost]
        public ResponseDto Post([FromBody] EventDto eventDto)
        {
            try
            {
                Event obj = _mapper.Map<Event>(eventDto);
                _db.Events.Add(obj);
                _db.SaveChanges();
                _response.Result = _mapper.Map<EventDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPut]
        public ResponseDto Put([FromBody] EventDto eventDto)
        {
            try
            {
                Event obj = _mapper.Map<Event>(eventDto);
                _db.Events.Update(obj);
                _db.SaveChanges();
                _response.Result = _mapper.Map<EventDto>(obj);
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
                Event obj = _db.Events.First(u => u.Id == id);
                _db.Events.Remove(obj);
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

