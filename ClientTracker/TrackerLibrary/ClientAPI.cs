using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
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

        public static MessageModel postClient(string firstName, string lastName, string phoneNumber, string email)
        {
            var client = new RestClient("http://localhost:8000/");

            var request = new RestRequest("client", Method.POST);

            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new { firstName = firstName,
                                      lastName = lastName,
                                      phoneNumber = phoneNumber,
                                      email = email});

            var response = client.Execute(request);

            JObject obj = JObject.Parse(response.Content);

            MessageModel msg = obj.ToObject<MessageModel>();

            return msg;

        }

        public static bool deleteClient(ClientModel c)
        {
            var client = new RestClient("http://localhost:8000/");

            var request = new RestRequest("client/{id}", Method.DELETE);

            request.AddUrlSegment("id", c._id);

            var response = client.Execute(request);

            JObject obj = JObject.Parse(response.Content);

            MessageModel msg = obj.ToObject<MessageModel>();

            if (!msg.msgError)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static bool updateClient(ClientModel c, string NewfirstName, string NewlastName, string NewphoneNumber, string Newemail)
        {
            var client = new RestClient("http://localhost:8000/");

            var request = new RestRequest("client/{id}", Method.PUT);

            request.AddUrlSegment("id", c._id);

            request.AddJsonBody(new
            {
                firstName = NewfirstName,
                lastName = NewlastName,
                phoneNumber = NewphoneNumber,
                email = Newemail
            });

            var response = client.Execute(request);

            JObject obj = JObject.Parse(response.Content);

            MessageModel msg = obj.ToObject<MessageModel>();

            if (!msg.msgError)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool updateAppointment(ClientModel c, DateTime d, DateTime t, string s)
        {
            var client = new RestClient("http://localhost:8000/");

            var request = new RestRequest("client/{id}", Method.PUT);

            request.AddUrlSegment("id", c._id);

            AppointmentModel a = new AppointmentModel();
            t.ToLocalTime();
            DateTime dt = d.Add(t.TimeOfDay);
            a.date = dt;
            a.description = s;
            c.appointment = a;
            string jsonRequest = JsonConvert.SerializeObject(c);

            request.AddParameter("application/json; charset=utf-8", jsonRequest, ParameterType.RequestBody);

            var response = client.Execute(request);
            JObject obj = JObject.Parse(response.Content);

            MessageModel msg = obj.ToObject<MessageModel>();

            if (!msg.msgError)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
