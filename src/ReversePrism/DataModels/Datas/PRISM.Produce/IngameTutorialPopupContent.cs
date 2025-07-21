using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 ParentRectTransform                      ModelClassType RectTransform RectTransform RectTransform Pointer
    // 068 BaseIngameTutorialButton                 ModelClassType UIButton UIButton UIButton Pointer
    // 000 AssetPath                                string IL2CPP_TYPE_STRING
    public partial class IngameTutorialPopupContent : DataModel
    {
        public RectTransform?                           ParentRectTransform                     { get; set; }
        public UIButton?                                BaseIngameTutorialButton                { get; set; }

        public static IngameTutorialPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngameTutorialPopupContent() { Pointer= p0 };

            value.ParentRectTransform                       = GetObject<RectTransform>(new IntPtr(p + 0x060), ReversePrism.DataModels.RectTransform.FromPointer); // 0x60 ParentRectTransform         ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.BaseIngameTutorialButton                  = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0x68 BaseIngameTutorialButton    ( ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
