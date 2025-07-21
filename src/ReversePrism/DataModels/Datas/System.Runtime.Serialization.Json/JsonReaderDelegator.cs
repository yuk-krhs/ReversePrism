using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 DateTimeFormat                           ModelClassType DateTimeFormat DateTimeFormat DateTimeFormat Pointer
    // 030 DateTimeArrayHelper                      ModelClassType DateTimeArrayJsonHelperWithString DateTimeArrayJsonHelperWithString DateTimeArrayJsonHelperWithString Pointer
    public partial class JsonReaderDelegator : DataModel
    {
        public DateTimeFormat?                          DateTimeFormat                          { get; set; }
        public DateTimeArrayJsonHelperWithString?       DateTimeArrayHelper                     { get; set; }

        public static JsonReaderDelegator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonReaderDelegator() { Pointer= p0 };

            value.DateTimeFormat                            = GetObject<DateTimeFormat>(new IntPtr(p + 0x028), ReversePrism.DataModels.DateTimeFormat.FromPointer); // 0x28 DateTimeFormat              ( ModelClassType DateTimeFormat DateTimeFormat DateTimeFormat Pointer )
            value.DateTimeArrayHelper                       = GetObject<DateTimeArrayJsonHelperWithString>(new IntPtr(p + 0x030), ReversePrism.DataModels.DateTimeArrayJsonHelperWithString.FromPointer); // 0x30 DateTimeArrayHelper         ( ModelClassType DateTimeArrayJsonHelperWithString DateTimeArrayJsonHelperWithString DateTimeArrayJsonHelperWithString Pointer )

            return value;
        }
    }
}
