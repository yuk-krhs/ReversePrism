using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_timers                                 HashSet`1<Timer> IL2CPP_TYPE_GENERICINST
    // 010 Action                                   0001866792B0 ModelClassType Action Action Action Pointer
    // 018 Timer                                    000186672E70 ModelClassType Timer Timer Timer Pointer
    // 020 Gate                                     0001866F73F0 ModelClassType AsyncLock AsyncLock AsyncLock Pointer
    public partial class PeriodicTimer : DataModel
    {
        public Action?                                  Action                                  { get; set; }
        public Timer?                                   Timer                                   { get; set; }
        public AsyncLock?                               Gate                                    { get; set; }

        public static PeriodicTimer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PeriodicTimer() { Pointer= p0 };

            value.Action                                    = GetObject<Action>(new IntPtr(p + 0x010), ReversePrism.DataModels.Action.FromPointer); // 0246695D6E78 0x10 Action                      ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.Timer                                     = GetObject<Timer>(new IntPtr(p + 0x018), ReversePrism.DataModels.Timer.FromPointer); // 0246695D6E98 0x18 Timer                       ( 000186672E70 ModelClassType Timer Timer Timer Pointer )
            value.Gate                                      = GetObject<AsyncLock>(new IntPtr(p + 0x020), ReversePrism.DataModels.AsyncLock.FromPointer); // 0246695D6EB8 0x20 Gate                        ( 0001866F73F0 ModelClassType AsyncLock AsyncLock AsyncLock Pointer )

            return value;
        }
    }
}
