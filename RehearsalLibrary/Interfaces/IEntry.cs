using System;
using RehearsalLibrary.Enums;

namespace RehearsalLibrary.Interfaces
{
	public interface IEntry
	{
		int Id { get; set; }
		int RehearsalHourCount { get; set; }
		DateTime EntryStart { get; set; }
		DateTime EntryEnd { get; set; }
		RehearsalEntryType EntryType { get; set; }
		IRehearsalClient Client { get; set; }
		string AdditionMessage { get; set; }
	}
}

