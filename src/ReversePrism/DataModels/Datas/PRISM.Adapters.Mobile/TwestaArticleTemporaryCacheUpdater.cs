using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Service                                  ModelClassType IMobileService IMobileService IMobileService Pointer
    // 018 AllKindCache                             ModelClassType TwestaArticleTemporaryCache TwestaArticleTemporaryCache TwestaArticleTemporaryCache Pointer
    // 020 oneUserCaches                            IReadOnlyDictionary`2<int, TwestaArticleTemporaryCache> IL2CPP_TYPE_GENERICINST
    public partial class TwestaArticleTemporaryCacheUpdater : DataModel
    {
        public IMobileService?                          Service                                 { get; set; }
        public TwestaArticleTemporaryCache?             AllKindCache                            { get; set; }

        public static TwestaArticleTemporaryCacheUpdater? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaArticleTemporaryCacheUpdater() { Pointer= p0 };

            value.Service                                   = GetObject<IMobileService>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMobileService.FromPointer); // 0x10 Service                     ( ModelClassType IMobileService IMobileService IMobileService Pointer )
            value.AllKindCache                              = GetObject<TwestaArticleTemporaryCache>(new IntPtr(p + 0x018), ReversePrism.DataModels.TwestaArticleTemporaryCache.FromPointer); // 0x18 AllKindCache                ( ModelClassType TwestaArticleTemporaryCache TwestaArticleTemporaryCache TwestaArticleTemporaryCache Pointer )

            return value;
        }
    }
}
