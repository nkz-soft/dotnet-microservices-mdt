namespace NKZSoft.Order.Service.Application.Common.Exceptions;

[Serializable]
public sealed class PermissionDeniedException : Exception
{
    public PermissionDeniedException(string message)
        : base(message)
    {
    }

    private PermissionDeniedException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        : base(serializationInfo, streamingContext)
    {
    }
}
