using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GY.NetAid.Model
{
    public class RemoteClient
    {
        public string IP { get; set; }
        public int Port { get; set; }
        public Guid ID { get; set; }
        public DateTime LoginTime{ get; set; }
        public DateTime RefreshTime { get; set; }
    }
}
