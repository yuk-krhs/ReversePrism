using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 1B0 ButtonImg                                ModelClassType Image Image Image Pointer
    // 1B8 WarningIco                               ModelClassType Image Image Image Pointer
    // 1C0 IsInitialized                            ModelPrimitiveType bool bool bool Bool
    // 1C1 IgnoreClick                              ModelPrimitiveType bool bool bool Bool
    // 1C2 ForceInvalidClick                        ModelPrimitiveType bool bool bool Bool
    // 1C3 IsPositive                               ModelPrimitiveType bool bool bool Bool
    // 1C4 IsWarning                                ModelPrimitiveType bool bool bool Bool
    // 1C5 IsFunction                               ModelPrimitiveType bool bool bool Bool
    // 1C6 IsPurchase                               ModelPrimitiveType bool bool bool Bool
    // 1C8 MImageList                               ModelClassListType List`1<Image> List`1<Image> List<Image> Pointer
    // 1D0 MTextList                                ModelClassListType List`1<UITextMeshProUGUI> List`1<UITextMeshProUGUI> List<UITextMeshProUGUI> Pointer
    // 1D8 MStatus                                  ModelEnumType ToggleStatusType ToggleStatusType ToggleStatusType Int32
    // 1DC MColorKind                               ModelEnumType ButtonColorKind ButtonColorKind ButtonColorKind Int32
    // 000 UpdateTextCheck                          Func`3<UITextMeshProUGUI, string, bool> IL2CPP_TYPE_GENERICINST
    // 008 ExchangeTextProcess                      Func`2<string, string> IL2CPP_TYPE_GENERICINST
    public partial class ButtonToggleBase : DataModel
    {
        public Image?                                   ButtonImg                               { get; set; }
        public Image?                                   WarningIco                              { get; set; }
        public bool                                     IsInitialized                           { get; set; }
        public bool                                     IgnoreClick                             { get; set; }
        public bool                                     ForceInvalidClick                       { get; set; }
        public bool                                     IsPositive                              { get; set; }
        public bool                                     IsWarning                               { get; set; }
        public bool                                     IsFunction                              { get; set; }
        public bool                                     IsPurchase                              { get; set; }
        public List<Image>?                             MImageList                              { get; set; }
        public List<UITextMeshProUGUI>?                 MTextList                               { get; set; }
        public ToggleStatusType                         MStatus                                 { get; set; }
        public ButtonColorKind                          MColorKind                              { get; set; }

        public static ButtonToggleBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ButtonToggleBase() { Pointer= p0 };

            value.ButtonImg                                 = GetObject<Image>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.Image.FromPointer); // 0x1B0 ButtonImg                   ( ModelClassType Image Image Image Pointer )
            value.WarningIco                                = GetObject<Image>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.Image.FromPointer); // 0x1B8 WarningIco                  ( ModelClassType Image Image Image Pointer )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x1C0)); // 0x1C0 IsInitialized               ( ModelPrimitiveType bool bool bool Bool )
            value.IgnoreClick                               = GetBool(new IntPtr(p + 0x1C1)); // 0x1C1 IgnoreClick                 ( ModelPrimitiveType bool bool bool Bool )
            value.ForceInvalidClick                         = GetBool(new IntPtr(p + 0x1C2)); // 0x1C2 ForceInvalidClick           ( ModelPrimitiveType bool bool bool Bool )
            value.IsPositive                                = GetBool(new IntPtr(p + 0x1C3)); // 0x1C3 IsPositive                  ( ModelPrimitiveType bool bool bool Bool )
            value.IsWarning                                 = GetBool(new IntPtr(p + 0x1C4)); // 0x1C4 IsWarning                   ( ModelPrimitiveType bool bool bool Bool )
            value.IsFunction                                = GetBool(new IntPtr(p + 0x1C5)); // 0x1C5 IsFunction                  ( ModelPrimitiveType bool bool bool Bool )
            value.IsPurchase                                = GetBool(new IntPtr(p + 0x1C6)); // 0x1C6 IsPurchase                  ( ModelPrimitiveType bool bool bool Bool )
            value.MImageList                                = GetObjectList<Image>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.Image.FromPointer); // 0x1C8 MImageList                  ( ModelClassListType List`1<Image> List`1<Image> List<Image> Pointer )
            value.MTextList                                 = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x1D0 MTextList                   ( ModelClassListType List`1<UITextMeshProUGUI> List`1<UITextMeshProUGUI> List<UITextMeshProUGUI> Pointer )
            value.MStatus                                   = (ToggleStatusType)GetInt32(new IntPtr(p + 0x1D8)); // 0x1D8 MStatus                     ( ModelEnumType ToggleStatusType ToggleStatusType ToggleStatusType Int32 )
            value.MColorKind                                = (ButtonColorKind)GetInt32(new IntPtr(p + 0x1DC)); // 0x1DC MColorKind                  ( ModelEnumType ButtonColorKind ButtonColorKind ButtonColorKind Int32 )

            return value;
        }
    }
}
