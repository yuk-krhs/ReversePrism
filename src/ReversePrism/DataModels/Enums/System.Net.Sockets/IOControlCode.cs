using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum IOControlCode
    {
        AsyncIO,
        NonBlockingIO,
        DataToRead,
        OobDataRead,
        AssociateHandle,
        EnableCircularQueuing,
        Flush,
        GetBroadcastAddress,
        GetExtensionFunctionPointer,
        GetQos,
        GetGroupQos,
        MultipointLoopback,
        MulticastScope,
        SetQos,
        SetGroupQos,
        TranslateHandle,
        RoutingInterfaceQuery,
        RoutingInterfaceChange,
        AddressListQuery,
        AddressListChange,
        QueryTargetPnpHandle,
        NamespaceChange,
        AddressListSort,
        ReceiveAll,
        ReceiveAllMulticast,
        ReceiveAllIgmpMulticast,
        KeepAliveValues,
        AbsorbRouterAlert,
        UnicastInterface,
        LimitBroadcasts,
        BindToInterface,
        MulticastInterface,
        AddMulticastGroupOnInterface,
        DeleteMulticastGroupFromInterface,
    }
}
