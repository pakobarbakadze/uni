using uni.Dtos;
using uni.Entities;
using uni.Models;

namespace uni.Services.StudentServices
{
    public interface IStudentService
    {
        Task<ServiceResponse<List<Student>>> GetStudents();
        Task<ServiceResponse<Student>> GetStudent(int id);
        Task<ServiceResponse<Student>> AddStudent(AddStudentDto addStudentDto);
    }
}