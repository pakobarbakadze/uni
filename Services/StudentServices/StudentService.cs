using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using uni.Data;
using uni.Dtos;
using uni.Entities;
using uni.Models;

namespace uni.Services.StudentServices
{
    public class StudentService(DataContext context, IMapper mapper) : IStudentService
    {
        private readonly DataContext _context = context;
        private readonly IMapper _mapper = mapper;

        public async Task<ServiceResponse<List<Student>>> GetStudents()
        {
            var serviceResponse = new ServiceResponse<List<Student>>();

            var students = await _context.Students.ToListAsync();
            serviceResponse.Data = students;

            return serviceResponse;
        }

        public async Task<ServiceResponse<Student>> GetStudent(int id)
        {
            var serviceResponse = new ServiceResponse<Student>();

            var student = await _context.Students.FindAsync(id);
            if(student != null){
                serviceResponse.Data = student;
            }else {
                serviceResponse.Success = false;
                serviceResponse.Message = "User doesnt exist";
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<Student>> AddStudent(AddStudentDto addStudentDto)
        {
            var serviceResponse = new ServiceResponse<Student>();

            var student = _mapper.Map<Student>(addStudentDto);

            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            serviceResponse.Data = student;

            return serviceResponse;
        }
    }
}