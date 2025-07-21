using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheCardRankUpReply                     ModelClassType ICardRankUpReply ICardRankUpReply ICardRankUpReply Pointer
    public partial class CardRankUpModel : DataModel
    {
        public ICardRankUpReply?                        CacheCardRankUpReply                    { get; set; }

        public static CardRankUpModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CardRankUpModel() { Pointer= p0 };

            value.CacheCardRankUpReply                      = GetObject<ICardRankUpReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.ICardRankUpReply.FromPointer); // 0x10 CacheCardRankUpReply        ( ModelClassType ICardRankUpReply ICardRankUpReply ICardRankUpReply Pointer )

            return value;
        }
    }
}
