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
    // 010 ActiveCallCounter                        ModelClassType AtomicCounter AtomicCounter AtomicCounter Pointer
    // 018 ServiceDefinitions                       ModelClassType ServiceDefinitionCollection ServiceDefinitionCollection ServiceDefinitionCollection Pointer
    // 020 Ports                                    ModelClassType ServerPortCollection ServerPortCollection ServerPortCollection Pointer
    // 028 Environment                              ModelClassType GrpcEnvironment GrpcEnvironment GrpcEnvironment Pointer
    // 030 Options                                  ModelClassListType List`1<ChannelOption> List`1<ChannelOption> List<ChannelOption> Pointer
    // 038 Handle                                   ModelClassType ServerSafeHandle ServerSafeHandle ServerSafeHandle Pointer
    // 040 myLock                                   <object> IL2CPP_TYPE_OBJECT
    // 048 ServiceDefinitionsList                   ModelClassListType List`1<ServerServiceDefinition> List`1<ServerServiceDefinition> List<ServerServiceDefinition> Pointer
    // 050 ServerPortList                           ModelClassListType List`1<ServerPort> List`1<ServerPort> List<ServerPort> Pointer
    // 058 callHandlers                             Dictionary`2<string, IServerCallHandler> IL2CPP_TYPE_GENERICINST
    // 060 shutdownTcs                              TaskCompletionSource`1<<object>> IL2CPP_TYPE_GENERICINST
    // 068 StartRequested                           ModelPrimitiveType bool bool bool Bool
    // 069 ShutdownRequested                        ModelPrimitiveType bool bool bool Bool
    // 06C RequestCallTokensPerCq                   ModelPrimitiveType int int int Int32
    public partial class Server : DataModel
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
            var value   = new Server() { Pointer= p0 };

            value.ActiveCallCounter                         = GetObject<AtomicCounter>(new IntPtr(p + 0x010), ReversePrism.DataModels.AtomicCounter.FromPointer); // 0x10 ActiveCallCounter           ( ModelClassType AtomicCounter AtomicCounter AtomicCounter Pointer )
            value.ServiceDefinitions                        = GetObject<ServiceDefinitionCollection>(new IntPtr(p + 0x018), ReversePrism.DataModels.ServiceDefinitionCollection.FromPointer); // 0x18 ServiceDefinitions          ( ModelClassType ServiceDefinitionCollection ServiceDefinitionCollection ServiceDefinitionCollection Pointer )
            value.Ports                                     = GetObject<ServerPortCollection>(new IntPtr(p + 0x020), ReversePrism.DataModels.ServerPortCollection.FromPointer); // 0x20 Ports                       ( ModelClassType ServerPortCollection ServerPortCollection ServerPortCollection Pointer )
            value.Environment                               = GetObject<GrpcEnvironment>(new IntPtr(p + 0x028), ReversePrism.DataModels.GrpcEnvironment.FromPointer); // 0x28 Environment                 ( ModelClassType GrpcEnvironment GrpcEnvironment GrpcEnvironment Pointer )
            value.Options                                   = GetObjectList<ChannelOption>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChannelOption.FromPointer); // 0x30 Options                     ( ModelClassListType List`1<ChannelOption> List`1<ChannelOption> List<ChannelOption> Pointer )
            value.Handle                                    = GetObject<ServerSafeHandle>(new IntPtr(p + 0x038), ReversePrism.DataModels.ServerSafeHandle.FromPointer); // 0x38 Handle                      ( ModelClassType ServerSafeHandle ServerSafeHandle ServerSafeHandle Pointer )
            value.ServiceDefinitionsList                    = GetObjectList<ServerServiceDefinition>(new IntPtr(p + 0x048), ReversePrism.DataModels.ServerServiceDefinition.FromPointer); // 0x48 ServiceDefinitionsList      ( ModelClassListType List`1<ServerServiceDefinition> List`1<ServerServiceDefinition> List<ServerServiceDefinition> Pointer )
            value.ServerPortList                            = GetObjectList<ServerPort>(new IntPtr(p + 0x050), ReversePrism.DataModels.ServerPort.FromPointer); // 0x50 ServerPortList              ( ModelClassListType List`1<ServerPort> List`1<ServerPort> List<ServerPort> Pointer )
            value.StartRequested                            = GetBool(new IntPtr(p + 0x068)); // 0x68 StartRequested              ( ModelPrimitiveType bool bool bool Bool )
            value.ShutdownRequested                         = GetBool(new IntPtr(p + 0x069)); // 0x69 ShutdownRequested           ( ModelPrimitiveType bool bool bool Bool )
            value.RequestCallTokensPerCq                    = GetInt32(new IntPtr(p + 0x06C)); // 0x6C RequestCallTokensPerCq      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
