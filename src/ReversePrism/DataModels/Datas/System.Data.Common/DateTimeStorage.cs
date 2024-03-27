using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_defaultValue                           DateTime IL2CPP_TYPE_VALUETYPE
    // 050 Values                                   000185B7C210 ModelPrimitiveListType DateTime[] DateTime[] List<DateTime> Pointer
    public partial class DateTimeStorage
    {
        public List<DateTime>?                          Values                                  { get; set; }

        public static DateTimeStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DateTimeStorage();

            value.Values                                    = GetDateTimeList(new IntPtr(p + 0x050)); // 0270D89AF5F0 0x50 Values                      ( 000185B7C210 ModelPrimitiveListType DateTime[] DateTime[] List<DateTime> Pointer )

            return value;
        }
    }
}
