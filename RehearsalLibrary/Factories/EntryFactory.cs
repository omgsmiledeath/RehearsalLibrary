using RehearsalLibrary.Entities;
using RehearsalLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehearsalLibrary.Factories
{
    public class EntryFactory : IEntryFactory
    {
        private EntryProperties _properties;
        public EntryFactory(EntryProperties properties)
        {
            _properties = properties;
        }
        public IEntry CreateEntry()
        {
            switch (_properties.EntryType) 
            {
                case Enums.RehearsalEntryType.Vocal:
                    break;
                case Enums.RehearsalEntryType.Rehearsal: 
                    break;
                case Enums.RehearsalEntryType.Individual:
                    break;
                default:

                    break;

            }
            return new GroupEntry();
        }
    }
}
