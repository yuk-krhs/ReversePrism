using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum SocketOperation
    {
        Accept,
        Connect,
        Receive,
        ReceiveFrom,
        Send,
        SendTo,
        RecvJustCallback,
        SendJustCallback,
        Disconnect,
        AcceptReceive,
        ReceiveGeneric,
        SendGeneric,
    }
}
