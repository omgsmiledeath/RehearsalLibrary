using System;
using RehearsalLibrary.Entities;

namespace RehearsalLibrary.Interfaces
{
	public interface IClientFactory
	{
		Client CreateClient(string name,string phone,string email);
	}
}

