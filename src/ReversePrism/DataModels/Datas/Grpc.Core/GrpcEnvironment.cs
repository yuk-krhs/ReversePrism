using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MinDefaultThreadPoolSize                 int IL2CPP_TYPE_I4
    // 000 DefaultBatchContextPoolSharedCapacity    int IL2CPP_TYPE_I4
    // 000 DefaultBatchContextPoolThreadLocalCapacity int IL2CPP_TYPE_I4
    // 000 DefaultRequestCallContextPoolSharedCapacity int IL2CPP_TYPE_I4
    // 000 DefaultRequestCallContextPoolThreadLocalCapacity int IL2CPP_TYPE_I4
    // 000 staticLock                               <object> IL2CPP_TYPE_OBJECT
    // 008 instance                                 GrpcEnvironment IL2CPP_TYPE_CLASS
    // 010 RefCount                                 ModelPrimitiveType int int int Int32
    // 014 customThreadPoolSize                     Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 01C customCompletionQueueCount               Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 024 InlineHandlers                           ModelPrimitiveType bool bool bool Bool
    // 028 BatchContextPoolSharedCapacity           ModelPrimitiveType int int int Int32
    // 02C BatchContextPoolThreadLocalCapacity      ModelPrimitiveType int int int Int32
    // 030 RequestCallContextPoolSharedCapacity     ModelPrimitiveType int int int Int32
    // 034 RequestCallContextPoolThreadLocalCapacity ModelPrimitiveType int int int Int32
    // 038 registeredChannels                       HashSet`1<Channel> IL2CPP_TYPE_GENERICINST
    // 040 registeredServers                        HashSet`1<Server> IL2CPP_TYPE_GENERICINST
    // 048 NativeInitCounter                        ModelClassType AtomicCounter AtomicCounter AtomicCounter Pointer
    // 050 Logger                                   ModelClassType ILogger ILogger ILogger Pointer
    // 010 batchContextPool                         IObjectPool`1<BatchContextSafeHandle> IL2CPP_TYPE_GENERICINST
    // 018 requestCallContextPool                   IObjectPool`1<RequestCallContextSafeHandle> IL2CPP_TYPE_GENERICINST
    // 020 ThreadPool                               ModelClassType GrpcThreadPool GrpcThreadPool GrpcThreadPool Pointer
    // 028 DebugStats                               ModelClassType DebugStats DebugStats DebugStats Pointer
    // 030 CqPickerCounter                          ModelClassType AtomicCounter AtomicCounter AtomicCounter Pointer
    // 038 IsShutdown                               ModelPrimitiveType bool bool bool Bool
    // 058 ShuttingDown                             ModelClassType EventHandler EventHandler EventHandler Pointer
    public partial class GrpcEnvironment : DataModel
    {
        public int                                      RefCount                                { get; set; }
        public bool                                     InlineHandlers                          { get; set; }
        public int                                      BatchContextPoolSharedCapacity          { get; set; }
        public int                                      BatchContextPoolThreadLocalCapacity     { get; set; }
        public int                                      RequestCallContextPoolSharedCapacity    { get; set; }
        public int                                      RequestCallContextPoolThreadLocalCapacity { get; set; }
        public AtomicCounter?                           NativeInitCounter                       { get; set; }
        public ILogger?                                 Logger                                  { get; set; }
        public GrpcThreadPool?                          ThreadPool                              { get; set; }
        public DebugStats?                              DebugStats                              { get; set; }
        public AtomicCounter?                           CqPickerCounter                         { get; set; }
        public bool                                     IsShutdown                              { get; set; }
        public EventHandler?                            ShuttingDown                            { get; set; }

        public static GrpcEnvironment? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GrpcEnvironment() { Pointer= p0 };

            value.RefCount                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 RefCount                    ( ModelPrimitiveType int int int Int32 )
            value.InlineHandlers                            = GetBool(new IntPtr(p + 0x024)); // 0x24 InlineHandlers              ( ModelPrimitiveType bool bool bool Bool )
            value.BatchContextPoolSharedCapacity            = GetInt32(new IntPtr(p + 0x028)); // 0x28 BatchContextPoolSharedCapacity ( ModelPrimitiveType int int int Int32 )
            value.BatchContextPoolThreadLocalCapacity       = GetInt32(new IntPtr(p + 0x02C)); // 0x2C BatchContextPoolThreadLocalCapacity ( ModelPrimitiveType int int int Int32 )
            value.RequestCallContextPoolSharedCapacity      = GetInt32(new IntPtr(p + 0x030)); // 0x30 RequestCallContextPoolSharedCapacity ( ModelPrimitiveType int int int Int32 )
            value.RequestCallContextPoolThreadLocalCapacity = GetInt32(new IntPtr(p + 0x034)); // 0x34 RequestCallContextPoolThreadLocalCapacity ( ModelPrimitiveType int int int Int32 )
            value.NativeInitCounter                         = GetObject<AtomicCounter>(new IntPtr(p + 0x048), ReversePrism.DataModels.AtomicCounter.FromPointer); // 0x48 NativeInitCounter           ( ModelClassType AtomicCounter AtomicCounter AtomicCounter Pointer )
            value.Logger                                    = GetObject<ILogger>(new IntPtr(p + 0x050), ReversePrism.DataModels.ILogger.FromPointer); // 0x50 Logger                      ( ModelClassType ILogger ILogger ILogger Pointer )
            value.ThreadPool                                = GetObject<GrpcThreadPool>(new IntPtr(p + 0x020), ReversePrism.DataModels.GrpcThreadPool.FromPointer); // 0x20 ThreadPool                  ( ModelClassType GrpcThreadPool GrpcThreadPool GrpcThreadPool Pointer )
            value.DebugStats                                = GetObject<DebugStats>(new IntPtr(p + 0x028), ReversePrism.DataModels.DebugStats.FromPointer); // 0x28 DebugStats                  ( ModelClassType DebugStats DebugStats DebugStats Pointer )
            value.CqPickerCounter                           = GetObject<AtomicCounter>(new IntPtr(p + 0x030), ReversePrism.DataModels.AtomicCounter.FromPointer); // 0x30 CqPickerCounter             ( ModelClassType AtomicCounter AtomicCounter AtomicCounter Pointer )
            value.IsShutdown                                = GetBool(new IntPtr(p + 0x038)); // 0x38 IsShutdown                  ( ModelPrimitiveType bool bool bool Bool )
            value.ShuttingDown                              = GetObject<EventHandler>(new IntPtr(p + 0x058), ReversePrism.DataModels.EventHandler.FromPointer); // 0x58 ShuttingDown                ( ModelClassType EventHandler EventHandler EventHandler Pointer )

            return value;
        }
    }
}
