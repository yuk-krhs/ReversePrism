using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UpdateTiming                             000186753670 ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32
    // 014 DueTimeFrameCount                        0001865F4260 ModelPrimitiveType int int int Int32
    // 018 periodFrameCount                         Nullable`1<int> IL2CPP_TYPE_GENERICINST
    public partial class TimerFrame : DataModel
    {
        public PlayerLoopTiming                         UpdateTiming                            { get; set; }
        public int                                      DueTimeFrameCount                       { get; set; }

        public static TimerFrame? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimerFrame() { Pointer= p0 };

            value.UpdateTiming                              = (PlayerLoopTiming)GetInt32(new IntPtr(p + 0x010)); // 0246686B3480 0x10 UpdateTiming                ( 000186753670 ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32 )
            value.DueTimeFrameCount                         = GetInt32(new IntPtr(p + 0x014)); // 0246686B34A0 0x14 DueTimeFrameCount           ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
