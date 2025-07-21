using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0E8 ExchangeCountProductIcon                 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 0F0 ExchangeCountText                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0F8 onClick                                  Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 100 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ExchangeSelectionConfirmPopupView : DataModel
    {
        public RewardItem?                              ExchangeCountProductIcon                { get; set; }
        public UITextMeshProUGUI?                       ExchangeCountText                       { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ExchangeSelectionConfirmPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeSelectionConfirmPopupView() { Pointer= p0 };

            value.ExchangeCountProductIcon                  = GetObject<RewardItem>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.RewardItem.FromPointer); // 0xE8 ExchangeCountProductIcon    ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.ExchangeCountText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xF0 ExchangeCountText           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x100), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x100 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
