using Refit;

namespace PartyDotNet.Extensions;

public static class IHttpClientFactoryExtensions
{
    public static IPartyClient CreatePartyClient(this IHttpClientFactory factory, string name)
    {
        return RestService.For<IPartyClient>(factory.CreateClient(name));
    }
}