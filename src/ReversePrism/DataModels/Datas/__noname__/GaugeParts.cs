using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Gauge                                    0001866D5710 ModelClassType InGameGaugeBase InGameGaugeBase InGameGaugeBase Pointer
    // 018 ValueText                                0001866F95C0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class GaugeParts
    {
        public InGameGaugeBase?                         Gauge                                   { get; set; }
        public UITextMeshProUGUI?                       ValueText                               { get; set; }

        public static GaugeParts? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GaugeParts();

            value.Gauge                                     = GetObject<InGameGaugeBase>(new IntPtr(p + 0x010), ReversePrism.DataModels.InGameGaugeBase.FromPointer); // 0270D5C56438 0x10 Gauge                       ( 0001866D5710 ModelClassType InGameGaugeBase InGameGaugeBase InGameGaugeBase Pointer )
            value.ValueText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x018), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5C56458 0x18 ValueText                   ( 0001866F95C0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
