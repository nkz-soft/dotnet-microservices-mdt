namespace NKZSoft.Catalog.Service.Application.Common.Models;

public record BaseDto(Guid CreatedBy, DateTime Created, Guid ModifiedBy, DateTime? Modified, DateTime? Deleted);
