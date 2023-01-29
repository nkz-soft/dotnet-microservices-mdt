namespace NKZSoft.Payment.Service.Infrastructure.Core.Services;

public sealed class MachineDateTime : IDateTime
{
    public DateTime Now => DateTime.UtcNow;
}
