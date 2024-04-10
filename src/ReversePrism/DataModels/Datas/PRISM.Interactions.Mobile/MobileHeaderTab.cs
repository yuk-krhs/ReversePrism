using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabButton                                0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 ParentOn                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 OnText                                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 NoticeBadgeOn                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 NoticeBadgeTextOn                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 ParentOff                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 OffText                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 NoticeBadgeOff                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 NoticeBadgeTextOff                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class MobileHeaderTab : DataModel
    {
        public UIButton?                                TabButton                               { get; set; }
        public GameObject?                              ParentOn                                { get; set; }
        public UITextMeshProUGUI?                       OnText                                  { get; set; }
        public GameObject?                              NoticeBadgeOn                           { get; set; }
        public UITextMeshProUGUI?                       NoticeBadgeTextOn                       { get; set; }
        public GameObject?                              ParentOff                               { get; set; }
        public UITextMeshProUGUI?                       OffText                                 { get; set; }
        public GameObject?                              NoticeBadgeOff                          { get; set; }
        public UITextMeshProUGUI?                       NoticeBadgeTextOff                      { get; set; }

        public static MobileHeaderTab? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileHeaderTab() { Pointer= p0 };

            value.TabButton                                 = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 02466B17C548 0x20 TabButton                   ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ParentOn                                  = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 02466B17C568 0x28 ParentOn                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.OnText                                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B17C588 0x30 OnText                      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NoticeBadgeOn                             = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 02466B17C5A8 0x38 NoticeBadgeOn               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.NoticeBadgeTextOn                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B17C5C8 0x40 NoticeBadgeTextOn           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ParentOff                                 = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 02466B17C5E8 0x48 ParentOff                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.OffText                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B17C608 0x50 OffText                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NoticeBadgeOff                            = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 02466B17C628 0x58 NoticeBadgeOff              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.NoticeBadgeTextOff                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B17C648 0x60 NoticeBadgeTextOff          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
