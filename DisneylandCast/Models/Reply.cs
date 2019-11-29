using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneylandCast.Models
{
    public class Reply
    {
        public int ReplyID { get; set; }
        public string ReplyText { get; set; }
        public DateTime Time { get; set; }
    }
}
