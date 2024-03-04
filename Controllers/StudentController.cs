using Microsoft.AspNetCore.Mvc;
using uni.Dtos;
using uni.Entities;
using uni.Services.StudentServices;

namespace uni.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController(IStudentService studentService) : ControllerBase
    {
        private readonly IStudentService _studentService = studentService;

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetStudents()
        {
            return Ok(await _studentService.GetStudents());
        }

        [HttpPost]
        public async Task<ActionResult<Student>> AddStudent(AddStudentDto addStudentDto)
        {
            return Ok(await _studentService.AddStudent(addStudentDto));
        }
    }
}