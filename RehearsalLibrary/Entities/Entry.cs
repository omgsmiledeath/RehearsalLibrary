using RehearsalLibrary.Enums;
using RehearsalLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehearsalLibrary.Entities
{
    public abstract class Entry : IEntry
    {
        public int Id { get; set; }
        public int RehearsalHourCount { get; set; }
        public DateTime EntryStart { get; set; }
        public DateTime EntryEnd { get; set; }
        public RehearsalEntryType EntryType { get; set; }
        public Client Client { get; set; }
        public string AdditionMessage { get; set; }
        public RehearsalEntryStatus EntryStatus { get; set; }
    }
}
