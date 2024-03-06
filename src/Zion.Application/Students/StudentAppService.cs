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

    public async Task<List<StudentDto>?> GetAllListAsync()
    {
        var students = await Repository.ToListAsync();

        return ObjectMapper.Map<List<Student>, List<StudentDto>>(students);
    }

}