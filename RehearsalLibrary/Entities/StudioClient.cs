using RehearsalLibrary.Enums;
using RehearsalLibrary.Interfaces;

namespace RehearsalLibrary.Entities;
public class StudioClient : Client
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<GroupEntry>? GroupEntries { get; set; }
    public StudioUserTypes UserType { get; set; }
    public ICollection<IndividualEntry>? IndividualEntries { get; set; }
    public ICollection<VocalEntry>? VocalEntries { get; set; }
    public ICollection<Comment>? Comments { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public DateTime RegistrationDate { get; set; }

}

