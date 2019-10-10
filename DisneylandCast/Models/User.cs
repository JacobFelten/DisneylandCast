using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneylandCast.Models
{
    public class User
    {
        private List<Message> sentMessages = new List<Message>();
        private List<Message> receivedMessages = new List<Message>();
        private string name;
        
        public List<Message> SentMessages { get { return sentMessages; } }
        public List<Message> ReceivedMessages { get { return receivedMessages; } }
        public string Name { get; set; }
    }
}
