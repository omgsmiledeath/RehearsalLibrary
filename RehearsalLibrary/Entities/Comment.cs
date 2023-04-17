using System;
using RehearsalLibrary.Interfaces;

namespace RehearsalLibrary.Entities;

public class Comment : IComment
{
    public int Id { get; set; }
    public string Message { get; set; }
    public IRehearsalClient StudioClient { get; set; }
    
}

