using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AllKindArticleCache                      ModelClassType TwestaArticleTemporaryCache TwestaArticleTemporaryCache TwestaArticleTemporaryCache Pointer
    // 018 oneUserArticleCaches                     Dictionary`2<int, TwestaArticleTemporaryCache> IL2CPP_TYPE_GENERICINST
    // 020 ArticleCacheUpdater                      ModelClassType TwestaArticleTemporaryCacheUpdater TwestaArticleTemporaryCacheUpdater TwestaArticleTemporaryCacheUpdater Pointer
    // 028 ArticleCacheWarmer                       ModelClassType TwestaArticleTemporaryCacheWarmer TwestaArticleTemporaryCacheWarmer TwestaArticleTemporaryCacheWarmer Pointer
    public partial class TwestaArticleTemporaryCacheContainer : DataModel
    {
        public TwestaArticleTemporaryCache?             AllKindArticleCache                     { get; set; }
        public TwestaArticleTemporaryCacheUpdater?      ArticleCacheUpdater                     { get; set; }
        public TwestaArticleTemporaryCacheWarmer?       ArticleCacheWarmer                      { get; set; }

        public static TwestaArticleTemporaryCacheContainer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaArticleTemporaryCacheContainer() { Pointer= p0 };

            value.AllKindArticleCache                       = GetObject<TwestaArticleTemporaryCache>(new IntPtr(p + 0x010), ReversePrism.DataModels.TwestaArticleTemporaryCache.FromPointer); // 0x10 AllKindArticleCache         ( ModelClassType TwestaArticleTemporaryCache TwestaArticleTemporaryCache TwestaArticleTemporaryCache Pointer )
            value.ArticleCacheUpdater                       = GetObject<TwestaArticleTemporaryCacheUpdater>(new IntPtr(p + 0x020), ReversePrism.DataModels.TwestaArticleTemporaryCacheUpdater.FromPointer); // 0x20 ArticleCacheUpdater         ( ModelClassType TwestaArticleTemporaryCacheUpdater TwestaArticleTemporaryCacheUpdater TwestaArticleTemporaryCacheUpdater Pointer )
            value.ArticleCacheWarmer                        = GetObject<TwestaArticleTemporaryCacheWarmer>(new IntPtr(p + 0x028), ReversePrism.DataModels.TwestaArticleTemporaryCacheWarmer.FromPointer); // 0x28 ArticleCacheWarmer          ( ModelClassType TwestaArticleTemporaryCacheWarmer TwestaArticleTemporaryCacheWarmer TwestaArticleTemporaryCacheWarmer Pointer )

            return value;
        }
    }
}
