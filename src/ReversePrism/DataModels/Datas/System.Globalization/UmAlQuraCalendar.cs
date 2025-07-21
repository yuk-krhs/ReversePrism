using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 HijriYearInfo                            DateMapping[] IL2CPP_TYPE_SZARRAY
    // 008 minDate                                  DateTime IL2CPP_TYPE_VALUETYPE
    // 010 MaxDate                                  ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class UmAlQuraCalendar : DataModel
    {
        public DateTime                                 MaxDate                                 { get; set; }

        public static UmAlQuraCalendar? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UmAlQuraCalendar() { Pointer= p0 };

            value.MaxDate                                   = GetDateTime(new IntPtr(p + 0x010)); // 0x10 MaxDate                     ( ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
