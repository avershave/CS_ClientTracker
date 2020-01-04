using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace TrackerLibrary
{
    public class ClientAPI
    {
        public static List<ClientModel> getClients()
        {
            var client = new RestClient("http://localhost:8000/");

            var request = new RestRequest("client", Method.GET);

            var response = client.Execute(request);

            JObject obs = JObject.Parse(response.Content);
            JArray obj = (JArray)obs["response"];
            List<ClientModel> clientList = obj.ToObject<List<ClientModel>>();

            return clientList;
        }
    }
}
