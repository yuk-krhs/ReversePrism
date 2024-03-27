using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Entry                                    000185D14388 ModelClassListType List`1<ThumbnailEntry> List`1<ThumbnailEntry> List<ThumbnailEntry> Pointer
    public partial class ThumbnailResult
    {
        public List<ThumbnailEntry>?                    Entry                                   { get; set; }

        public static ThumbnailResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ThumbnailResult();

            value.Entry                                     = GetObjectList<ThumbnailEntry>(new IntPtr(p + 0x010), ReversePrism.DataModels.ThumbnailEntry.FromPointer); // 0270DB4C67B0 0x10 Entry                       ( 000185D14388 ModelClassListType List`1<ThumbnailEntry> List`1<ThumbnailEntry> List<ThumbnailEntry> Pointer )

            return value;
        }
    }
}
