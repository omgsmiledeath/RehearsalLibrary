using RehearsalLibrary.Enums;
using RehearsalLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehearsalLibrary.Entities
{
    public class Client : IRehearsalClient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ICollection<GroupEntry> GroupEntries { get; set; }
        public virtual ICollection<IndividualEntry> IndividualEntries { get; set; }
        public virtual ICollection<VocalEntry> VocalEntries { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public Client()
        {
            GroupEntries = new List<GroupEntry>();
            IndividualEntries = new List<IndividualEntry>();
            VocalEntries = new List<VocalEntry>();
            Comments = new List<Comment>();
            Name = "Unknown";
            PhoneNumber = "Unknown";
            Email = "Unknown";
        }
        public Client(ClientProperties properties)
        {
            Name = properties.Name;
            PhoneNumber = properties.Phone;
            Email = properties.Email;
            GroupEntries = new List<GroupEntry>();
            IndividualEntries = new List<IndividualEntry>();
            VocalEntries = new List<VocalEntry>(); 
            Comments = new List<Comment>();
            RegistrationDate = DateTime.Now;
        }
    }
}
