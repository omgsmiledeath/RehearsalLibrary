using RehearsalLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehearsalLibrary.Entities
{
    public record class EntryProperties(Client CurrentClient,int RehearsalHourCount,DateTime StartDateTime,RehearsalEntryType EntryType,string AdditionMessage,bool CymbalsRent)
    {
    }
}
