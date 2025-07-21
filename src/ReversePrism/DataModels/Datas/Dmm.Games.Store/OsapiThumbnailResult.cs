using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Response                                 ModelClassType ThumbnailResult ThumbnailResult ThumbnailResult Pointer
    public partial class OsapiThumbnailResult : DataModel
    {
        public ThumbnailResult?                         Response                                { get; set; }

        public static OsapiThumbnailResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OsapiThumbnailResult() { Pointer= p0 };

            value.Response                                  = GetObject<ThumbnailResult>(new IntPtr(p + 0x040), ReversePrism.DataModels.ThumbnailResult.FromPointer); // 0x40 Response                    ( ModelClassType ThumbnailResult ThumbnailResult ThumbnailResult Pointer )

            return value;
        }
    }
}
