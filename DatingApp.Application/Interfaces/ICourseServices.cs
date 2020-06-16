using DatingApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatingApp.Application.Interfaces
{
    public interface ICourseServices
    {
        IEnumerable<Course> GetCourses();
        Course GetCourse(int id);
    }
}
