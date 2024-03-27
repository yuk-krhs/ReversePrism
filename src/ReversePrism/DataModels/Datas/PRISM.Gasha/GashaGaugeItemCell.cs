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
    // 030 TxtItemName                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 GoDone                                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class GashaGaugeItemCell
    {
        public CmnItem?                                 CmnItem                                 { get; set; }
        public UITextMeshProUGUI?                       TxtPrismPoint                           { get; set; }
        public UITextMeshProUGUI?                       TxtItemName                             { get; set; }
        public GameObject?                              GoDone                                  { get; set; }

        public static GashaGaugeItemCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaGaugeItemCell();

            value.CmnItem                                   = GetObject<CmnItem>(new IntPtr(p + 0x020), ReversePrism.DataModels.CmnItem.FromPointer); // 0270D5304E68 0x20 CmnItem                     ( 0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer )
            value.TxtPrismPoint                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5304E88 0x28 TxtPrismPoint               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtItemName                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5304EA8 0x30 TxtItemName                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoDone                                    = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5304EC8 0x38 GoDone                      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
