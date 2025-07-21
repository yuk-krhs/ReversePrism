using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Curve                                    ModelClassType CacheCurve CacheCurve CacheCurve Pointer
    // 018 RawItems                                 ModelEnumListType List`1<RecordingItem> List`1<RecordingItem> List<RecordingItem> Pointer
    public partial class CacheEntry : DataModel
    {
        public CacheCurve?                              Curve                                   { get; set; }
        public List<RecordingItem>?                     RawItems                                { get; set; }

        public static CacheEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CacheEntry() { Pointer= p0 };

            value.Curve                                     = GetObject<CacheCurve>(new IntPtr(p + 0x010), ReversePrism.DataModels.CacheCurve.FromPointer); // 0x10 Curve                       ( ModelClassType CacheCurve CacheCurve CacheCurve Pointer )
            value.RawItems                                  = GetEnumList<RecordingItem>(new IntPtr(p + 0x018)); // 0x18 RawItems                    ( ModelEnumListType List`1<RecordingItem> List`1<RecordingItem> List<RecordingItem> Pointer )

            return value;
        }
    }
}
