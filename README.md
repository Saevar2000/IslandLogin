<h1 align="center">IslandLogin</h1>

<h4 align="center">.NET Standard library that takes care of <a href="https://island.is/"> Island.is</a> login service token verification.</h4>

<p align="center">
    <a href="https://www.nuget.org/packages/IslandLogin" target"_blank">
        <img src="https://img.shields.io/nuget/vpre/IslandLogin.svg" alt="NuGet Package">
    </a>
    <a href="https://github.com/bitarehf/Bitar/actions" target="_blank">
        <img src="https://github.com/Saevar2000/IslandLogin/workflows/.NET%20Core/badge.svg" alt=".NET Core Build">
    </a>
    <a href="https://github.com/Saevar2000/IslandLogin/blob/master/LICENSE" target="_blank">
        <img src="https://img.shields.io/badge/License-MIT-yellow.svg" alt="License: MIT">
    </a>
</p>

## 🎉 Features
- ✖ Cross-platform based on [.NET Standard 2.0](https://docs.microsoft.com/en-us/dotnet/standard/net-standard)
- 👴 Uses [System.Security.Cryptography.Xml](https://www.nuget.org/packages/System.Security.Cryptography.Xml/)
- 💪 Strongly ish typed models 

## 📦 Getting Started

```csharp
using IslandLogin;
```

```csharp
var il = new IslandLogin(token);

bool verified = il.Verify();

Console.WriteLine($"Verified: {verified}");
Console.WriteLine("=============");
Console.WriteLine($"Audience: {il.Island.Audience}");
Console.WriteLine($"Authentication: {il.Island.Authentication}");
Console.WriteLine($"AuthId: {il.Island.AuthId}");
Console.WriteLine($"Destination: {il.Island.Destination}");
Console.WriteLine($"Id: {il.Island.Id}");
Console.WriteLine($"IPAddress: {il.Island.IPAddress}");
Console.WriteLine($"Name: {il.Island.Name}");
Console.WriteLine($"NotBefore: {il.Island.NotBefore}");
Console.WriteLine($"NotOnOrAfter: {il.Island.NotOnOrAfter}");
Console.WriteLine($"ReceiverId: {il.Island.ReceiverId}");
Console.WriteLine($"UserAgent: {il.Island.UserAgent}");
Console.WriteLine($"UserId: {il.Island.UserId}");

// Verified: True
// =============
// Audience: api.bitar.is
// Authentication: Rafræn símaskilríki
// AuthId: 1337
// Destination: https://api.bitar.is/account/island
// Id: _11cdf1be-1dcb-449e-9ef9-f91ce361b1d0
// IPAddress: 89.17.150.161
// Name: Bitar ehf.
// NotBefore: 7/19/2020 11:14:52 PM
// NotOnOrAfter: 7/19/2020 11:20:22 PM
// ReceiverId: 4708180420
// UserAgent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.116 Safari/537.36
// UserId: 4708180420
```

## 🐰 Technical specifications

- [Leiðbeiningar til tæknimanna vegna innskráningarþjónustu Ísland.is](https://island.is/wp-content/uploads/2020/03/innskraning-island-is-leidbeiningar-utg-2-0.619.pdf)
