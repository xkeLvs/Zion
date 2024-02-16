using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Zion.Students.Dtos;

namespace Zion.Students;

public interface IStudentAppService : ICrudAppService<StudentDto, Guid, PagedAndSortedResultRequestDto, CreateStudentDto, UpdateStudentDto>
{
    Task<List<StudentDto>> GetAllListAsync();
}
