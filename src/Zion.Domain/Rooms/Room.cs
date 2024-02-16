using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Zion.Rooms;
public class Room : AuditedAggregateRoot<Guid>
{
    public string Name { get; protected set; } = string.Empty;
    public int Capacity { get; protected set; }

    // Add other properties as needed
}
