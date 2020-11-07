# Pt.Unl.Fct.Miei.Usmanagement.Manager.Api.EndpointsApi

All URIs are relative to *http://localhost:1906/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetServiceEndpoint**](EndpointsApi.md#getserviceendpoint) | **GET** /services/{service}/endpoint | Obtém o melhor endpoint para o serviço {service}
[**GetServiceEndpoints**](EndpointsApi.md#getserviceendpoints) | **GET** /services/{service}/endpoints | Obtém todos os endpoints registados em nome do serviço {service}
[**RegisterEndpoint**](EndpointsApi.md#registerendpoint) | **POST** /register | Regista o endpoint no servidor eureka


<a name="getserviceendpoint"></a>
# **GetServiceEndpoint**
> Endpoint GetServiceEndpoint (string service)

Obtém o melhor endpoint para o serviço {service}

### Example
```csharp
using System;
using System.Diagnostics;
using Pt.Unl.Fct.Miei.Usmanagement.Manager.Api;
using Pt.Unl.Fct.Miei.Usmanagement.Manager.Client;
using Pt.Unl.Fct.Miei.Usmanagement.Manager.Model;

namespace Example
{
    public class GetServiceEndpointExample
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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **service** | **string**| Service name | 

### Return type

[**Endpoint**](Endpoint.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getserviceendpoints"></a>
# **GetServiceEndpoints**
> List<Endpoint> GetServiceEndpoints (string service)

Obtém todos os endpoints registados em nome do serviço {service}

### Example
```csharp
using System;
using System.Diagnostics;
using Pt.Unl.Fct.Miei.Usmanagement.Manager.Api;
using Pt.Unl.Fct.Miei.Usmanagement.Manager.Client;
using Pt.Unl.Fct.Miei.Usmanagement.Manager.Model;

namespace Example
{
    public class GetServiceEndpointsExample
    {
        public void main()
        {
            var apiInstance = new EndpointsApi();
            var service = service_example;  // string | Service name

            try
            {
                // Obtém todos os endpoints registados em nome do serviço {service}
                List&lt;Endpoint&gt; result = apiInstance.GetServiceEndpoints(service);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.GetServiceEndpoints: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **service** | **string**| Service name | 

### Return type

[**List<Endpoint>**](Endpoint.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registerEndpoint"></a>
# **RegisterEndpoint**
> void RegisterEndpoint ()

Regista o endpoint no servidor eureka

### Example
```csharp
using System;
using System.Diagnostics;
using Pt.Unl.Fct.Miei.Usmanagement.Manager.Api;
using Pt.Unl.Fct.Miei.Usmanagement.Manager.Client;
using Pt.Unl.Fct.Miei.Usmanagement.Manager.Model;

namespace Example
{
    public class RegisterEndpointExample
    {
        public void main()
        {
            var apiInstance = new EndpointsApi();

            try
            {
                // Regista o endpoint no servidor eureka
                apiInstance.RegisterEndpoint();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.RegisterEndpoint: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

