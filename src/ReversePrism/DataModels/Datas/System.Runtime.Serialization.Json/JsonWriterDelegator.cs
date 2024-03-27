using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 DateTimeFormat                           000186695190 ModelClassType DateTimeFormat DateTimeFormat DateTimeFormat Pointer
    public partial class JsonWriterDelegator
    {
        public DateTimeFormat?                          DateTimeFormat                          { get; set; }

        public static JsonWriterDelegator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonWriterDelegator();

            value.DateTimeFormat                            = GetObject<DateTimeFormat>(new IntPtr(p + 0x028), ReversePrism.DataModels.DateTimeFormat.FromPointer); // 027004D911D8 0x28 DateTimeFormat              ( 000186695190 ModelClassType DateTimeFormat DateTimeFormat DateTimeFormat Pointer )

            return value;
        }
    }
}
