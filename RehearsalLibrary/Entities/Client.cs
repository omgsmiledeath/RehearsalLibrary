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

        }
    }
}
