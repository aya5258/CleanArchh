using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {

        private UniversityDBContext _ctx;
        public CourseRepository(UniversityDBContext ctx )
        {
            _ctx=ctx;
        }
        public IEnumerable<Coures> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
