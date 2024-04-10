using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Logger                                   ILogger IL2CPP_TYPE_CLASS
    // 000 FinishContinuationsSleepMillis           int IL2CPP_TYPE_I4
    // 000 MaxFinishContinuationsSleepTotalMillis   int IL2CPP_TYPE_I4
    // 010 Environment                              00018669E6D0 ModelClassType GrpcEnvironment GrpcEnvironment GrpcEnvironment Pointer
    // 018 myLock                                   <object> IL2CPP_TYPE_OBJECT
    // 020 Threads                                  000185D14138 ModelClassListType List`1<Thread> List`1<Thread> List<Thread> Pointer
    // 028 PoolSize                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 02C CompletionQueueCount                     0001865F4260 ModelPrimitiveType int int int Int32
    // 030 InlineHandlers                           0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 038 RunCompletionQueueEventCallbackSuccess   00018653FA50 ModelClassType WaitCallback WaitCallback WaitCallback Pointer
    // 040 RunCompletionQueueEventCallbackFailure   00018653FA50 ModelClassType WaitCallback WaitCallback WaitCallback Pointer
    // 048 QueuedContinuationCounter                00018670DF60 ModelClassType AtomicCounter AtomicCounter AtomicCounter Pointer
    // 050 ThreadProfilers                          000185CCF128 ModelClassListType List`1<BasicProfiler> List`1<BasicProfiler> List<BasicProfiler> Pointer
    // 058 StopRequested                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 060 completionQueues                         IReadOnlyCollection`1<CompletionQueueSafeHandle> IL2CPP_TYPE_GENERICINST
    public partial class GrpcThreadPool : DataModel
    {
        public GrpcEnvironment?                         Environment                             { get; set; }
        public List<Thread>?                            Threads                                 { get; set; }
        public int                                      PoolSize                                { get; set; }
        public int                                      CompletionQueueCount                    { get; set; }
        public bool                                     InlineHandlers                          { get; set; }
        public WaitCallback?                            RunCompletionQueueEventCallbackSuccess  { get; set; }
        public WaitCallback?                            RunCompletionQueueEventCallbackFailure  { get; set; }
        public AtomicCounter?                           QueuedContinuationCounter               { get; set; }
        public List<BasicProfiler>?                     ThreadProfilers                         { get; set; }
        public bool                                     StopRequested                           { get; set; }

        public static GrpcThreadPool? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GrpcThreadPool() { Pointer= p0 };

            value.Environment                               = GetObject<GrpcEnvironment>(new IntPtr(p + 0x010), ReversePrism.DataModels.GrpcEnvironment.FromPointer); // 024660E396A0 0x10 Environment                 ( 00018669E6D0 ModelClassType GrpcEnvironment GrpcEnvironment GrpcEnvironment Pointer )
            value.Threads                                   = GetObjectList<Thread>(new IntPtr(p + 0x020), ReversePrism.DataModels.Thread.FromPointer); // 024660E396E0 0x20 Threads                     ( 000185D14138 ModelClassListType List`1<Thread> List`1<Thread> List<Thread> Pointer )
            value.PoolSize                                  = GetInt32(new IntPtr(p + 0x028)); // 024660E39700 0x28 PoolSize                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CompletionQueueCount                      = GetInt32(new IntPtr(p + 0x02C)); // 024660E39720 0x2C CompletionQueueCount        ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.InlineHandlers                            = GetBool(new IntPtr(p + 0x030)); // 024660E39740 0x30 InlineHandlers              ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.RunCompletionQueueEventCallbackSuccess    = GetObject<WaitCallback>(new IntPtr(p + 0x038), ReversePrism.DataModels.WaitCallback.FromPointer); // 024660E39760 0x38 RunCompletionQueueEventCallbackSuccess ( 00018653FA50 ModelClassType WaitCallback WaitCallback WaitCallback Pointer )
            value.RunCompletionQueueEventCallbackFailure    = GetObject<WaitCallback>(new IntPtr(p + 0x040), ReversePrism.DataModels.WaitCallback.FromPointer); // 024660E39780 0x40 RunCompletionQueueEventCallbackFailure ( 00018653FA50 ModelClassType WaitCallback WaitCallback WaitCallback Pointer )
            value.QueuedContinuationCounter                 = GetObject<AtomicCounter>(new IntPtr(p + 0x048), ReversePrism.DataModels.AtomicCounter.FromPointer); // 024660E397A0 0x48 QueuedContinuationCounter   ( 00018670DF60 ModelClassType AtomicCounter AtomicCounter AtomicCounter Pointer )
            value.ThreadProfilers                           = GetObjectList<BasicProfiler>(new IntPtr(p + 0x050), ReversePrism.DataModels.BasicProfiler.FromPointer); // 024660E397C0 0x50 ThreadProfilers             ( 000185CCF128 ModelClassListType List`1<BasicProfiler> List`1<BasicProfiler> List<BasicProfiler> Pointer )
            value.StopRequested                             = GetBool(new IntPtr(p + 0x058)); // 024660E397E0 0x58 StopRequested               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
