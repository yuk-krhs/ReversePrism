using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 cachedArticles                           Dictionary`2<int, ITwestaArticleStatus> IL2CPP_TYPE_GENERICINST
    // 018 CachedCursor                             ModelClassType TwestaArticleCursor TwestaArticleCursor TwestaArticleCursor Pointer
    public partial class TwestaArticleTemporaryCache : DataModel
    {
        public TwestaArticleCursor?                     CachedCursor                            { get; set; }

        public static TwestaArticleTemporaryCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaArticleTemporaryCache() { Pointer= p0 };

            value.CachedCursor                              = GetObject<TwestaArticleCursor>(new IntPtr(p + 0x018), ReversePrism.DataModels.TwestaArticleCursor.FromPointer); // 0x18 CachedCursor                ( ModelClassType TwestaArticleCursor TwestaArticleCursor TwestaArticleCursor Pointer )

            return value;
        }
    }
}
