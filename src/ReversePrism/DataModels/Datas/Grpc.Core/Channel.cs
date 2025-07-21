using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Logger                                   ILogger IL2CPP_TYPE_CLASS
    // 018 myLock                                   <object> IL2CPP_TYPE_OBJECT
    // 020 ActiveCallCounter                        ModelClassType AtomicCounter AtomicCounter AtomicCounter Pointer
    // 028 ShutdownTokenSource                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Environment                              ModelClassType GrpcEnvironment GrpcEnvironment GrpcEnvironment Pointer
    // 038 CompletionQueue                          ModelClassType CompletionQueueSafeHandle CompletionQueueSafeHandle CompletionQueueSafeHandle Pointer
    // 040 Handle                                   ModelClassType ChannelSafeHandle ChannelSafeHandle ChannelSafeHandle Pointer
    // 048 options                                  Dictionary`2<string, ChannelOption> IL2CPP_TYPE_GENERICINST
    // 050 ShutdownRequested                        ModelPrimitiveType bool bool bool Bool
    // 008 WatchConnectivityStateHandler            BatchCompletionDelegate IL2CPP_TYPE_CLASS
    public partial class Channel : DataModel
    {
        public AtomicCounter?                           ActiveCallCounter                       { get; set; }
        public CancellationTokenSource?                 ShutdownTokenSource                     { get; set; }
        public GrpcEnvironment?                         Environment                             { get; set; }
        public CompletionQueueSafeHandle?               CompletionQueue                         { get; set; }
        public ChannelSafeHandle?                       Handle                                  { get; set; }
        public bool                                     ShutdownRequested                       { get; set; }

        public static Channel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Channel() { Pointer= p0 };

            value.ActiveCallCounter                         = GetObject<AtomicCounter>(new IntPtr(p + 0x020), ReversePrism.DataModels.AtomicCounter.FromPointer); // 0x20 ActiveCallCounter           ( ModelClassType AtomicCounter AtomicCounter AtomicCounter Pointer )
            value.ShutdownTokenSource                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x28 ShutdownTokenSource         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Environment                               = GetObject<GrpcEnvironment>(new IntPtr(p + 0x030), ReversePrism.DataModels.GrpcEnvironment.FromPointer); // 0x30 Environment                 ( ModelClassType GrpcEnvironment GrpcEnvironment GrpcEnvironment Pointer )
            value.CompletionQueue                           = GetObject<CompletionQueueSafeHandle>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompletionQueueSafeHandle.FromPointer); // 0x38 CompletionQueue             ( ModelClassType CompletionQueueSafeHandle CompletionQueueSafeHandle CompletionQueueSafeHandle Pointer )
            value.Handle                                    = GetObject<ChannelSafeHandle>(new IntPtr(p + 0x040), ReversePrism.DataModels.ChannelSafeHandle.FromPointer); // 0x40 Handle                      ( ModelClassType ChannelSafeHandle ChannelSafeHandle ChannelSafeHandle Pointer )
            value.ShutdownRequested                         = GetBool(new IntPtr(p + 0x050)); // 0x50 ShutdownRequested           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
