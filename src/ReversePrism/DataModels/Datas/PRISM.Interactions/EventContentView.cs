using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Btn                                      ModelClassType UIButton UIButton UIButton Pointer
    // 028 TxtTitle                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtSummary                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 UiGrayOutController                      ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 040 GoGrayOutText                            ModelClassType GameObject GameObject GameObject Pointer
    // 048 onClick                                  Subject`1<ScenarioID> IL2CPP_TYPE_GENERICINST
    public partial class EventContentView : DataModel
    {
        public UIButton?                                Btn                                     { get; set; }
        public UITextMeshProUGUI?                       TxtTitle                                { get; set; }
        public UITextMeshProUGUI?                       TxtSummary                              { get; set; }
        public UIGrayOutController?                     UiGrayOutController                     { get; set; }
        public GameObject?                              GoGrayOutText                           { get; set; }

        public static EventContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventContentView() { Pointer= p0 };

            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 Btn                         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TxtTitle                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TxtTitle                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtSummary                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtSummary                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UiGrayOutController                       = GetObject<UIGrayOutController>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x38 UiGrayOutController         ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.GoGrayOutText                             = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 GoGrayOutText               ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
