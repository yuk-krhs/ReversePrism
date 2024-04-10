using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Container                                000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 Text                                     0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 ScrollSpeed                              0001866656B0 ModelPrimitiveType float float float Single
    // 038 TextLoopClone                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 Tweener                                  0001866C3DE0 ModelClassType Tweener Tweener Tweener Pointer
    public partial class HorizontalScrollingText : DataModel
    {
        public RectTransform?                           Container                               { get; set; }
        public UITextMeshProUGUI?                       Text                                    { get; set; }
        public float                                    ScrollSpeed                             { get; set; }
        public UITextMeshProUGUI?                       TextLoopClone                           { get; set; }
        public Tweener?                                 Tweener                                 { get; set; }

        public static HorizontalScrollingText? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HorizontalScrollingText() { Pointer= p0 };

            value.Container                                 = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 024664F51C58 0x20 Container                   ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.Text                                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024664F51C78 0x28 Text                        ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScrollSpeed                               = GetSingle(new IntPtr(p + 0x030)); // 024664F51C98 0x30 ScrollSpeed                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TextLoopClone                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024664F51CB8 0x38 TextLoopClone               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Tweener                                   = GetObject<Tweener>(new IntPtr(p + 0x040), ReversePrism.DataModels.Tweener.FromPointer); // 024664F51CD8 0x40 Tweener                     ( 0001866C3DE0 ModelClassType Tweener Tweener Tweener Pointer )

            return value;
        }
    }
}
