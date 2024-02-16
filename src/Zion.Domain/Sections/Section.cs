using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Zion.Sections;
public class Section : AuditedAggregateRoot<Guid>
{
    public string Name { get; protected set; } = string.Empty;
    public string GradeLevel { get; protected set; } = string.Empty;

    // Add other properties as needed
}