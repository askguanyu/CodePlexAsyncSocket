using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GY.NetAid.Model
{
    public class ServerModeInfo
    {
        public int LocalPort { get; set; }
        public int ReceiveDataBufferSize { get; set; }
        public int ConnectionCapacity { get; set; }
        public bool IsListening { get; set; }
        public List<RemoteClient> RemoteClientList { get; set; }
        public List<ServerModeLog> ServerModeLogList { get; set; }
    }
}
