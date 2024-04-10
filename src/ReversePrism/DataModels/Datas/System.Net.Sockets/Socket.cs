using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AcceptCompletedHandler                   EventHandler`1<SocketAsyncEventArgs> IL2CPP_TYPE_GENERICINST
    // 008 ReceiveCompletedHandler                  EventHandler`1<SocketAsyncEventArgs> IL2CPP_TYPE_GENERICINST
    // 010 SendCompletedHandler                     EventHandler`1<SocketAsyncEventArgs> IL2CPP_TYPE_GENERICINST
    // 018 s_rentedSocketSentinel                   TaskSocketAsyncEventArgs`1<Socket> IL2CPP_TYPE_GENERICINST
    // 020 S_rentedInt32Sentinel                    000186544F30 ModelClassType Int32TaskSocketAsyncEventArgs Int32TaskSocketAsyncEventArgs Int32TaskSocketAsyncEventArgs Pointer
    // 028 s_zeroTask                               Task`1<int> IL2CPP_TYPE_GENERICINST
    // 010 CachedTaskEventArgs                      0001865447B0 ModelClassType CachedEventArgs CachedEventArgs CachedEventArgs Pointer
    // 030 s_InternalSyncObject                     <object> IL2CPP_TYPE_OBJECT
    // 038 S_SupportsIPv4                           000186595E60 ModelPrimitiveType bool bool bool Bool
    // 039 S_SupportsIPv6                           000186595E60 ModelPrimitiveType bool bool bool Bool
    // 03A S_OSSupportsIPv6                         000186595E60 ModelPrimitiveType bool bool bool Bool
    // 03B S_Initialized                            000186595E60 ModelPrimitiveType bool bool bool Bool
    // 03C S_LoggingEnabled                         000186595C30 ModelPrimitiveType bool bool bool Bool
    // 018 Is_closed                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 019 Is_listening                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01C Linger_timeout                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 AddressFamily                            00018668D230 ModelEnumType AddressFamily AddressFamily AddressFamily Int32
    // 024 SocketType                               0001865257A0 ModelEnumType SocketType SocketType SocketType Int32
    // 028 ProtocolType                             0001865D6BD0 ModelEnumType ProtocolType ProtocolType ProtocolType Int32
    // 030 M_Handle                                 0001866BB0F0 ModelClassType SafeSocketHandle SafeSocketHandle SafeSocketHandle Pointer
    // 038 Seed_endpoint                            0001865C6340 ModelClassType EndPoint EndPoint EndPoint Pointer
    // 040 ReadSem                                  000186723890 ModelClassType SemaphoreSlim SemaphoreSlim SemaphoreSlim Pointer
    // 048 WriteSem                                 000186723890 ModelClassType SemaphoreSlim SemaphoreSlim SemaphoreSlim Pointer
    // 050 Is_blocking                              000186595210 ModelPrimitiveType bool bool bool Bool
    // 051 Is_bound                                 000186595210 ModelPrimitiveType bool bool bool Bool
    // 052 Is_connected                             000186595210 ModelPrimitiveType bool bool bool Bool
    // 054 M_IntCleanedUp                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 058 Connect_in_progress                      000186595210 ModelPrimitiveType bool bool bool Bool
    // 040 AcceptAsyncCallback                      0001866EE3E0 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer
    // 048 BeginAcceptCallback                      0001865C4CD0 ModelClassType IOAsyncCallback IOAsyncCallback IOAsyncCallback Pointer
    // 050 BeginAcceptReceiveCallback               0001865C4CD0 ModelClassType IOAsyncCallback IOAsyncCallback IOAsyncCallback Pointer
    // 058 ConnectAsyncCallback                     0001866EE3E0 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer
    // 060 BeginConnectCallback                     0001865C4CD0 ModelClassType IOAsyncCallback IOAsyncCallback IOAsyncCallback Pointer
    // 068 DisconnectAsyncCallback                  0001866EE3E0 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer
    // 070 BeginDisconnectCallback                  0001865C4CD0 ModelClassType IOAsyncCallback IOAsyncCallback IOAsyncCallback Pointer
    // 078 ReceiveAsyncCallback                     0001866EE3E0 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer
    // 080 BeginReceiveCallback                     0001865C4CD0 ModelClassType IOAsyncCallback IOAsyncCallback IOAsyncCallback Pointer
    // 088 BeginReceiveGenericCallback              0001865C4CD0 ModelClassType IOAsyncCallback IOAsyncCallback IOAsyncCallback Pointer
    // 090 ReceiveFromAsyncCallback                 0001866EE3E0 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer
    // 098 BeginReceiveFromCallback                 0001865C4CD0 ModelClassType IOAsyncCallback IOAsyncCallback IOAsyncCallback Pointer
    // 0A0 SendAsyncCallback                        0001866EE3E0 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer
    // 0A8 BeginSendGenericCallback                 0001865C4CD0 ModelClassType IOAsyncCallback IOAsyncCallback IOAsyncCallback Pointer
    // 0B0 SendToAsyncCallback                      0001866EE3E0 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer
    public partial class Socket : DataModel
    {
        public Int32TaskSocketAsyncEventArgs?           S_rentedInt32Sentinel                   { get; set; }
        public CachedEventArgs?                         CachedTaskEventArgs                     { get; set; }
        public bool                                     S_SupportsIPv4                          { get; set; }
        public bool                                     S_SupportsIPv6                          { get; set; }
        public bool                                     S_OSSupportsIPv6                        { get; set; }
        public bool                                     S_Initialized                           { get; set; }
        public bool                                     S_LoggingEnabled                        { get; set; }
        public bool                                     Is_closed                               { get; set; }
        public bool                                     Is_listening                            { get; set; }
        public int                                      Linger_timeout                          { get; set; }
        public AddressFamily                            AddressFamily                           { get; set; }
        public SocketType                               SocketType                              { get; set; }
        public ProtocolType                             ProtocolType                            { get; set; }
        public SafeSocketHandle?                        M_Handle                                { get; set; }
        public EndPoint?                                Seed_endpoint                           { get; set; }
        public SemaphoreSlim?                           ReadSem                                 { get; set; }
        public SemaphoreSlim?                           WriteSem                                { get; set; }
        public bool                                     Is_blocking                             { get; set; }
        public bool                                     Is_bound                                { get; set; }
        public bool                                     Is_connected                            { get; set; }
        public int                                      M_IntCleanedUp                          { get; set; }
        public bool                                     Connect_in_progress                     { get; set; }
        public AsyncCallback?                           AcceptAsyncCallback                     { get; set; }
        public IOAsyncCallback?                         BeginAcceptCallback                     { get; set; }
        public IOAsyncCallback?                         BeginAcceptReceiveCallback              { get; set; }
        public AsyncCallback?                           ConnectAsyncCallback                    { get; set; }
        public IOAsyncCallback?                         BeginConnectCallback                    { get; set; }
        public AsyncCallback?                           DisconnectAsyncCallback                 { get; set; }
        public IOAsyncCallback?                         BeginDisconnectCallback                 { get; set; }
        public AsyncCallback?                           ReceiveAsyncCallback                    { get; set; }
        public IOAsyncCallback?                         BeginReceiveCallback                    { get; set; }
        public IOAsyncCallback?                         BeginReceiveGenericCallback             { get; set; }
        public AsyncCallback?                           ReceiveFromAsyncCallback                { get; set; }
        public IOAsyncCallback?                         BeginReceiveFromCallback                { get; set; }
        public AsyncCallback?                           SendAsyncCallback                       { get; set; }
        public IOAsyncCallback?                         BeginSendGenericCallback                { get; set; }
        public AsyncCallback?                           SendToAsyncCallback                     { get; set; }

        public static Socket? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Socket() { Pointer= p0 };

            value.S_rentedInt32Sentinel                     = GetObject<Int32TaskSocketAsyncEventArgs>(new IntPtr(p + 0x020), ReversePrism.DataModels.Int32TaskSocketAsyncEventArgs.FromPointer); // 0246679A1350 0x20 S_rentedInt32Sentinel       ( 000186544F30 ModelClassType Int32TaskSocketAsyncEventArgs Int32TaskSocketAsyncEventArgs Int32TaskSocketAsyncEventArgs Pointer )
            value.CachedTaskEventArgs                       = GetObject<CachedEventArgs>(new IntPtr(p + 0x010), ReversePrism.DataModels.CachedEventArgs.FromPointer); // 0246679A1390 0x10 CachedTaskEventArgs         ( 0001865447B0 ModelClassType CachedEventArgs CachedEventArgs CachedEventArgs Pointer )
            value.S_SupportsIPv4                            = GetBool(new IntPtr(p + 0x038)); // 0246679A13D0 0x38 S_SupportsIPv4              ( 000186595E60 ModelPrimitiveType bool bool bool Bool )
            value.S_SupportsIPv6                            = GetBool(new IntPtr(p + 0x039)); // 0246679A13F0 0x39 S_SupportsIPv6              ( 000186595E60 ModelPrimitiveType bool bool bool Bool )
            value.S_OSSupportsIPv6                          = GetBool(new IntPtr(p + 0x03A)); // 0246679A1410 0x3A S_OSSupportsIPv6            ( 000186595E60 ModelPrimitiveType bool bool bool Bool )
            value.S_Initialized                             = GetBool(new IntPtr(p + 0x03B)); // 0246679A1430 0x3B S_Initialized               ( 000186595E60 ModelPrimitiveType bool bool bool Bool )
            value.S_LoggingEnabled                          = GetBool(new IntPtr(p + 0x03C)); // 0246679A1450 0x3C S_LoggingEnabled            ( 000186595C30 ModelPrimitiveType bool bool bool Bool )
            value.Is_closed                                 = GetBool(new IntPtr(p + 0x018)); // 0246679A1470 0x18 Is_closed                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Is_listening                              = GetBool(new IntPtr(p + 0x019)); // 0246679A1490 0x19 Is_listening                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Linger_timeout                            = GetInt32(new IntPtr(p + 0x01C)); // 0246679A14B0 0x1C Linger_timeout              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AddressFamily                             = (AddressFamily)GetInt32(new IntPtr(p + 0x020)); // 0246679A14D0 0x20 AddressFamily               ( 00018668D230 ModelEnumType AddressFamily AddressFamily AddressFamily Int32 )
            value.SocketType                                = (SocketType)GetInt32(new IntPtr(p + 0x024)); // 0246679A14F0 0x24 SocketType                  ( 0001865257A0 ModelEnumType SocketType SocketType SocketType Int32 )
            value.ProtocolType                              = (ProtocolType)GetInt32(new IntPtr(p + 0x028)); // 0246679A1510 0x28 ProtocolType                ( 0001865D6BD0 ModelEnumType ProtocolType ProtocolType ProtocolType Int32 )
            value.M_Handle                                  = GetObject<SafeSocketHandle>(new IntPtr(p + 0x030), ReversePrism.DataModels.SafeSocketHandle.FromPointer); // 0246679A1530 0x30 M_Handle                    ( 0001866BB0F0 ModelClassType SafeSocketHandle SafeSocketHandle SafeSocketHandle Pointer )
            value.Seed_endpoint                             = GetObject<EndPoint>(new IntPtr(p + 0x038), ReversePrism.DataModels.EndPoint.FromPointer); // 0246679A1550 0x38 Seed_endpoint               ( 0001865C6340 ModelClassType EndPoint EndPoint EndPoint Pointer )
            value.ReadSem                                   = GetObject<SemaphoreSlim>(new IntPtr(p + 0x040), ReversePrism.DataModels.SemaphoreSlim.FromPointer); // 0246679A1570 0x40 ReadSem                     ( 000186723890 ModelClassType SemaphoreSlim SemaphoreSlim SemaphoreSlim Pointer )
            value.WriteSem                                  = GetObject<SemaphoreSlim>(new IntPtr(p + 0x048), ReversePrism.DataModels.SemaphoreSlim.FromPointer); // 0246679A1590 0x48 WriteSem                    ( 000186723890 ModelClassType SemaphoreSlim SemaphoreSlim SemaphoreSlim Pointer )
            value.Is_blocking                               = GetBool(new IntPtr(p + 0x050)); // 0246679A15B0 0x50 Is_blocking                 ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.Is_bound                                  = GetBool(new IntPtr(p + 0x051)); // 0246679A15D0 0x51 Is_bound                    ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.Is_connected                              = GetBool(new IntPtr(p + 0x052)); // 0246679A15F0 0x52 Is_connected                ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.M_IntCleanedUp                            = GetInt32(new IntPtr(p + 0x054)); // 0246679A1610 0x54 M_IntCleanedUp              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Connect_in_progress                       = GetBool(new IntPtr(p + 0x058)); // 0246679A1630 0x58 Connect_in_progress         ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.AcceptAsyncCallback                       = GetObject<AsyncCallback>(new IntPtr(p + 0x040), ReversePrism.DataModels.AsyncCallback.FromPointer); // 0246679A1650 0x40 AcceptAsyncCallback         ( 0001866EE3E0 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer )
            value.BeginAcceptCallback                       = GetObject<IOAsyncCallback>(new IntPtr(p + 0x048), ReversePrism.DataModels.IOAsyncCallback.FromPointer); // 0246679A1670 0x48 BeginAcceptCallback         ( 0001865C4CD0 ModelClassType IOAsyncCallback IOAsyncCallback IOAsyncCallback Pointer )
            value.BeginAcceptReceiveCallback                = GetObject<IOAsyncCallback>(new IntPtr(p + 0x050), ReversePrism.DataModels.IOAsyncCallback.FromPointer); // 0246679A1690 0x50 BeginAcceptReceiveCallback  ( 0001865C4CD0 ModelClassType IOAsyncCallback IOAsyncCallback IOAsyncCallback Pointer )
            value.ConnectAsyncCallback                      = GetObject<AsyncCallback>(new IntPtr(p + 0x058), ReversePrism.DataModels.AsyncCallback.FromPointer); // 0246679A16B0 0x58 ConnectAsyncCallback        ( 0001866EE3E0 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer )
            value.BeginConnectCallback                      = GetObject<IOAsyncCallback>(new IntPtr(p + 0x060), ReversePrism.DataModels.IOAsyncCallback.FromPointer); // 0246679A16D0 0x60 BeginConnectCallback        ( 0001865C4CD0 ModelClassType IOAsyncCallback IOAsyncCallback IOAsyncCallback Pointer )
            value.DisconnectAsyncCallback                   = GetObject<AsyncCallback>(new IntPtr(p + 0x068), ReversePrism.DataModels.AsyncCallback.FromPointer); // 0246679A16F0 0x68 DisconnectAsyncCallback     ( 0001866EE3E0 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer )
            value.BeginDisconnectCallback                   = GetObject<IOAsyncCallback>(new IntPtr(p + 0x070), ReversePrism.DataModels.IOAsyncCallback.FromPointer); // 0246679A1710 0x70 BeginDisconnectCallback     ( 0001865C4CD0 ModelClassType IOAsyncCallback IOAsyncCallback IOAsyncCallback Pointer )
            value.ReceiveAsyncCallback                      = GetObject<AsyncCallback>(new IntPtr(p + 0x078), ReversePrism.DataModels.AsyncCallback.FromPointer); // 0246679A1730 0x78 ReceiveAsyncCallback        ( 0001866EE3E0 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer )
            value.BeginReceiveCallback                      = GetObject<IOAsyncCallback>(new IntPtr(p + 0x080), ReversePrism.DataModels.IOAsyncCallback.FromPointer); // 0246679A1750 0x80 BeginReceiveCallback        ( 0001865C4CD0 ModelClassType IOAsyncCallback IOAsyncCallback IOAsyncCallback Pointer )
            value.BeginReceiveGenericCallback               = GetObject<IOAsyncCallback>(new IntPtr(p + 0x088), ReversePrism.DataModels.IOAsyncCallback.FromPointer); // 0246679A1770 0x88 BeginReceiveGenericCallback ( 0001865C4CD0 ModelClassType IOAsyncCallback IOAsyncCallback IOAsyncCallback Pointer )
            value.ReceiveFromAsyncCallback                  = GetObject<AsyncCallback>(new IntPtr(p + 0x090), ReversePrism.DataModels.AsyncCallback.FromPointer); // 0246679A1790 0x90 ReceiveFromAsyncCallback    ( 0001866EE3E0 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer )
            value.BeginReceiveFromCallback                  = GetObject<IOAsyncCallback>(new IntPtr(p + 0x098), ReversePrism.DataModels.IOAsyncCallback.FromPointer); // 0246679A17B0 0x98 BeginReceiveFromCallback    ( 0001865C4CD0 ModelClassType IOAsyncCallback IOAsyncCallback IOAsyncCallback Pointer )
            value.SendAsyncCallback                         = GetObject<AsyncCallback>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.AsyncCallback.FromPointer); // 0246679A17D0 0xA0 SendAsyncCallback           ( 0001866EE3E0 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer )
            value.BeginSendGenericCallback                  = GetObject<IOAsyncCallback>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.IOAsyncCallback.FromPointer); // 0246679A17F0 0xA8 BeginSendGenericCallback    ( 0001865C4CD0 ModelClassType IOAsyncCallback IOAsyncCallback IOAsyncCallback Pointer )
            value.SendToAsyncCallback                       = GetObject<AsyncCallback>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.AsyncCallback.FromPointer); // 0246679A1810 0xB0 SendToAsyncCallback         ( 0001866EE3E0 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer )

            return value;
        }
    }
}
