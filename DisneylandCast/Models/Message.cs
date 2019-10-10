using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DisneylandCast.Models
{
    public class Message
    {
        private string sender;
        private string receiver;
        private string messageText;

        [Required(ErrorMessage = "Please enter your username.")]
        public string Sender
        {
            get { return sender; }
            set { sender = value; }
        }
        [Required(ErrorMessage = "Please enter the recipient of your message.")]
        public string Receiver
        {
            get { return receiver; }
            set { receiver = value; }
        }
        [Required(ErrorMessage = "Please write a message.")]
        public string MessageText
        {
            get { return messageText; }
            set { messageText = value; }
        }
    }
}
