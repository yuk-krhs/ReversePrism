using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Cache                                    ModelClassType TwestaArticleTemporaryCache TwestaArticleTemporaryCache TwestaArticleTemporaryCache Pointer
    // 018 MstTwestaUserId                          ModelPrimitiveType int int int Int32
    public partial class TwestaArticleFetcherForProfile : DataModel
    {
        public TwestaArticleTemporaryCache?             Cache                                   { get; set; }
        public int                                      MstTwestaUserId                         { get; set; }

        public static TwestaArticleFetcherForProfile? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaArticleFetcherForProfile() { Pointer= p0 };

            value.Cache                                     = GetObject<TwestaArticleTemporaryCache>(new IntPtr(p + 0x010), ReversePrism.DataModels.TwestaArticleTemporaryCache.FromPointer); // 0x10 Cache                       ( ModelClassType TwestaArticleTemporaryCache TwestaArticleTemporaryCache TwestaArticleTemporaryCache Pointer )
            value.MstTwestaUserId                           = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstTwestaUserId             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
