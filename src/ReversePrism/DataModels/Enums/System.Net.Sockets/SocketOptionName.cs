using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum SocketOptionName
    {
        Debug,
        AcceptConnection,
        ReuseAddress,
        KeepAlive,
        DontRoute,
        Broadcast,
        UseLoopback,
        Linger,
        OutOfBandInline,
        DontLinger,
        ExclusiveAddressUse,
        SendBuffer,
        ReceiveBuffer,
        SendLowWater,
        ReceiveLowWater,
        SendTimeout,
        ReceiveTimeout,
        Error,
        Type,
        ReuseUnicastPort,
        MaxConnections,
        IPOptions,
        HeaderIncluded,
        TypeOfService,
        IpTimeToLive,
        MulticastInterface,
        MulticastTimeToLive,
        MulticastLoopback,
        AddMembership,
        DropMembership,
        DontFragment,
        AddSourceMembership,
        DropSourceMembership,
        BlockSource,
        UnblockSource,
        PacketInformation,
        HopLimit,
        IPProtectionLevel,
        IPv6Only,
        NoDelay,
        BsdUrgent,
        Expedited,
        NoChecksum,
        ChecksumCoverage,
        UpdateAcceptContext,
        UpdateConnectContext,
    }
}
