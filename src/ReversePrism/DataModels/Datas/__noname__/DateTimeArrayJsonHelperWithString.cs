using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DateTimeFormat                           ModelClassType DateTimeFormat DateTimeFormat DateTimeFormat Pointer
    public partial class DateTimeArrayJsonHelperWithString : DataModel
    {
        public DateTimeFormat?                          DateTimeFormat                          { get; set; }

        public static DateTimeArrayJsonHelperWithString? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DateTimeArrayJsonHelperWithString() { Pointer= p0 };

            value.DateTimeFormat                            = GetObject<DateTimeFormat>(new IntPtr(p + 0x010), ReversePrism.DataModels.DateTimeFormat.FromPointer); // 0x10 DateTimeFormat              ( ModelClassType DateTimeFormat DateTimeFormat DateTimeFormat Pointer )

            return value;
        }
    }
}
