using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DateStart                                0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 018 DateEnd                                  0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 020 DaylightDelta                            00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 028 DaylightTransitionStart                  000186714730 ModelEnumType TransitionTime TransitionTime TransitionTime Int32
    // 040 DaylightTransitionEnd                    000186714730 ModelEnumType TransitionTime TransitionTime TransitionTime Int32
    // 058 BaseUtcOffsetDelta                       00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 060 NoDaylightTransitions                    0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class AdjustmentRule : DataModel
    {
        public DateTime                                 DateStart                               { get; set; }
        public DateTime                                 DateEnd                                 { get; set; }
        public TimeSpan                                 DaylightDelta                           { get; set; }
        public TransitionTime                           DaylightTransitionStart                 { get; set; }
        public TransitionTime                           DaylightTransitionEnd                   { get; set; }
        public TimeSpan                                 BaseUtcOffsetDelta                      { get; set; }
        public bool                                     NoDaylightTransitions                   { get; set; }

        public static AdjustmentRule? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdjustmentRule() { Pointer= p0 };

            value.DateStart                                 = GetDateTime(new IntPtr(p + 0x010)); // 0245A3CA9E00 0x10 DateStart                   ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.DateEnd                                   = GetDateTime(new IntPtr(p + 0x018)); // 0245A3CA9E20 0x18 DateEnd                     ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.DaylightDelta                             = (TimeSpan)GetInt32(new IntPtr(p + 0x020)); // 0245A3CA9E40 0x20 DaylightDelta               ( 00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.DaylightTransitionStart                   = (TransitionTime)GetInt32(new IntPtr(p + 0x028)); // 0245A3CA9E60 0x28 DaylightTransitionStart     ( 000186714730 ModelEnumType TransitionTime TransitionTime TransitionTime Int32 )
            value.DaylightTransitionEnd                     = (TransitionTime)GetInt32(new IntPtr(p + 0x040)); // 0245A3CA9E80 0x40 DaylightTransitionEnd       ( 000186714730 ModelEnumType TransitionTime TransitionTime TransitionTime Int32 )
            value.BaseUtcOffsetDelta                        = (TimeSpan)GetInt32(new IntPtr(p + 0x058)); // 0245A3CA9EA0 0x58 BaseUtcOffsetDelta          ( 00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.NoDaylightTransitions                     = GetBool(new IntPtr(p + 0x060)); // 0245A3CA9EC0 0x60 NoDaylightTransitions       ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
