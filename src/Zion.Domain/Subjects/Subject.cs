using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Zion.Subjects;

public class Subject : AuditedAggregateRoot<Guid>
{
    public string Name { get; protected set; } = string.Empty;
    public string Description { get; protected set; } = string.Empty;

    // Add other properties as needed
}
