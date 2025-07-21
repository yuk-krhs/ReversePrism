using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Gauge                                    ModelClassType InGameGaugeBase InGameGaugeBase InGameGaugeBase Pointer
    // 018 ValueText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class GaugeParts : DataModel
    {
        public InGameGaugeBase?                         Gauge                                   { get; set; }
        public UITextMeshProUGUI?                       ValueText                               { get; set; }

        public static GaugeParts? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GaugeParts() { Pointer= p0 };

            value.Gauge                                     = GetObject<InGameGaugeBase>(new IntPtr(p + 0x010), ReversePrism.DataModels.InGameGaugeBase.FromPointer); // 0x10 Gauge                       ( ModelClassType InGameGaugeBase InGameGaugeBase InGameGaugeBase Pointer )
            value.ValueText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x018), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x18 ValueText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
