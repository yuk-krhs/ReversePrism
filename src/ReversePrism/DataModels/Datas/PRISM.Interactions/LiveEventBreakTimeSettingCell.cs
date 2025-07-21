using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   ModelClassType UIButton UIButton UIButton Pointer
    // 028 GrayOutController                        ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 030 SelectedObject                           ModelClassType GameObject GameObject GameObject Pointer
    // 038 UnselectedObject                         ModelClassType GameObject GameObject GameObject Pointer
    // 040 Texts                                    ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    public partial class LiveEventBreakTimeSettingCell : DataModel
    {
        public UIButton?                                Button                                  { get; set; }
        public UIGrayOutController?                     GrayOutController                       { get; set; }
        public GameObject?                              SelectedObject                          { get; set; }
        public GameObject?                              UnselectedObject                        { get; set; }
        public List<UITextMeshProUGUI>?                 Texts                                   { get; set; }

        public static LiveEventBreakTimeSettingCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventBreakTimeSettingCell() { Pointer= p0 };

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 Button                      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x28 GrayOutController           ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.SelectedObject                            = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 SelectedObject              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.UnselectedObject                          = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 UnselectedObject            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Texts                                     = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 Texts                       ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )

            return value;
        }
    }
}
