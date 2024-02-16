using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Zion.SchoolYears;
public class SchoolYear : AuditedAggregateRoot<Guid>
{
    public DateTime StartDate { get; protected set; }
    public DateTime EndDate { get; protected set; }

    // Add other properties as needed
}