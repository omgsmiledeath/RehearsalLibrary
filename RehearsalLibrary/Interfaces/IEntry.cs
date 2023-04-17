﻿using System;
namespace RehearsalLibrary.Interfaces
{
	public interface IEntry
	{
		int Id { get; set; }
		int RehearsalHourCount { get; set; }
		DateTime EntryStart { get; set; }
		DateTime EntryEnd { get; set; }
		string Entry { get; set; }
	}
}

