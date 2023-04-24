using System;
using RehearsalLibrary.Interfaces;

namespace RehearsalLibrary.Entities;

public class Comment : IComment
{
    public int Id { get; set; }
    public string Message { get; set; }
    public int ClientId { get; set; }
    public Client Client { get; set; }
    public Client MessageOwner { get; set; }
}

