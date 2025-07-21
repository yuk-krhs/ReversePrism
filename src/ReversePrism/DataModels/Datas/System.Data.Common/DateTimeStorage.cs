using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_defaultValue                           DateTime IL2CPP_TYPE_VALUETYPE
    // 050 Values                                   ModelPrimitiveListType DateTime[] DateTime[] List<DateTime> Pointer
    public partial class DateTimeStorage : DataModel
    {
        public List<DateTime>?                          Values                                  { get; set; }

        public static DateTimeStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DateTimeStorage() { Pointer= p0 };

            value.Values                                    = GetDateTimeList(new IntPtr(p + 0x050)); // 0x50 Values                      ( ModelPrimitiveListType DateTime[] DateTime[] List<DateTime> Pointer )

            return value;
        }
    }
}
