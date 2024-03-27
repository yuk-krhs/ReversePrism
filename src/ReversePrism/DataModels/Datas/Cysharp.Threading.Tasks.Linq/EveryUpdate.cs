using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UpdateTiming                             000186753670 ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32
    public partial class EveryUpdate
    {
        public PlayerLoopTiming                         UpdateTiming                            { get; set; }

        public static EveryUpdate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EveryUpdate();

            value.UpdateTiming                              = (PlayerLoopTiming)GetInt32(new IntPtr(p + 0x010)); // 0270D86583B0 0x10 UpdateTiming                ( 000186753670 ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32 )

            return value;
        }
    }
}
