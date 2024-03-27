using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Timing                                   000186753670 ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32
    public partial class YieldAwaitable
    {
        public PlayerLoopTiming                         Timing                                  { get; set; }

        public static YieldAwaitable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new YieldAwaitable();

            value.Timing                                    = (PlayerLoopTiming)GetInt32(new IntPtr(p + 0x010)); // 0270D4D9E6E8 0x10 Timing                      ( 000186753670 ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32 )

            return value;
        }
    }
}
