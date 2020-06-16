using DatingApp.Domain.Entities;
using DatingApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatingAPP.Persistence.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private DatingAppContext _Context;

        public CourseRepository(DatingAppContext datingAppContext)
        {
            _Context = datingAppContext;
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _Context.Courses;
        }

        public Course GetCourse(int id )
        {
            return _Context.Courses.FirstOrDefault(c => c.Id == id);
        }
    }
}
