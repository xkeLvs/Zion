using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Zion.Teachers;

public class Teacher : AuditedAggregateRoot<Guid>
{
    public string LastName { get; protected set; } = string.Empty;
    public string FirstName { get; protected set; } = string.Empty;
    public string MiddleName { get; protected set; } = string.Empty;
    public string Address { get; protected set; } = string.Empty;
    public DateTime BirthDate { get; protected set; }
    public string ContactNumber { get; protected set; } = string.Empty;

}