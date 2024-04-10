using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 HijriMonthsLengthFlags                   0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 GregorianDate                            0001865B9320 ModelPrimitiveType DateTime DateTime DateTime DateTime
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

            value.HijriMonthsLengthFlags                    = GetInt32(new IntPtr(p + 0x010)); // 024666D8F9E8 0x10 HijriMonthsLengthFlags      ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.GregorianDate                             = GetDateTime(new IntPtr(p + 0x018)); // 024666D8FA08 0x18 GregorianDate               ( 0001865B9320 ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
