using DatingApp.Application.Interfaces;
using DatingApp.Domain.Entities;
using DatingApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatingApp.Application.Services
{
    public class CourseServices : ICourseServices
    {
        private ICourseRepository _ctx;

        public CourseServices(ICourseRepository ctx)
        {
            _ctx = ctx;
        }

        public Course GetCourse(int id )
        {
            return _ctx.GetCourse(id);
        }

        public IEnumerable<Course> GetCourses()
        {
            return _ctx.GetAllCourses();
        }
    }
}
