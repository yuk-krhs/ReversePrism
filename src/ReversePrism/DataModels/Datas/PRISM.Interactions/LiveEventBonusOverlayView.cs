using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DescriptionText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ListView                                 ModelClassType LiveEventBonusListView LiveEventBonusListView LiveEventBonusListView Pointer
    // 030 RateView                                 ModelClassType EventBonusRateView EventBonusRateView EventBonusRateView Pointer
    // 038 ChangeModeButton                         ModelClassType UIButton UIButton UIButton Pointer
    // 040 IdolUpgradingButton                      ModelClassType UIButton UIButton UIButton Pointer
    // 048 BackButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 050 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 058 HowToPlayPopupOpener                     ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer
    // 060 EventId                                  ModelPrimitiveType int int int Int32
    // 068 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class LiveEventBonusOverlayView : DataModel
    {
        public UITextMeshProUGUI?                       DescriptionText                         { get; set; }
        public LiveEventBonusListView?                  ListView                                { get; set; }
        public EventBonusRateView?                      RateView                                { get; set; }
        public UIButton?                                ChangeModeButton                        { get; set; }
        public UIButton?                                IdolUpgradingButton                     { get; set; }
        public UIButton?                                BackButton                              { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public HowToPlayPopupOpener?                    HowToPlayPopupOpener                    { get; set; }
        public int                                      EventId                                 { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }

        public static LiveEventBonusOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventBonusOverlayView() { Pointer= p0 };

            value.DescriptionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 DescriptionText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ListView                                  = GetObject<LiveEventBonusListView>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveEventBonusListView.FromPointer); // 0x28 ListView                    ( ModelClassType LiveEventBonusListView LiveEventBonusListView LiveEventBonusListView Pointer )
            value.RateView                                  = GetObject<EventBonusRateView>(new IntPtr(p + 0x030), ReversePrism.DataModels.EventBonusRateView.FromPointer); // 0x30 RateView                    ( ModelClassType EventBonusRateView EventBonusRateView EventBonusRateView Pointer )
            value.ChangeModeButton                          = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 ChangeModeButton            ( ModelClassType UIButton UIButton UIButton Pointer )
            value.IdolUpgradingButton                       = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 IdolUpgradingButton         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BackButton                                = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0x48 BackButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x050), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x50 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.HowToPlayPopupOpener                      = GetObject<HowToPlayPopupOpener>(new IntPtr(p + 0x058), ReversePrism.DataModels.HowToPlayPopupOpener.FromPointer); // 0x58 HowToPlayPopupOpener        ( ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer )
            value.EventId                                   = GetInt32(new IntPtr(p + 0x060)); // 0x60 EventId                     ( ModelPrimitiveType int int int Int32 )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x068), ReversePrism.DataModels.IDisposable.FromPointer); // 0x68 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
