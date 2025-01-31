﻿namespace FrontEnd.Helpers
{
    public class ServiceRepository
    {

        public HttpClient Client { get; set; }

        public ServiceRepository() { 
            Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:5013");
            Client.DefaultRequestHeaders.Add("ApiKey", "12345");
        }

        public ServiceRepository(string token)
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:5013");
            Client.DefaultRequestHeaders.Add("ApiKey", "12345");
            Client.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
        }

        public HttpResponseMessage GetResponse(string url)
        {
            return Client.GetAsync(url).Result;
        }
        public HttpResponseMessage PutResponse(string url, object model)
        {
            return Client.PutAsJsonAsync(url, model).Result;
        }
        public HttpResponseMessage PostResponse(string url, object model)
        {
            return Client.PostAsJsonAsync(url, model).Result;
        }
        public HttpResponseMessage DeleteResponse(string url)
        {
            return Client.DeleteAsync(url).Result;
        }

    }
}
