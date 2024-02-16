using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Zion.Students;

public class Student : AuditedAggregateRoot<Guid>
{
    public string LastName { get; protected set; } = string.Empty;
    public string FirstName { get; protected set; } = string.Empty;
    public string MiddleName { get; protected set; } = string.Empty;
    public string Address { get; protected set; } = string.Empty;
    public DateTime BirthDate { get; protected set; }
    public string Picture { get; protected set; } = string.Empty;
    public string BirthCertificate { get; protected set; } = string.Empty;
    public string ParentLastName { get; protected set; } = string.Empty;
    public string ParentFirstName { get; protected set; } = string.Empty;
    public string ParentMiddleName { get; protected set; } = string.Empty;
    public string ContactNumber { get; protected set; } = string.Empty;

}