namespace NKZSoft.Catalog.Service.Application.Models;

using Common.Models;

public sealed record ProductDto(Guid Id,  string Name, decimal Price, Guid CreatedBy, DateTime Created, Guid ModifiedBy, DateTime? Modified, DateTime? Deleted)
    : BaseDto(CreatedBy, Created, ModifiedBy, Modified, Deleted);
