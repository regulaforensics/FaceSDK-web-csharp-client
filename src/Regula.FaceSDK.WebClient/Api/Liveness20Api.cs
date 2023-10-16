/*
 * Regula FaceSDK Web API
 *
 * Regula FaceSDK Web API # Clients * [JavaScript](https://github.com/regulaforensics/FaceSDK-web-js-client) client for the browser and node.js based on axios * [Java](https://github.com/regulaforensics/FaceSDK-web-java-client) client compatible with jvm and android * [Python](https://github.com/regulaforensics/FaceSDK-web-python-client) 3.5+ client * [C#](https://github.com/regulaforensics/FaceSDK-web-csharp-client) client for .NET & .NET Core 
 *
 * The version of the OpenAPI document: 5.2.0
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
using Regula.FaceSDK.WebClient.Model;

namespace Regula.FaceSDK.WebClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILiveness20Api : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Liveness assessment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">ID of the current liveness transaction.</param>
        /// <returns>TransactionInfo</returns>
        TransactionInfo GetLivenessTransactionInfo (Guid transactionId);

        /// <summary>
        /// Liveness assessment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">ID of the current liveness transaction.</param>
        /// <returns>ApiResponse of TransactionInfo</returns>
        ApiResponse<TransactionInfo> GetLivenessTransactionInfoWithHttpInfo (Guid transactionId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Liveness assessment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">ID of the current liveness transaction.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of TransactionInfo</returns>
        System.Threading.Tasks.Task<TransactionInfo> GetLivenessTransactionInfoAsync (Guid transactionId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Liveness assessment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">ID of the current liveness transaction.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (TransactionInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransactionInfo>> GetLivenessTransactionInfoWithHttpInfoAsync (Guid transactionId, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class Liveness20Api : ILiveness20Api
    {
        private Regula.FaceSDK.WebClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="Liveness20Api"/> class.
        /// </summary>
        /// <returns></returns>
        public Liveness20Api(String basePath)
        {
            this.Configuration = new Regula.FaceSDK.WebClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Regula.FaceSDK.WebClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Liveness20Api"/> class
        /// </summary>
        /// <returns></returns>
        public Liveness20Api()
        {
            this.Configuration = Regula.FaceSDK.WebClient.Client.Configuration.Default;

            ExceptionFactory = Regula.FaceSDK.WebClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Liveness20Api"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public Liveness20Api(Regula.FaceSDK.WebClient.Client.Configuration configuration = null)
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
        /// Liveness assessment 
        /// </summary>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">ID of the current liveness transaction.</param>
        /// <returns>TransactionInfo</returns>
        public TransactionInfo GetLivenessTransactionInfo (Guid transactionId)
        {
             ApiResponse<TransactionInfo> localVarResponse = GetLivenessTransactionInfoWithHttpInfo(transactionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Liveness assessment 
        /// </summary>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">ID of the current liveness transaction.</param>
        /// <returns>ApiResponse of TransactionInfo</returns>
        public ApiResponse<TransactionInfo> GetLivenessTransactionInfoWithHttpInfo (Guid transactionId)
        {
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling Liveness20Api->GetLivenessTransactionInfo");

            var localVarPath = "/api/v2/liveness";
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

            if (transactionId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "transactionId", transactionId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetLivenessTransactionInfo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (TransactionInfo) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransactionInfo)));
        }

        /// <summary>
        /// Liveness assessment 
        /// </summary>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">ID of the current liveness transaction.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of TransactionInfo</returns>
        public async System.Threading.Tasks.Task<TransactionInfo> GetLivenessTransactionInfoAsync (Guid transactionId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<TransactionInfo> localVarResponse = await GetLivenessTransactionInfoWithHttpInfoAsync(transactionId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Liveness assessment 
        /// </summary>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">ID of the current liveness transaction.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (TransactionInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransactionInfo>> GetLivenessTransactionInfoWithHttpInfoAsync (Guid transactionId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling Liveness20Api->GetLivenessTransactionInfo");

            var localVarPath = "/api/v2/liveness";
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

            if (transactionId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "transactionId", transactionId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetLivenessTransactionInfo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (TransactionInfo) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransactionInfo)));
        }

    }
}
