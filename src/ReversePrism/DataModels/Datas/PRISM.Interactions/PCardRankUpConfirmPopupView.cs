using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 028 RankUpProduceCardPrefab                  ModelClassType RankUpProduceCardContent RankUpProduceCardContent RankUpProduceCardContent Pointer
    // 030 ProduceCardArea                          ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class PCardRankUpConfirmPopupView : DataModel
    {
        public RankUpProduceCardContent?                RankUpProduceCardPrefab                 { get; set; }
        public RectTransform?                           ProduceCardArea                         { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static PCardRankUpConfirmPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PCardRankUpConfirmPopupView() { Pointer= p0 };

            value.RankUpProduceCardPrefab                   = GetObject<RankUpProduceCardContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.RankUpProduceCardContent.FromPointer); // 0x28 RankUpProduceCardPrefab     ( ModelClassType RankUpProduceCardContent RankUpProduceCardContent RankUpProduceCardContent Pointer )
            value.ProduceCardArea                           = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 0x30 ProduceCardArea             ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x38 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
