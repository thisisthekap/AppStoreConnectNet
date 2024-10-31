# AppStoreConnect.Net

Apple App Store Connect API Client .NET library generated by the OpenAPI Generator CLI tool.

[![.NET CI](https://github.com/Redth/AppStoreConnectNet/workflows/CI/badge.svg)](https://github.com/Redth/AppStoreConnectNet/actions)

[![.NET Library - AppStoreConnect.NET](https://img.shields.io/nuget/vpre/AppStoreConnect.Net?label=AppStoreConnect%20NuGet&color=blue)](https://www.nuget.org/packages/AppStoreConnect.Net)


## Usage

1. Generate an API Key ([Instructions from Apple](https://developer.apple.com/documentation/appstoreserverapi/creating_api_keys_to_use_with_the_app_store_server_api)
2. Obtain your Key ID, Issuer ID, and Private Key file (.p8)
3. You ***must*** use the `AppStoreConnectConfiguration` type when creating instances of the Api classes.

```
// Fill in our Key ID, Issuer ID, and Private Key file contents:
var keyId = "XYZ123ABC";
var issuerId = "11111111-AABB-CCDD-EEFF-123456ABCDEF";
var privateKey = @"
-----BEGIN PRIVATE KEY-----
YOUR-P8-PRIVATE-KEY-FILE-CONTENTS-HERE
-----END PRIVATE KEY-----";

// Must use AppStoreConnectConfiguration
var config = new AppStoreConnect.Client.AppStoreConnectConfiguration(keyId, issuerId, privateKey);

// Create a new instance of the ProfilesApi
var api = new AppStoreConnect.Api.ProfilesApi(config);

// Fetch all profiles for this account
var profiles = await api.ProfilesGetCollectionAsync().ConfigureAwait(false);

// Display all the profiles' Name and Uuid
foreach (var profile in profiles.Data)
{
    Console.WriteLine($"{profile.Attributes.Name} ({profile.Attributes.Uuid})");
}
```

## Generating / Updating

1. (Optional) Download a newer `openapi.json` spec file: https://developer.apple.com/sample-code/app-store-connect/app-store-connect-openapi-specification.zip and extract it to the root folder of the repo.

2. Ensure the open api generator CLI tool is installed: `& npm install @openapitools/openapi-generator-cli -g` (requires NPM to be already installed).

3. Generate the C# client `& npx @openapitools/openapi-generator-cli generate -i openapi.json -g csharp -o ./generated -c openapi-config.yaml --skip-validate-spec`

4. Touch up any build errors (there's a number of duplicated methods/fields that need to be commented out in various files)

## Additions
The Directory.Build.props file automatically includes .cs files from the additions folder which is where the `AppStoreConnectConfiguration` type is defined.

## Links

- [App Store Connect API Docs](https://developer.apple.com/documentation/appstoreconnectapi/)
