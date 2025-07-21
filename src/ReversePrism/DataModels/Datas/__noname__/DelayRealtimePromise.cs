using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<DelayRealtimePromise> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 ModelClassType DelayRealtimePromise DelayRealtimePromise DelayRealtimePromise Pointer
    // 018 DelayTimeSpanTicks                       ModelPrimitiveType long long long Int64
    // 020 Stopwatch                                ModelEnumType ValueStopwatch ValueStopwatch ValueStopwatch Int32
    // 028 CancellationToken                        ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 030 CancellationTokenRegistration            ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32
    // 048 core                                     UniTaskCompletionSourceCore`1<AsyncUnit> IL2CPP_TYPE_GENERICINST
    public partial class DelayRealtimePromise : DataModel
    {
        public DelayRealtimePromise?                    NextNode                                { get; set; }
        public long                                     DelayTimeSpanTicks                      { get; set; }
        public ValueStopwatch                           Stopwatch                               { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public CancellationTokenRegistration            CancellationTokenRegistration           { get; set; }

        public static DelayRealtimePromise? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DelayRealtimePromise() { Pointer= p0 };

            value.NextNode                                  = GetObject<DelayRealtimePromise>(new IntPtr(p + 0x010), ReversePrism.DataModels.DelayRealtimePromise.FromPointer); // 0x10 NextNode                    ( ModelClassType DelayRealtimePromise DelayRealtimePromise DelayRealtimePromise Pointer )
            value.DelayTimeSpanTicks                        = GetInt64(new IntPtr(p + 0x018)); // 0x18 DelayTimeSpanTicks          ( ModelPrimitiveType long long long Int64 )
            value.Stopwatch                                 = (ValueStopwatch)GetInt32(new IntPtr(p + 0x020)); // 0x20 Stopwatch                   ( ModelEnumType ValueStopwatch ValueStopwatch ValueStopwatch Int32 )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x028)); // 0x28 CancellationToken           ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.CancellationTokenRegistration             = (CancellationTokenRegistration)GetInt32(new IntPtr(p + 0x030)); // 0x30 CancellationTokenRegistration ( ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32 )

            return value;
        }
    }
}
