using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 DeflateStream                            0001866B87A0 ModelClassType DeflateStream DeflateStream DeflateStream Pointer
    public partial class GZipStream
    {
        public DeflateStream?                           DeflateStream                           { get; set; }

        public static GZipStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GZipStream();

            value.DeflateStream                             = GetObject<DeflateStream>(new IntPtr(p + 0x028), ReversePrism.DataModels.DeflateStream.FromPointer); // 0270D7BDAF48 0x28 DeflateStream               ( 0001866B87A0 ModelClassType DeflateStream DeflateStream DeflateStream Pointer )

            return value;
        }
    }
}
