using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System;
using System.Net;
using FluentAssertions;

namespace API
{
    public class InfoResource
    {
        private static RestClient RestClient { get; set; }
        private static RestResponse Reponse { get; set; }
        private static RestRequest RestRequest { get; set; }
        private void InitialiseEndpoint()
        {
            var endpointUri = new Uri("https://dog.ceo/api");
            RestClient = new RestClient(endpointUri);
            RestRequest = new RestRequest("/breeds/image/random", Method.Get);
        }
        private void SendGetInfoRequest()
        {
            Reponse = RestClient.Execute(RestRequest);
            Console.WriteLine(JsonConvert.SerializeObject(Reponse.Content, Formatting.Indented));
        }
        private void ValidateResponse()
        {
            Reponse.StatusCode.Should().Be(HttpStatusCode.OK);
        }
        public void SendRequestAndValidateResponse()
        {
            InitialiseEndpoint();
            SendGetInfoRequest();
            ValidateResponse();
        }
    }
}