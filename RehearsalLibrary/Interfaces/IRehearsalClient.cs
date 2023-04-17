using System;
using RehearsalLibrary.Entities;
namespace RehearsalLibrary.Interfaces;

public interface IRehearsalClient
{
    int Id { get; set; }
    string Name { get; set; }
    string PhoneNumber { get; set; }
    ICollection<GroupEntry> GroupEntries { get; set; }
    ICollection<IndividualEntry> IndividualEntries { get; set; }
    ICollection<VocalEntry> VocalEntries { get; set; }
    ICollection<IComment> Comments { get; set; }
    
}

