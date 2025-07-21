using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 num                                      IntPtr IL2CPP_TYPE_PTR
    // 018 NumCount                                 ModelPrimitiveType int int int Int32
    // 01C Month                                    ModelPrimitiveType int int int Int32
    // 020 Year                                     ModelPrimitiveType int int int Int32
    // 024 DayOfWeek                                ModelPrimitiveType int int int Int32
    // 028 Era                                      ModelPrimitiveType int int int Int32
    // 02C TimeMark                                 ModelEnumType TM TM TM Int32
    // 030 Fraction                                 ModelPrimitiveType double double double Double
    // 038 HasSameDateAndTimeSeparators             ModelPrimitiveType bool bool bool Bool
    public partial class DateTimeRawInfo : DataModel
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
            var value   = new DateTimeRawInfo() { Pointer= p0 };

            value.NumCount                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 NumCount                    ( ModelPrimitiveType int int int Int32 )
            value.Month                                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Month                       ( ModelPrimitiveType int int int Int32 )
            value.Year                                      = GetInt32(new IntPtr(p + 0x020)); // 0x20 Year                        ( ModelPrimitiveType int int int Int32 )
            value.DayOfWeek                                 = GetInt32(new IntPtr(p + 0x024)); // 0x24 DayOfWeek                   ( ModelPrimitiveType int int int Int32 )
            value.Era                                       = GetInt32(new IntPtr(p + 0x028)); // 0x28 Era                         ( ModelPrimitiveType int int int Int32 )
            value.TimeMark                                  = (TM)GetInt32(new IntPtr(p + 0x02C)); // 0x2C TimeMark                    ( ModelEnumType TM TM TM Int32 )
            value.Fraction                                  = GetDouble(new IntPtr(p + 0x030)); // 0x30 Fraction                    ( ModelPrimitiveType double double double Double )
            value.HasSameDateAndTimeSeparators              = GetBool(new IntPtr(p + 0x038)); // 0x38 HasSameDateAndTimeSeparators ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
