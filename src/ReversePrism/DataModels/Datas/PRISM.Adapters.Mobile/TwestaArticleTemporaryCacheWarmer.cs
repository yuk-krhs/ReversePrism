using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AllKindArticleCache                      0001866C72F0 ModelClassType TwestaArticleTemporaryCache TwestaArticleTemporaryCache TwestaArticleTemporaryCache Pointer
    public partial class TwestaArticleTemporaryCacheWarmer
    {
        public TwestaArticleTemporaryCache?             AllKindArticleCache                     { get; set; }

        public static TwestaArticleTemporaryCacheWarmer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaArticleTemporaryCacheWarmer();

            value.AllKindArticleCache                       = GetObject<TwestaArticleTemporaryCache>(new IntPtr(p + 0x010), ReversePrism.DataModels.TwestaArticleTemporaryCache.FromPointer); // 0270D68D3FC0 0x10 AllKindArticleCache         ( 0001866C72F0 ModelClassType TwestaArticleTemporaryCache TwestaArticleTemporaryCache TwestaArticleTemporaryCache Pointer )

            return value;
        }
    }
}
