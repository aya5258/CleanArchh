using CleanArch.Application.interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {

        private  readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;

        public CourseService(ICourseRepository courseRepository , IMediatorHandler bus)
        {
            _courseRepository = courseRepository;
            _bus = bus;
        }

        public void Create(CourseViewModel _courseViewModel)
        {
            var createcoursecommand = new CreateCourseCommand(_courseViewModel.Name,
                _courseViewModel.Description,
                _courseViewModel.ImgURL);

            _bus.SendCommand(createcoursecommand);
           
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses= _courseRepository.GetCourses()
            };
        }
    }
}
