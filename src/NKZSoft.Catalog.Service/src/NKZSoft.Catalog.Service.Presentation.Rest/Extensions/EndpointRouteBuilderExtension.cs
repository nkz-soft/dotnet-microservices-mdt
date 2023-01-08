namespace NKZSoft.Catalog.Service.Presentation.REST.Extensions;

public static class EndpointRouteBuilderExtension
{
    public static IEndpointRouteBuilder MapRestEndpoints(this IEndpointRouteBuilder endpointRouteBuilder)
    {
        endpointRouteBuilder.MapControllers();
        return endpointRouteBuilder;
    }
}
