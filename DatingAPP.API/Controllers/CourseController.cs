using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.Application.Interfaces;
using DatingApp.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DatingAPP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private ICourseServices _ctx;

        public CourseController(ICourseServices ctx)
        {
            _ctx = ctx;
        }

        // GET: api/Course
        [HttpGet]
        public IEnumerable<Course> Get()
        {
            return _ctx.GetCourses();
        }

        // GET: api/Course/5
        [HttpGet("{id}", Name = "Get")]
        public Course Get(int id)
        {
            return _ctx.GetCourse(id);
        }

        // POST: api/Course
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Course/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
