using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CmnItem                                  0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer
    // 028 TxtPrismPoint                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 GoDone                                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class PrismGaugeItem
    {
        public CmnItem?                                 CmnItem                                 { get; set; }
        public UITextMeshProUGUI?                       TxtPrismPoint                           { get; set; }
        public GameObject?                              GoDone                                  { get; set; }

        public static PrismGaugeItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrismGaugeItem();

            value.CmnItem                                   = GetObject<CmnItem>(new IntPtr(p + 0x020), ReversePrism.DataModels.CmnItem.FromPointer); // 0270D53DD278 0x20 CmnItem                     ( 0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer )
            value.TxtPrismPoint                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D53DD298 0x28 TxtPrismPoint               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoDone                                    = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270D53DD2B8 0x30 GoDone                      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
