using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 num                                      IntPtr IL2CPP_TYPE_PTR
    // 018 NumCount                                 0001865F2F90 ModelPrimitiveType int int int Int32
    // 01C Month                                    0001865F2F90 ModelPrimitiveType int int int Int32
    // 020 Year                                     0001865F2F90 ModelPrimitiveType int int int Int32
    // 024 DayOfWeek                                0001865F2F90 ModelPrimitiveType int int int Int32
    // 028 Era                                      0001865F2F90 ModelPrimitiveType int int int Int32
    // 02C TimeMark                                 0001866EDE10 ModelEnumType TM TM TM Int32
    // 030 Fraction                                 0001865C2BA0 ModelPrimitiveType double double double Double
    // 038 HasSameDateAndTimeSeparators             000186595210 ModelPrimitiveType bool bool bool Bool
    public partial class DateTimeRawInfo
    {
        public int                                      NumCount                                { get; set; }
        public int                                      Month                                   { get; set; }
        public int                                      Year                                    { get; set; }
        public int                                      DayOfWeek                               { get; set; }
        public int                                      Era                                     { get; set; }
        public TM                                       TimeMark                                { get; set; }
        public double                                   Fraction                                { get; set; }
        public bool                                     HasSameDateAndTimeSeparators            { get; set; }

        public static DateTimeRawInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DateTimeRawInfo();

            value.NumCount                                  = GetInt32(new IntPtr(p + 0x018)); // 0270D6994C18 0x18 NumCount                    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Month                                     = GetInt32(new IntPtr(p + 0x01C)); // 0270D6994C38 0x1C Month                       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Year                                      = GetInt32(new IntPtr(p + 0x020)); // 0270D6994C58 0x20 Year                        ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.DayOfWeek                                 = GetInt32(new IntPtr(p + 0x024)); // 0270D6994C78 0x24 DayOfWeek                   ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Era                                       = GetInt32(new IntPtr(p + 0x028)); // 0270D6994C98 0x28 Era                         ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.TimeMark                                  = (TM)GetInt32(new IntPtr(p + 0x02C)); // 0270D6994CB8 0x2C TimeMark                    ( 0001866EDE10 ModelEnumType TM TM TM Int32 )
            value.Fraction                                  = GetDouble(new IntPtr(p + 0x030)); // 0270D6994CD8 0x30 Fraction                    ( 0001865C2BA0 ModelPrimitiveType double double double Double )
            value.HasSameDateAndTimeSeparators              = GetBool(new IntPtr(p + 0x038)); // 0270D6994CF8 0x38 HasSameDateAndTimeSeparators ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
