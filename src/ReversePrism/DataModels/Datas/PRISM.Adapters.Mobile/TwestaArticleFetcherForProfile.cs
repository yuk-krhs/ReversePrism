using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Cache                                    0001866C72F0 ModelClassType TwestaArticleTemporaryCache TwestaArticleTemporaryCache TwestaArticleTemporaryCache Pointer
    // 018 MstTwestaUserId                          0001865F4260 ModelPrimitiveType int int int Int32
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

            value.Cache                                     = GetObject<TwestaArticleTemporaryCache>(new IntPtr(p + 0x010), ReversePrism.DataModels.TwestaArticleTemporaryCache.FromPointer); // 02466694D210 0x10 Cache                       ( 0001866C72F0 ModelClassType TwestaArticleTemporaryCache TwestaArticleTemporaryCache TwestaArticleTemporaryCache Pointer )
            value.MstTwestaUserId                           = GetInt32(new IntPtr(p + 0x018)); // 02466694D230 0x18 MstTwestaUserId             ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
