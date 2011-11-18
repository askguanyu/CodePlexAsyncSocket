using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GY.NetAid.Model
{
    public class ServerModeLog
    {
        public DateTime LogTime { get; set; }
        public string ReceivedData { get; set; }
        public int ReceivedDataLength { get; set; }
        public Guid ID { get; set; }
    }
}
