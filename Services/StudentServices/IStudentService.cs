using Microsoft.AspNetCore.Mvc;
using uni.Dtos;
using uni.Entities;

namespace uni.Services.StudentServices
{
    public interface IStudentService
    {
        Task<ActionResult<List<Student>>> GetStudents();

        Task<ActionResult<Student>> AddStudent(AddStudentDto addStudentDto);
    }
}