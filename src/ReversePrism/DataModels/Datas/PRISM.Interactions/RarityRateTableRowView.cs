using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Rect                                     000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 TxtRarity                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtNormalRate                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtPromisedRate                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 BgBlue                                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 BgWhite                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class RarityRateTableRowView : DataModel
    {
        public RectTransform?                           Rect                                    { get; set; }
        public UITextMeshProUGUI?                       TxtRarity                               { get; set; }
        public UITextMeshProUGUI?                       TxtNormalRate                           { get; set; }
        public UITextMeshProUGUI?                       TxtPromisedRate                         { get; set; }
        public GameObject?                              BgBlue                                  { get; set; }
        public GameObject?                              BgWhite                                 { get; set; }

        public static RarityRateTableRowView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RarityRateTableRowView() { Pointer= p0 };

            value.Rect                                      = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 02466BA9A6D0 0x20 Rect                        ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.TxtRarity                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BA9A6F0 0x28 TxtRarity                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtNormalRate                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BA9A710 0x30 TxtNormalRate               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtPromisedRate                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BA9A730 0x38 TxtPromisedRate             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BgBlue                                    = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 02466BA9A750 0x40 BgBlue                      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BgWhite                                   = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 02466BA9A770 0x48 BgWhite                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
