using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ParsedTimeSpan                           ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 018 ThrowOnFailure                           ModelPrimitiveType bool bool bool Bool
    public partial class TimeSpanResult : DataModel
    {
        public TimeSpan                                 ParsedTimeSpan                          { get; set; }
        public bool                                     ThrowOnFailure                          { get; set; }

        public static TimeSpanResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeSpanResult() { Pointer= p0 };

            value.ParsedTimeSpan                            = (TimeSpan)GetInt32(new IntPtr(p + 0x010)); // 0x10 ParsedTimeSpan              ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.ThrowOnFailure                            = GetBool(new IntPtr(p + 0x018)); // 0x18 ThrowOnFailure              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
