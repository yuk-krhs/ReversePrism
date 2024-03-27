using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 ParentRectTransform                      000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 068 BaseIngameTutorialButton                 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 000 AssetPath                                string IL2CPP_TYPE_STRING
    public partial class IngameTutorialPopupContent
    {
        public RectTransform?                           ParentRectTransform                     { get; set; }
        public UIButton?                                BaseIngameTutorialButton                { get; set; }

        public static IngameTutorialPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngameTutorialPopupContent();

            value.ParentRectTransform                       = GetObject<RectTransform>(new IntPtr(p + 0x060), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D5C82BB0 0x60 ParentRectTransform         ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.BaseIngameTutorialButton                  = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5C82BD0 0x68 BaseIngameTutorialButton    ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
