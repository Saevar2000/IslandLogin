using System;
using System.Collections.Generic;
using System.Text;

namespace IslandLogin.Models
{
    public class Island
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Authentication { get; set; }
        public string IPAddress { get; set; }
        public string ReceiverId { get; set; }
        public string UserAgent { get; set; }
        public string AuthId { get; set; }
        public string Audience { get; set; }
        public string Destination { get; set; }
        public DateTime NotBefore { get; set; }
        public DateTime NotOnOrAfter { get; set; }
    }
}
