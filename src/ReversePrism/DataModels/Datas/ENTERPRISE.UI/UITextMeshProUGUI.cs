using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 7A8 FontColorId                              ModelEnumType TextFontColorId TextFontColorId TextFontColorId Int32
    // 7AC OutlineColorId                           ModelEnumType TextOutlineColorId TextOutlineColorId TextOutlineColorId Int32
    // 7B0 LocalizeOnAwake                          ModelPrimitiveType bool bool bool Bool
    // 7B8 LocalizeKeyword                          ModelPrimitiveType string string string String
    // 7C0 IsDirtyOutlineSize                       ModelPrimitiveType bool bool bool Bool
    // 7C1 IsDirtyOutlineColor                      ModelPrimitiveType bool bool bool Bool
    // 7C2 IsDirtyOverlayText                       ModelPrimitiveType bool bool bool Bool
    // 7C8 OverlayText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 7D0 OverlayRectTransform                     ModelClassType RectTransform RectTransform RectTransform Pointer
    public partial class UITextMeshProUGUI : DataModel
    {
        public TextFontColorId                          FontColorId                             { get; set; }
        public TextOutlineColorId                       OutlineColorId                          { get; set; }
        public bool                                     LocalizeOnAwake                         { get; set; }
        public string                                   LocalizeKeyword                         { get; set; }
        public bool                                     IsDirtyOutlineSize                      { get; set; }
        public bool                                     IsDirtyOutlineColor                     { get; set; }
        public bool                                     IsDirtyOverlayText                      { get; set; }
        public UITextMeshProUGUI?                       OverlayText                             { get; set; }
        public RectTransform?                           OverlayRectTransform                    { get; set; }

        public static UITextMeshProUGUI? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UITextMeshProUGUI() { Pointer= p0 };

            value.FontColorId                               = (TextFontColorId)GetInt32(new IntPtr(p + 0x7A8)); // 0x7A8 FontColorId                 ( ModelEnumType TextFontColorId TextFontColorId TextFontColorId Int32 )
            value.OutlineColorId                            = (TextOutlineColorId)GetInt32(new IntPtr(p + 0x7AC)); // 0x7AC OutlineColorId              ( ModelEnumType TextOutlineColorId TextOutlineColorId TextOutlineColorId Int32 )
            value.LocalizeOnAwake                           = GetBool(new IntPtr(p + 0x7B0)); // 0x7B0 LocalizeOnAwake             ( ModelPrimitiveType bool bool bool Bool )
            value.LocalizeKeyword                           = GetString(new IntPtr(p + 0x7B8)); // 0x7B8 LocalizeKeyword             ( ModelPrimitiveType string string string String )
            value.IsDirtyOutlineSize                        = GetBool(new IntPtr(p + 0x7C0)); // 0x7C0 IsDirtyOutlineSize          ( ModelPrimitiveType bool bool bool Bool )
            value.IsDirtyOutlineColor                       = GetBool(new IntPtr(p + 0x7C1)); // 0x7C1 IsDirtyOutlineColor         ( ModelPrimitiveType bool bool bool Bool )
            value.IsDirtyOverlayText                        = GetBool(new IntPtr(p + 0x7C2)); // 0x7C2 IsDirtyOverlayText          ( ModelPrimitiveType bool bool bool Bool )
            value.OverlayText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x7C8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x7C8 OverlayText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.OverlayRectTransform                      = GetObject<RectTransform>(new IntPtr(p + 0x7D0), ReversePrism.DataModels.RectTransform.FromPointer); // 0x7D0 OverlayRectTransform        ( ModelClassType RectTransform RectTransform RectTransform Pointer )

            return value;
        }
    }
}
