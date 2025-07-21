using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Cache                                    ModelClassType TwestaArticleTemporaryCache TwestaArticleTemporaryCache TwestaArticleTemporaryCache Pointer
    public partial class TwestaArticleFetcherForTop : DataModel
    {
        public TwestaArticleTemporaryCache?             Cache                                   { get; set; }

        public static TwestaArticleFetcherForTop? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaArticleFetcherForTop() { Pointer= p0 };

            value.Cache                                     = GetObject<TwestaArticleTemporaryCache>(new IntPtr(p + 0x010), ReversePrism.DataModels.TwestaArticleTemporaryCache.FromPointer); // 0x10 Cache                       ( ModelClassType TwestaArticleTemporaryCache TwestaArticleTemporaryCache TwestaArticleTemporaryCache Pointer )

            return value;
        }
    }
}
