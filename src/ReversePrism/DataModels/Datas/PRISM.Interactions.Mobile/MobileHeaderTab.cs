using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabButton                                ModelClassType UIButton UIButton UIButton Pointer
    // 028 ParentOn                                 ModelClassType GameObject GameObject GameObject Pointer
    // 030 OnText                                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 NoticeBadgeOn                            ModelClassType GameObject GameObject GameObject Pointer
    // 040 NoticeBadgeTextOn                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 ParentOff                                ModelClassType GameObject GameObject GameObject Pointer
    // 050 OffText                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 NoticeBadgeOff                           ModelClassType GameObject GameObject GameObject Pointer
    // 060 NoticeBadgeTextOff                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
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

            value.TabButton                                 = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 TabButton                   ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ParentOn                                  = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 ParentOn                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.OnText                                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 OnText                      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NoticeBadgeOn                             = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 NoticeBadgeOn               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.NoticeBadgeTextOn                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 NoticeBadgeTextOn           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ParentOff                                 = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 ParentOff                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.OffText                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 OffText                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NoticeBadgeOff                            = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 NoticeBadgeOff              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.NoticeBadgeTextOff                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 NoticeBadgeTextOff          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
