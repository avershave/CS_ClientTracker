using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class ClientModel
    {
        public string _id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public AppointmentModel appointment { get; set; }
    }
}
