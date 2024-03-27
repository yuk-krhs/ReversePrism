using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ProtocolType
    {
        IP,
        IPv6HopByHopOptions,
        Icmp,
        Igmp,
        Ggp,
        IPv4,
        Tcp,
        Pup,
        Udp,
        Idp,
        IPv6,
        IPv6RoutingHeader,
        IPv6FragmentHeader,
        IPSecEncapsulatingSecurityPayload,
        IPSecAuthenticationHeader,
        IcmpV6,
        IPv6NoNextHeader,
        IPv6DestinationOptions,
        ND,
        Raw,
        Unspecified,
        Ipx,
        Spx,
        SpxII,
        Unknown,
    }
}
