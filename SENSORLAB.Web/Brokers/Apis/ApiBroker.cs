﻿
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SENSORLAB.Web.Models;
using RESTFulSense.Clients;
using SENSORLAB.Web.Models.Configuration;

namespace SENSORLAB.Web.Brokers.Apis
{
    public partial class ApiBroker : IApiBroker
    {
        private readonly IRESTFulApiFactoryClient apiClient;
        private readonly HttpClient httpClient;

        public ApiBroker(HttpClient httpClient,
            IConfiguration configuration)
        {
            this.httpClient = httpClient;
            this.apiClient = GetApiClient(configuration);
        }

        private async ValueTask<T> GetAsync<T>(string relativeUrl) =>
            await this.apiClient.GetContentAsync<T>(relativeUrl);

        private async ValueTask<T> PostAsync<T>(string relativeUrl, T content) =>
            await this.apiClient.PostContentAsync<T>(relativeUrl, content);

        private async ValueTask<T> PutAsync<T>(string relativeUrl, T content) =>
            await this.apiClient.PutContentAsync<T>(relativeUrl, content);

        private async ValueTask<T> DeleteAsync<T>(string relativeUrl) =>
            await this.apiClient.DeleteContentAsync<T>(relativeUrl);

        private IRESTFulApiFactoryClient GetApiClient(IConfiguration configuration)
        {
            LocalConfigurations localConfigurations =
                configuration.Get<LocalConfigurations>();

            string apiBaseUrl = localConfigurations.ApiConfigurations.Url;
            this.httpClient.BaseAddress = new Uri(apiBaseUrl);

            return new RESTFulApiFactoryClient(this.httpClient);
        }
    }
}
