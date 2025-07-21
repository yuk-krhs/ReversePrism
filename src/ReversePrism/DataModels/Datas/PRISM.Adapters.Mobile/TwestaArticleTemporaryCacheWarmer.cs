using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AllKindArticleCache                      ModelClassType TwestaArticleTemporaryCache TwestaArticleTemporaryCache TwestaArticleTemporaryCache Pointer
    public partial class TwestaArticleTemporaryCacheWarmer : DataModel
    {
        public TwestaArticleTemporaryCache?             AllKindArticleCache                     { get; set; }

        public static TwestaArticleTemporaryCacheWarmer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaArticleTemporaryCacheWarmer() { Pointer= p0 };

            value.AllKindArticleCache                       = GetObject<TwestaArticleTemporaryCache>(new IntPtr(p + 0x010), ReversePrism.DataModels.TwestaArticleTemporaryCache.FromPointer); // 0x10 AllKindArticleCache         ( ModelClassType TwestaArticleTemporaryCache TwestaArticleTemporaryCache TwestaArticleTemporaryCache Pointer )

            return value;
        }
    }
}
