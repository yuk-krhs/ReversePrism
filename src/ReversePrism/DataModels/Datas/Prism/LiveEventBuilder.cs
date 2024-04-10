using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     000186554E10 ModelClassType LiveEventView LiveEventView LiveEventView Pointer
    // 028 RankingFactory                           000186551470 ModelClassType LiveEventRankingOverlayViewFactory LiveEventRankingOverlayViewFactory LiveEventRankingOverlayViewFactory Pointer
    // 030 BonusFactory                             00018654E4A0 ModelClassType LiveEventBonusOverlayViewFactory LiveEventBonusOverlayViewFactory LiveEventBonusOverlayViewFactory Pointer
    // 038 ShopFactory                              000186774550 ModelClassType ShopViewFactory ShopViewFactory ShopViewFactory Pointer
    // 040 ResultFactory                            000186552D60 ModelClassType LiveEventResultPopupViewFactory LiveEventResultPopupViewFactory LiveEventResultPopupViewFactory Pointer
    public partial class LiveEventBuilder : DataModel
    {
        public LiveEventView?                           View                                    { get; set; }
        public LiveEventRankingOverlayViewFactory?      RankingFactory                          { get; set; }
        public LiveEventBonusOverlayViewFactory?        BonusFactory                            { get; set; }
        public ShopViewFactory?                         ShopFactory                             { get; set; }
        public LiveEventResultPopupViewFactory?         ResultFactory                           { get; set; }

        public static LiveEventBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventBuilder() { Pointer= p0 };

            value.View                                      = GetObject<LiveEventView>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveEventView.FromPointer); // 02466B691CC8 0x20 View                        ( 000186554E10 ModelClassType LiveEventView LiveEventView LiveEventView Pointer )
            value.RankingFactory                            = GetObject<LiveEventRankingOverlayViewFactory>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveEventRankingOverlayViewFactory.FromPointer); // 02466B691CE8 0x28 RankingFactory              ( 000186551470 ModelClassType LiveEventRankingOverlayViewFactory LiveEventRankingOverlayViewFactory LiveEventRankingOverlayViewFactory Pointer )
            value.BonusFactory                              = GetObject<LiveEventBonusOverlayViewFactory>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveEventBonusOverlayViewFactory.FromPointer); // 02466B691D08 0x30 BonusFactory                ( 00018654E4A0 ModelClassType LiveEventBonusOverlayViewFactory LiveEventBonusOverlayViewFactory LiveEventBonusOverlayViewFactory Pointer )
            value.ShopFactory                               = GetObject<ShopViewFactory>(new IntPtr(p + 0x038), ReversePrism.DataModels.ShopViewFactory.FromPointer); // 02466B691D28 0x38 ShopFactory                 ( 000186774550 ModelClassType ShopViewFactory ShopViewFactory ShopViewFactory Pointer )
            value.ResultFactory                             = GetObject<LiveEventResultPopupViewFactory>(new IntPtr(p + 0x040), ReversePrism.DataModels.LiveEventResultPopupViewFactory.FromPointer); // 02466B691D48 0x40 ResultFactory               ( 000186552D60 ModelClassType LiveEventResultPopupViewFactory LiveEventResultPopupViewFactory LiveEventResultPopupViewFactory Pointer )

            return value;
        }
    }
}
