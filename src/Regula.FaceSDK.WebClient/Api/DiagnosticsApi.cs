/*
 * Regula FaceSDK Web API
 *
 * [Download OpenAPI specification](https://github.com/regulaforensics/FaceSDK-web-openapi) ### Clients * [JavaScript](https://github.com/regulaforensics/FaceSDK-web-js-client) client for the browser and node.js based on axios * [Java](https://github.com/regulaforensics/FaceSDK-web-java-client) client compatible with jvm and android * [Python](https://github.com/regulaforensics/FaceSDK-web-python-client) 3.5+ client * [C#](https://github.com/regulaforensics/FaceSDK-web-csharp-client) client for .NET & .NET Core 
 *
 * The version of the OpenAPI document: 6.1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using Regula.FaceSDK.WebClient.Client;

namespace Regula.FaceSDK.WebClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDiagnosticsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Checking the license status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Request header label. (optional)</param>
        /// <returns>Dictionary&lt;string, Object&gt;</returns>
        Dictionary<string, Object> Readiness (string xRequestID = default(string));

        /// <summary>
        /// Checking the license status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Request header label. (optional)</param>
        /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>
        ApiResponse<Dictionary<string, Object>> ReadinessWithHttpInfo (string xRequestID = default(string));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Checking the license status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Request header label. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Dictionary&lt;string, Object&gt;</returns>
        System.Threading.Tasks.Task<Dictionary<string, Object>> ReadinessAsync (string xRequestID = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Checking the license status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Request header label. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, Object&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dictionary<string, Object>>> ReadinessWithHttpInfoAsync (string xRequestID = default(string), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DiagnosticsApi : IDiagnosticsApi
    {
        private Regula.FaceSDK.WebClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DiagnosticsApi(String basePath)
        {
            this.Configuration = new Regula.FaceSDK.WebClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Regula.FaceSDK.WebClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticsApi"/> class
        /// </summary>
        /// <returns></returns>
        public DiagnosticsApi()
        {
            this.Configuration = Regula.FaceSDK.WebClient.Client.Configuration.Default;

            ExceptionFactory = Regula.FaceSDK.WebClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DiagnosticsApi(Regula.FaceSDK.WebClient.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Regula.FaceSDK.WebClient.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Regula.FaceSDK.WebClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Regula.FaceSDK.WebClient.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Regula.FaceSDK.WebClient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Checking the license status 
        /// </summary>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Request header label. (optional)</param>
        /// <returns>Dictionary&lt;string, Object&gt;</returns>
        public Dictionary<string, Object> Readiness (string xRequestID = default(string))
        {
             ApiResponse<Dictionary<string, Object>> localVarResponse = ReadinessWithHttpInfo(xRequestID);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Checking the license status 
        /// </summary>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Request header label. (optional)</param>
        /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>
        public ApiResponse<Dictionary<string, Object>> ReadinessWithHttpInfo (string xRequestID = default(string))
        {

            var localVarPath = "/api/readiness";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (xRequestID != null) localVarHeaderParams.Add("X-RequestID", this.Configuration.ApiClient.ParameterToString(xRequestID)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Readiness", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Dictionary<string, Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Dictionary<string, Object>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, Object>)));
        }

        /// <summary>
        /// Checking the license status 
        /// </summary>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Request header label. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Dictionary&lt;string, Object&gt;</returns>
        public async System.Threading.Tasks.Task<Dictionary<string, Object>> ReadinessAsync (string xRequestID = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Dictionary<string, Object>> localVarResponse = await ReadinessWithHttpInfoAsync(xRequestID, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Checking the license status 
        /// </summary>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Request header label. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, Object&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Dictionary<string, Object>>> ReadinessWithHttpInfoAsync (string xRequestID = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/api/readiness";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (xRequestID != null) localVarHeaderParams.Add("X-RequestID", this.Configuration.ApiClient.ParameterToString(xRequestID)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Readiness", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Dictionary<string, Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Dictionary<string, Object>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, Object>)));
        }

    }
}
