using System;
using System.Linq;
using System.Text;

namespace Moip.Net4
{

    public class OrderEvent
    {
        public DateTime CreatedAt { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }

}
