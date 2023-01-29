namespace NKZSoft.Payment.Service.Application.Common.Models;

public record BaseDto(string CreatedBy, DateTime Created, string ModifiedBy, DateTime? Modified, DateTime? Deleted);
