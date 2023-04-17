using System;
namespace RehearsalLibrary.Interfaces;

public interface IComment
{
    int Id { get; set; }
    string Message { get; set; }
    IRehearsalClient StudioClient { get; set; }
}

