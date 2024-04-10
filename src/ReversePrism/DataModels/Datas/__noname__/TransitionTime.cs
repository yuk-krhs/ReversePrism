using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TimeOfDay                                0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 018 Month                                    00018659D3E0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 019 Week                                     00018659D3E0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01A Day                                      00018659D3E0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01C DayOfWeek                                000186698200 ModelEnumType DayOfWeek DayOfWeek DayOfWeek Int32
    // 020 IsFixedDateRule                          0001865965D0 ModelPrimitiveType bool bool bool Bool
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

            value.TimeOfDay                                 = GetDateTime(new IntPtr(p + 0x010)); // 0245A3CA9EE0 0x10 TimeOfDay                   ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Month                                     = GetSByte(new IntPtr(p + 0x018)); // 0245A3CA9F00 0x18 Month                       ( 00018659D3E0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Week                                      = GetSByte(new IntPtr(p + 0x019)); // 0245A3CA9F20 0x19 Week                        ( 00018659D3E0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Day                                       = GetSByte(new IntPtr(p + 0x01A)); // 0245A3CA9F40 0x1A Day                         ( 00018659D3E0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.DayOfWeek                                 = (DayOfWeek)GetInt32(new IntPtr(p + 0x01C)); // 0245A3CA9F60 0x1C DayOfWeek                   ( 000186698200 ModelEnumType DayOfWeek DayOfWeek DayOfWeek Int32 )
            value.IsFixedDateRule                           = GetBool(new IntPtr(p + 0x020)); // 0245A3CA9F80 0x20 IsFixedDateRule             ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
