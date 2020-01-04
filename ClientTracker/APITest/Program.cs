using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace APITest
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("http://localhost:8000/");

            var request = new RestRequest("client", Method.GET);

            var response = client.Execute(request);

            JObject obs = JObject.Parse(response.Content);
            JArray obj = (JArray)obs["response"];
            Console.WriteLine(obj);
            List<ClientModel> clientList = obj.ToObject<List<ClientModel>>();
            foreach(var o in clientList)
            {
                Console.WriteLine(o.firstName);
            }
        }
    }
}
