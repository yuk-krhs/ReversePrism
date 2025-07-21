using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Days                                     ModelPrimitiveType double double double Double
    // 018 Months                                   ModelPrimitiveType int int int Int32
    // 01C Years                                    ModelPrimitiveType int int int Int32
    public partial class TimeSpanUnits : DataModel
    {
        public double                                   Days                                    { get; set; }
        public int                                      Months                                  { get; set; }
        public int                                      Years                                   { get; set; }

        public static TimeSpanUnits? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeSpanUnits() { Pointer= p0 };

            value.Days                                      = GetDouble(new IntPtr(p + 0x010)); // 0x10 Days                        ( ModelPrimitiveType double double double Double )
            value.Months                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 Months                      ( ModelPrimitiveType int int int Int32 )
            value.Years                                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Years                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
