using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UpdateTiming                             ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32
    // 018 DueTime                                  ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 020 period                                   Nullable`1<TimeSpan> IL2CPP_TYPE_GENERICINST
    // 030 IgnoreTimeScale                          ModelPrimitiveType bool bool bool Bool
    public partial class Timer : DataModel
    {
        public PlayerLoopTiming                         UpdateTiming                            { get; set; }
        public TimeSpan                                 DueTime                                 { get; set; }
        public bool                                     IgnoreTimeScale                         { get; set; }

        public static Timer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Timer() { Pointer= p0 };

            value.UpdateTiming                              = (PlayerLoopTiming)GetInt32(new IntPtr(p + 0x010)); // 0x10 UpdateTiming                ( ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32 )
            value.DueTime                                   = (TimeSpan)GetInt32(new IntPtr(p + 0x018)); // 0x18 DueTime                     ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.IgnoreTimeScale                           = GetBool(new IntPtr(p + 0x030)); // 0x30 IgnoreTimeScale             ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
