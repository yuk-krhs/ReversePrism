using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheCardRankUpReply                     00018671A130 ModelClassType ICardRankUpReply ICardRankUpReply ICardRankUpReply Pointer
    public partial class CardRankUpModel
    {
        public ICardRankUpReply?                        CacheCardRankUpReply                    { get; set; }

        public static CardRankUpModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CardRankUpModel();

            value.CacheCardRankUpReply                      = GetObject<ICardRankUpReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.ICardRankUpReply.FromPointer); // 0270D65AAC30 0x10 CacheCardRankUpReply        ( 00018671A130 ModelClassType ICardRankUpReply ICardRankUpReply ICardRankUpReply Pointer )

            return value;
        }
    }
}
