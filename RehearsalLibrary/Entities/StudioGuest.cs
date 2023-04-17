using System;
using RehearsalLibrary.Interfaces;

namespace RehearsalLibrary.Entities;

public class StudioGuest : Client
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public ICollection<GroupEntry> GroupEntries { get; set; }
    public ICollection<IndividualEntry> IndividualEntries { get; set; }
    public ICollection<VocalEntry> VocalEntries { get; set; }
    public ICollection<Comment> Comments { get; set; }
}

