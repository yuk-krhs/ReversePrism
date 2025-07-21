using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_defaultValue                           DateTimeOffset IL2CPP_TYPE_VALUETYPE
    // 050 Values                                   ModelEnumListType DateTimeOffset[] DateTimeOffset[] List<DateTimeOffset> Pointer
    public partial class DateTimeOffsetStorage : DataModel
    {
        public List<DateTimeOffset>?                    Values                                  { get; set; }

        public static DateTimeOffsetStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DateTimeOffsetStorage() { Pointer= p0 };

            value.Values                                    = GetEnumList<DateTimeOffset>(new IntPtr(p + 0x050)); // 0x50 Values                      ( ModelEnumListType DateTimeOffset[] DateTimeOffset[] List<DateTimeOffset> Pointer )

            return value;
        }
    }
}
