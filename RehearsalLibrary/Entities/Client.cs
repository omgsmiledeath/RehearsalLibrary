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
        public ICollection<GroupEntry> GroupEntries { get; set; }
        public ICollection<IndividualEntry> IndividualEntries { get; set; }
        public ICollection<VocalEntry> VocalEntries { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}
