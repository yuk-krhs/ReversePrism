using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Days                                     0001865C2E50 ModelPrimitiveType double double double Double
    // 018 Months                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C Years                                    0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class TimeSpanUnits
    {
        public double                                   Days                                    { get; set; }
        public int                                      Months                                  { get; set; }
        public int                                      Years                                   { get; set; }

        public static TimeSpanUnits? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeSpanUnits();

            value.Days                                      = GetDouble(new IntPtr(p + 0x010)); // 02700691CAE8 0x10 Days                        ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.Months                                    = GetInt32(new IntPtr(p + 0x018)); // 02700691CB08 0x18 Months                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Years                                     = GetInt32(new IntPtr(p + 0x01C)); // 02700691CB28 0x1C Years                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
