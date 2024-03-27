using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum MessageType
    {
        Connect,
        Disconnect,
        NewLayout,
        NewDevice,
        NewEvents,
        RemoveDevice,
        RemoveLayout,
        ChangeUsages,
        StartSending,
        StopSending,
    }
}
