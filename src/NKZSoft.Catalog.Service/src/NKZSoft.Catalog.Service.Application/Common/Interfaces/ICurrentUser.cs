namespace NKZSoft.Catalog.Service.Application.Common.Interfaces;

public interface ICurrentUser
{
    Guid Id { get; }

    string? FirstName { get; }

    string? LastName { get; }

    string MiddleName { get; }
}
