[![NuGet](https://img.shields.io/nuget/v/messari-dotnet-client.svg)](https://www.nuget.org/packages/messari-dotnet-client/) ![Messari .NET Client - Deploy](https://github.com/longpshorn/messari-dotnet-client/workflows/Messari%20.NET%20Client%20-%20Deploy/badge.svg) [![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

# Messari .NET Client

Messari .NET Client is a .NET Library for the [Messari API](https://messari.io/api/docs) to interact with the Messari.io platform to get market data, asset information, and news for crypto assets. 

In order to use this client you will need to have an Access Token from Messari for your account. You can sign up [here](https://messari.io/).

## Include the Client

To implement the Library into your project, install [NuGet package](https://www.nuget.org/packages/messari-dotnet-client/) into your solution/project by running it in the Package Manager Console.
````
PM> Install-Package MessariDotNetClient
````
Or by searching MessariDotNetClient in the Package Manager searching bar.

To implement the client into your project, include the `Messari` namespace:
```csharp
using Messari;
```

To instantiate a new client in your program, include the following:

```csharp
MessariClient client = new MessariClient("<TOKEN>");
```

<br/>
<div align="right">
    <b><a href="#messari-net-client">↥ back to top</a></b>
</div>
<br/>

## Using the Client

The client is separated into different sections and follows the [API documentation](https://messari.io/api/docs) outline. Described below are all of the supported API calls for each section.

### [Assets](https://github.com/longsphorn/omnieq-dotnet-client/wiki/Using-Asset-methods)
```csharp
MessariResponse<IEnumerable<AssetResponse>> result = await client.Asset.GetAllAssetsAsync();
```

### [Markets](https://github.com/longsphorn/omnieq-dotnet-client/wiki/Using-Market-methods)
```csharp
MessariResponse<IEnumerable<MarketResponse>> result = await client.Market.GetAllMarketsAsync();

```
### [News](https://github.com/longsphorn/omnieq-dotnet-client/wiki/Using-News-methods)

```csharp
MessariResponse<IEnumerable<NewsResponse>> result = await client.News.GetAllNewsAsync();
MessariResponse<IEnumerable<NewsResponse>> result = await client.News.GetAssetNewsAsync("XRP");
```

<br/>
<div align="right">
    <b><a href="#messari-net-client">↥ back to top</a></b>
</div>
<br/>

## Authors

* **[Patrick Smith](https://github.com/longpshorn)**

## Disclaimer

This Wrapper is NOT an official .NET Messari Library. This library is provided "as is" without expressed or implied warranty of any kind. Please use at your own risk and discretion.

## License
This Library is provided under the Apache 2.0 License - see the [LICENSE](https://github.com/longpshorn/messari-dotnet-client/blob/master/LICENSE) file for details.