using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<DelayRealtimePromise> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 0001867189A0 ModelClassType DelayRealtimePromise DelayRealtimePromise DelayRealtimePromise Pointer
    // 018 DelayTimeSpanTicks                       0001865F7700 ModelPrimitiveType long long long Int64
    // 020 Stopwatch                                00018676AE80 ModelEnumType ValueStopwatch ValueStopwatch ValueStopwatch Int32
    // 028 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 030 core                                     UniTaskCompletionSourceCore`1<AsyncUnit> IL2CPP_TYPE_GENERICINST
    public partial class DelayRealtimePromise
    {
        public DelayRealtimePromise?                    NextNode                                { get; set; }
        public long                                     DelayTimeSpanTicks                      { get; set; }
        public ValueStopwatch                           Stopwatch                               { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }

        public static DelayRealtimePromise? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DelayRealtimePromise();

            value.NextNode                                  = GetObject<DelayRealtimePromise>(new IntPtr(p + 0x010), ReversePrism.DataModels.DelayRealtimePromise.FromPointer); // 0270D8BEC578 0x10 NextNode                    ( 0001867189A0 ModelClassType DelayRealtimePromise DelayRealtimePromise DelayRealtimePromise Pointer )
            value.DelayTimeSpanTicks                        = GetInt64(new IntPtr(p + 0x018)); // 0270D8BEC598 0x18 DelayTimeSpanTicks          ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Stopwatch                                 = (ValueStopwatch)GetInt32(new IntPtr(p + 0x020)); // 0270D8BEC5B8 0x20 Stopwatch                   ( 00018676AE80 ModelEnumType ValueStopwatch ValueStopwatch ValueStopwatch Int32 )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x028)); // 0270D8BEC5D8 0x28 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
