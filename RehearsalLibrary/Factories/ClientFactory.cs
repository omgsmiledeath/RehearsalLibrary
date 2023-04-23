using System;
using RehearsalLibrary.Entities;
using RehearsalLibrary.Interfaces;

namespace RehearsalLibrary.Factories
{
	public class ClientFactory:IClientFactory
	{
        public Client CreateClient(string name, string phone, string email)
        {
            return new Client();
        }
    }
}

