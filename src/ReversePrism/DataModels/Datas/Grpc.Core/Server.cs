using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DefaultRequestCallTokensPerCq            int IL2CPP_TYPE_I4
    // 000 Logger                                   ILogger IL2CPP_TYPE_CLASS
    // 010 ActiveCallCounter                        00018670DF60 ModelClassType AtomicCounter AtomicCounter AtomicCounter Pointer
    // 018 ServiceDefinitions                       00018675F9C0 ModelClassType ServiceDefinitionCollection ServiceDefinitionCollection ServiceDefinitionCollection Pointer
    // 020 Ports                                    00018675F540 ModelClassType ServerPortCollection ServerPortCollection ServerPortCollection Pointer
    // 028 Environment                              00018669E6D0 ModelClassType GrpcEnvironment GrpcEnvironment GrpcEnvironment Pointer
    // 030 Options                                  000185CD1D18 ModelClassListType List`1<ChannelOption> List`1<ChannelOption> List<ChannelOption> Pointer
    // 038 Handle                                   000186735E90 ModelClassType ServerSafeHandle ServerSafeHandle ServerSafeHandle Pointer
    // 040 myLock                                   <object> IL2CPP_TYPE_OBJECT
    // 048 ServiceDefinitionsList                   000185D08388 ModelClassListType List`1<ServerServiceDefinition> List`1<ServerServiceDefinition> List<ServerServiceDefinition> Pointer
    // 050 ServerPortList                           000185D08108 ModelClassListType List`1<ServerPort> List`1<ServerPort> List<ServerPort> Pointer
    // 058 callHandlers                             Dictionary`2<string, IServerCallHandler> IL2CPP_TYPE_GENERICINST
    // 060 shutdownTcs                              TaskCompletionSource`1<<object>> IL2CPP_TYPE_GENERICINST
    // 068 StartRequested                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 069 ShutdownRequested                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 06C RequestCallTokensPerCq                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class Server
    {
        public AtomicCounter?                           ActiveCallCounter                       { get; set; }
        public ServiceDefinitionCollection?             ServiceDefinitions                      { get; set; }
        public ServerPortCollection?                    Ports                                   { get; set; }
        public GrpcEnvironment?                         Environment                             { get; set; }
        public List<ChannelOption>?                     Options                                 { get; set; }
        public ServerSafeHandle?                        Handle                                  { get; set; }
        public List<ServerServiceDefinition>?           ServiceDefinitionsList                  { get; set; }
        public List<ServerPort>?                        ServerPortList                          { get; set; }
        public bool                                     StartRequested                          { get; set; }
        public bool                                     ShutdownRequested                       { get; set; }
        public int                                      RequestCallTokensPerCq                  { get; set; }

        public static Server? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Server();

            value.ActiveCallCounter                         = GetObject<AtomicCounter>(new IntPtr(p + 0x010), ReversePrism.DataModels.AtomicCounter.FromPointer); // 02700406BD90 0x10 ActiveCallCounter           ( 00018670DF60 ModelClassType AtomicCounter AtomicCounter AtomicCounter Pointer )
            value.ServiceDefinitions                        = GetObject<ServiceDefinitionCollection>(new IntPtr(p + 0x018), ReversePrism.DataModels.ServiceDefinitionCollection.FromPointer); // 02700406BDB0 0x18 ServiceDefinitions          ( 00018675F9C0 ModelClassType ServiceDefinitionCollection ServiceDefinitionCollection ServiceDefinitionCollection Pointer )
            value.Ports                                     = GetObject<ServerPortCollection>(new IntPtr(p + 0x020), ReversePrism.DataModels.ServerPortCollection.FromPointer); // 02700406BDD0 0x20 Ports                       ( 00018675F540 ModelClassType ServerPortCollection ServerPortCollection ServerPortCollection Pointer )
            value.Environment                               = GetObject<GrpcEnvironment>(new IntPtr(p + 0x028), ReversePrism.DataModels.GrpcEnvironment.FromPointer); // 02700406BDF0 0x28 Environment                 ( 00018669E6D0 ModelClassType GrpcEnvironment GrpcEnvironment GrpcEnvironment Pointer )
            value.Options                                   = GetObjectList<ChannelOption>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChannelOption.FromPointer); // 02700406BE10 0x30 Options                     ( 000185CD1D18 ModelClassListType List`1<ChannelOption> List`1<ChannelOption> List<ChannelOption> Pointer )
            value.Handle                                    = GetObject<ServerSafeHandle>(new IntPtr(p + 0x038), ReversePrism.DataModels.ServerSafeHandle.FromPointer); // 02700406BE30 0x38 Handle                      ( 000186735E90 ModelClassType ServerSafeHandle ServerSafeHandle ServerSafeHandle Pointer )
            value.ServiceDefinitionsList                    = GetObjectList<ServerServiceDefinition>(new IntPtr(p + 0x048), ReversePrism.DataModels.ServerServiceDefinition.FromPointer); // 02700406BE70 0x48 ServiceDefinitionsList      ( 000185D08388 ModelClassListType List`1<ServerServiceDefinition> List`1<ServerServiceDefinition> List<ServerServiceDefinition> Pointer )
            value.ServerPortList                            = GetObjectList<ServerPort>(new IntPtr(p + 0x050), ReversePrism.DataModels.ServerPort.FromPointer); // 02700406BE90 0x50 ServerPortList              ( 000185D08108 ModelClassListType List`1<ServerPort> List`1<ServerPort> List<ServerPort> Pointer )
            value.StartRequested                            = GetBool(new IntPtr(p + 0x068)); // 02700406BEF0 0x68 StartRequested              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ShutdownRequested                         = GetBool(new IntPtr(p + 0x069)); // 02700406BF10 0x69 ShutdownRequested           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RequestCallTokensPerCq                    = GetInt32(new IntPtr(p + 0x06C)); // 02700406BF30 0x6C RequestCallTokensPerCq      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
