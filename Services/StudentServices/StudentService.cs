using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using uni.Data;
using uni.Dtos;
using uni.Entities;

namespace uni.Services.StudentServices
{
    public class StudentService(DataContext context, IMapper mapper) : IStudentService
    {
        private readonly DataContext _context = context;
        private readonly IMapper _mapper = mapper;

        public async Task<ActionResult<List<Student>>> GetStudents()
        {
            var students = await _context.Students.ToListAsync();
            return students;
        }

        public async Task<ActionResult<Student>> AddStudent(AddStudentDto addStudentDto)
        {
            var student = _mapper.Map<Student>(addStudentDto);

            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return student;
        }
    }
}