using System;
using RehearsalLibrary.Enums;

namespace RehearsalLibrary.Interfaces;

	public interface IUser
	{
    int Id { get; set; }
    string Name { get; set; }
    string Email { get; set; }
    bool CheckPassword(string password);
    StudioUserTypes UserType { get; set; }
    DateTime RegistrationDate { get; set; }
    }

