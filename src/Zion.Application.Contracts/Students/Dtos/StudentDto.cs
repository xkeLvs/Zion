using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Zion.Students.Dtos;

public class StudentDto : AuditedEntityDto<Guid>
{
    public string LastName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string MiddleName { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
    public string Picture { get; set; } = string.Empty;
    public string BirthCertificate { get; set; } = string.Empty;
    public string ParentLastName { get; set; } = string.Empty;
    public string ParentFirstName { get; set; } = string.Empty;
    public string ParentMiddleName { get; set; } = string.Empty;
    public string ContactNumber { get; set; } = string.Empty;
}
