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

            var request = new RestRequest("client/{id}", Method.PUT);

            request.AddUrlSegment("id", "5e10c80cb51d35536c8b1cbb");

            request.AddJsonBody(new
            {
                firstName = "Test",
                lastName = "Test",
                phoneNumber = "Test",
                email = "Test"
            });

            var content = client.Execute(request).Content;
        }
    }
}
