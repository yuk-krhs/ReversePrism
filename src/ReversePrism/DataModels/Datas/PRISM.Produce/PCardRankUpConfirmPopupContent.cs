using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 RankUpProduceCardPrefab                  00018660D7C0 ModelClassType RankUpProduceCardContent RankUpProduceCardContent RankUpProduceCardContent Pointer
    // 068 ProduceCardArea                          000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    public partial class PCardRankUpConfirmPopupContent : DataModel
    {
        public RankUpProduceCardContent?                RankUpProduceCardPrefab                 { get; set; }
        public RectTransform?                           ProduceCardArea                         { get; set; }

        public static PCardRankUpConfirmPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PCardRankUpConfirmPopupContent() { Pointer= p0 };

            value.RankUpProduceCardPrefab                   = GetObject<RankUpProduceCardContent>(new IntPtr(p + 0x060), ReversePrism.DataModels.RankUpProduceCardContent.FromPointer); // 024665D3C018 0x60 RankUpProduceCardPrefab     ( 00018660D7C0 ModelClassType RankUpProduceCardContent RankUpProduceCardContent RankUpProduceCardContent Pointer )
            value.ProduceCardArea                           = GetObject<RectTransform>(new IntPtr(p + 0x068), ReversePrism.DataModels.RectTransform.FromPointer); // 024665D3C038 0x68 ProduceCardArea             ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )

            return value;
        }
    }
}
