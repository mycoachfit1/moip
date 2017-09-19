using System;
using System.Linq;
using System.Text;

namespace MoipClient
{

    public class OrderEvent
    {
        public DateTime CreatedAt { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }

}
