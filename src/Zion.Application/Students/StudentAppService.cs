using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Zion.Students.Dtos;

namespace Zion.Students;

public class StudentAppService :
    CrudAppService<
        Student, //The Book entity
        StudentDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateStudentDto,
        UpdateStudentDto>, //Used to create/update a book
    IStudentAppService //implement the IBookAppService
{
    
    
    public StudentAppService(IRepository<Student, Guid> repository)
        : base(repository)
    {

    }

    public async Task<List<StudentDto>> GetAllListAsync()
    {
        var students = await Repository.ToListAsync();

        // Map the students to the StudentDto
        var studentDtos = students.Select(student => new StudentDto
        {
            Id = student.Id,
            FirstName = student.FirstName,
            LastName = student.LastName,
            // Add other properties as needed
        }).ToList();

        return studentDtos;
    }

}