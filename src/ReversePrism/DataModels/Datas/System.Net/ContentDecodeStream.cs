using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 OriginalInnerStream                      000186670BE0 ModelClassType Stream Stream Stream Pointer
    public partial class ContentDecodeStream : DataModel
    {
        public Stream?                                  OriginalInnerStream                     { get; set; }

        public static ContentDecodeStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContentDecodeStream() { Pointer= p0 };

            value.OriginalInnerStream                       = GetObject<Stream>(new IntPtr(p + 0x040), ReversePrism.DataModels.Stream.FromPointer); // 024667AB57D0 0x40 OriginalInnerStream         ( 000186670BE0 ModelClassType Stream Stream Stream Pointer )

            return value;
        }
    }
}
