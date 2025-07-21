using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TimeOfDay                                ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 018 Month                                    ModelPrimitiveType sbyte sbyte sbyte SByte
    // 019 Week                                     ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01A Day                                      ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01C DayOfWeek                                ModelEnumType DayOfWeek DayOfWeek DayOfWeek Int32
    // 020 IsFixedDateRule                          ModelPrimitiveType bool bool bool Bool
    public partial class TransitionTime : DataModel
    {
        public DateTime                                 TimeOfDay                               { get; set; }
        public sbyte                                    Month                                   { get; set; }
        public sbyte                                    Week                                    { get; set; }
        public sbyte                                    Day                                     { get; set; }
        public DayOfWeek                                DayOfWeek                               { get; set; }
        public bool                                     IsFixedDateRule                         { get; set; }

        public static TransitionTime? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransitionTime() { Pointer= p0 };

            value.TimeOfDay                                 = GetDateTime(new IntPtr(p + 0x010)); // 0x10 TimeOfDay                   ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Month                                     = GetSByte(new IntPtr(p + 0x018)); // 0x18 Month                       ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Week                                      = GetSByte(new IntPtr(p + 0x019)); // 0x19 Week                        ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Day                                       = GetSByte(new IntPtr(p + 0x01A)); // 0x1A Day                         ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.DayOfWeek                                 = (DayOfWeek)GetInt32(new IntPtr(p + 0x01C)); // 0x1C DayOfWeek                   ( ModelEnumType DayOfWeek DayOfWeek DayOfWeek Int32 )
            value.IsFixedDateRule                           = GetBool(new IntPtr(p + 0x020)); // 0x20 IsFixedDateRule             ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
