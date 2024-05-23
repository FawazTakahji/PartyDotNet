# PartyDotNet
A .NET client for the Party API made with [Refit](https://github.com/reactiveui/refit).

[![version](https://img.shields.io/github/v/release/FawazTakahji/PartyDotNet?color=Green&include_prereleases)](https://github.com/FawazTakahji/PartyDotNet/releases)
[![NuGet Version](https://img.shields.io/nuget/vpre/PartyDotNet)](https://www.nuget.org/packages/PartyDotNet)
[![Contributors](https://img.shields.io/github/contributors/FawazTakahji/PartyDotNet?color=dark-green)](https://github.com/FawazTakahji/PartyDotNet/graphs/contributors)
[![Issues](https://img.shields.io/github/issues/FawazTakahji/PartyDotNet)](https://github.com/FawazTakahji/PartyDotNet/issues)

## Installation
The latest release can be download from [NuGet](https://www.nuget.org/packages/PartyDotNet) or from the GitHub [packages](https://github.com/FawazTakahji/PartyDotNet/packages) and [releases](https://github.com/FawazTakahji/PartyDotNet/releases) pages.

## Usage

### Without a session cookie
```csharp
IPartyClient apiClient = RestService.For<IPartyClient>("https://kemono.su/api/v1");
List<Post> posts = await apiClient.GetRecentPosts();
```

### With a session cookie
```csharp
CookieContainer container = new();
container.Add(new Cookie("session", "<session cookie>", string.Empty, "coomer.su"));

HttpClientHandler handler = new() { CookieContainer = container };
HttpClient httpClient = new(handler) { BaseAddress = new Uri("https://coomer.su/api/v1") };

IPartyClient apiClient = RestService.For<IPartyClient>(httpClient);
List<FavoriteCreator> creators = await apiClient.GetFavoriteCreators();
```

### With IHttpClientFactory
Configuring services
```csharp
ServiceCollection collection = new();

CookieContainer container = new();
container.Add(new Cookie("session", "<session token>", string.Empty, "kemono.su"));

collection.AddHttpClient("KemonoClient", client =>
{
    client.BaseAddress = new Uri("https://kemono.su/api/v1");
})
.ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
{
    CookieContainer = container
});

_serviceProvider = collection.BuildServiceProvider();
```
Getting a client from IHttpClientFactory
```csharp
IPartyClient apiClient = _serviceProvider.GetRequiredService<IHttpClientFactory>().CreatePartyClient("KemonoClient");
HttpResponseMessage response = await apiClient.AddFavoriteCreator(Service.Patreon, "2448989");
```
