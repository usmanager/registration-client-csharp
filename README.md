# Registration-client-csharp

Cliente api que executa pedidos ao registration server (eureka) para registar esta instância ou obter servidores com o qual pode comunicar.  
Para ser usado em microserviços implementados em c#.

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Pt.Unl.Fct.Miei.Usmanagement.Manager.Api;
using Pt.Unl.Fct.Miei.Usmanagement.Manager.Client;
using Pt.Unl.Fct.Miei.Usmanagement.Manager.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Pt.Unl.Fct.Miei.Usmanagement.Manager.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Pt.Unl.Fct.Miei.Usmanagement.Manager.Api;
using Pt.Unl.Fct.Miei.Usmanagement.Manager.Client;
using Pt.Unl.Fct.Miei.Usmanagement.Manager.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            var apiInstance = new EndpointsApi();
            var service = service_example;  // string | Service name

            try
            {
                // Obtém o melhor endpoint para o serviço {service}
                Endpoint result = apiInstance.GetServiceEndpoint(service);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.GetServiceEndpoint: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost:1906/api*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*EndpointsApi* | [**GetServiceEndpoint**](docs/EndpointsApi.md#getserviceendpoint) | **GET** /services/{service}/endpoint | Obtém o melhor endpoint para o serviço {service}
*EndpointsApi* | [**GetServiceEndpoints**](docs/EndpointsApi.md#getserviceendpoints) | **GET** /services/{service}/endpoints | Obtém todos os endpoints registados em nome do serviço {service}
*EndpointsApi* | [**RegisterEndpoint**](docs/EndpointsApi.md#registerEndpoint) | **POST** /register | Regista o endpoint no servidor eureka


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Endpoint](docs/Endpoint.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.


## Licença

Registration-client-cpp está licenciado com a [MIT license](../LICENSE). Ver a licença no cabeçalho do respetivo ficheiro para confirmar.