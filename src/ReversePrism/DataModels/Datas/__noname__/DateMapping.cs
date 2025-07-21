using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 HijriMonthsLengthFlags                   ModelPrimitiveType int int int Int32
    // 018 GregorianDate                            ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class DateMapping : DataModel
    {
        public int                                      HijriMonthsLengthFlags                  { get; set; }
        public DateTime                                 GregorianDate                           { get; set; }

        public static DateMapping? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DateMapping() { Pointer= p0 };

            value.HijriMonthsLengthFlags                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 HijriMonthsLengthFlags      ( ModelPrimitiveType int int int Int32 )
            value.GregorianDate                             = GetDateTime(new IntPtr(p + 0x018)); // 0x18 GregorianDate               ( ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
