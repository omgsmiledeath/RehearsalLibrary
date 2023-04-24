using System;
using RehearsalLibrary.Entities;
using RehearsalLibrary.Interfaces;

namespace RehearsalLibrary.Factories
{
    public class ClientFactory : IClientFactory
    {
        private ClientProperties _properties;

        public ClientFactory(ClientProperties properties)
        {
            _properties = properties;
        }
        public Client CreateClient()
        {
            return new Client(_properties);
        }
    }
}

