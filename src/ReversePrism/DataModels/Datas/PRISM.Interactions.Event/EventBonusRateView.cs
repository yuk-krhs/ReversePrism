using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BonusText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ShowDetailButton                         ModelClassType UIButton UIButton UIButton Pointer
    public partial class EventBonusRateView : DataModel
    {
        public UITextMeshProUGUI?                       BonusText                               { get; set; }
        public UIButton?                                ShowDetailButton                        { get; set; }

        public static EventBonusRateView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventBonusRateView() { Pointer= p0 };

            value.BonusText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 BonusText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ShowDetailButton                          = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 ShowDetailButton            ( ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
