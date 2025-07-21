using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DateStart                                ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 018 DateEnd                                  ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 020 DaylightDelta                            ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 028 DaylightTransitionStart                  ModelEnumType TransitionTime TransitionTime TransitionTime Int32
    // 040 DaylightTransitionEnd                    ModelEnumType TransitionTime TransitionTime TransitionTime Int32
    // 058 BaseUtcOffsetDelta                       ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 060 NoDaylightTransitions                    ModelPrimitiveType bool bool bool Bool
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

            value.DateStart                                 = GetDateTime(new IntPtr(p + 0x010)); // 0x10 DateStart                   ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.DateEnd                                   = GetDateTime(new IntPtr(p + 0x018)); // 0x18 DateEnd                     ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.DaylightDelta                             = (TimeSpan)GetInt32(new IntPtr(p + 0x020)); // 0x20 DaylightDelta               ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.DaylightTransitionStart                   = (TransitionTime)GetInt32(new IntPtr(p + 0x028)); // 0x28 DaylightTransitionStart     ( ModelEnumType TransitionTime TransitionTime TransitionTime Int32 )
            value.DaylightTransitionEnd                     = (TransitionTime)GetInt32(new IntPtr(p + 0x040)); // 0x40 DaylightTransitionEnd       ( ModelEnumType TransitionTime TransitionTime TransitionTime Int32 )
            value.BaseUtcOffsetDelta                        = (TimeSpan)GetInt32(new IntPtr(p + 0x058)); // 0x58 BaseUtcOffsetDelta          ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.NoDaylightTransitions                     = GetBool(new IntPtr(p + 0x060)); // 0x60 NoDaylightTransitions       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
