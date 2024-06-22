using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Dto;
using TodoApp.Entity.Db;
using TodoApp.Service.Classes;

namespace TodoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        protected readonly IConfiguration _configuration;
        protected readonly IMapper _mapper;
        protected readonly TaskService _service;

        public TaskController(IConfiguration configuration, IMapper mapper, TaskService service) => (_configuration, _mapper, _service) = (configuration, mapper, service);

        [HttpGet]
        public IActionResult GetAll() {
            try
            {
                var cs = _configuration["CS"]!;
                var entities = _service.GetAll(cs);
                var dto = _mapper.Map<IEnumerable<TaskGroupViewDto>>(entities);
                return Ok(dto);
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// Create a task
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Insert([FromBody] TaskCreateDto dto)
        {
            try
            {
                var cs = _configuration["CS"]!;
                var entity = _mapper.Map<TaskEntity>(dto);
                _service.Insert(cs, entity);
                return Ok();
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] TaskUpdateDto dto)
        {
            try
            {
                var cs = _configuration["CS"]!;
                var entity = _mapper.Map<TaskEntity>(dto);
                _service.Update(cs, entity);
                return Ok();
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                var cs = _configuration["CS"]!;
                _service.Delete(cs, id);
                return Ok();
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
    }
}
