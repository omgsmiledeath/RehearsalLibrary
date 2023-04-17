using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehearsalLibrary.Interfaces
{
    public interface IRehearshalBase
    {
        IEnumerable<IEntry> GetAllEntries();
        IEnumerable<IRehearsalClient> GetAllClient();
        void AddNewEntry(IEntry entry);
        void AddNewClient(IRehearsalClient client);

    }
}
