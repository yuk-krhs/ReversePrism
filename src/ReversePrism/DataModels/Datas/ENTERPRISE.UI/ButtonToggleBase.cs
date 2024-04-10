using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 1B0 ButtonImg                                0001866CCDB0 ModelClassType Image Image Image Pointer
    // 1B8 WarningIco                               0001866CCDB0 ModelClassType Image Image Image Pointer
    // 1C0 IsInitialized                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 1C1 IgnoreClick                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 1C2 ForceInvalidClick                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 1C3 IsPositive                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 1C4 IsWarning                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 1C5 IsFunction                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 1C6 IsPurchase                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 1C8 MImageList                               000185CEAE78 ModelClassListType List`1<Image> List`1<Image> List<Image> Pointer
    // 1D0 MTextList                                000185D18A08 ModelClassListType List`1<UITextMeshProUGUI> List`1<UITextMeshProUGUI> List<UITextMeshProUGUI> Pointer
    // 1D8 MStatus                                  000186686360 ModelEnumType ToggleStatusType ToggleStatusType ToggleStatusType Int32
    // 1DC MColorKind                               000186516030 ModelEnumType ButtonColorKind ButtonColorKind ButtonColorKind Int32
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

            value.ButtonImg                                 = GetObject<Image>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.Image.FromPointer); // 024660CCAA60 0x1B0 ButtonImg                   ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.WarningIco                                = GetObject<Image>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.Image.FromPointer); // 024660CCAA80 0x1B8 WarningIco                  ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x1C0)); // 024660CCAAA0 0x1C0 IsInitialized               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IgnoreClick                               = GetBool(new IntPtr(p + 0x1C1)); // 024660CCAAC0 0x1C1 IgnoreClick                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ForceInvalidClick                         = GetBool(new IntPtr(p + 0x1C2)); // 024660CCAAE0 0x1C2 ForceInvalidClick           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsPositive                                = GetBool(new IntPtr(p + 0x1C3)); // 024660CCAB00 0x1C3 IsPositive                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsWarning                                 = GetBool(new IntPtr(p + 0x1C4)); // 024660CCAB20 0x1C4 IsWarning                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsFunction                                = GetBool(new IntPtr(p + 0x1C5)); // 024660CCAB40 0x1C5 IsFunction                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsPurchase                                = GetBool(new IntPtr(p + 0x1C6)); // 024660CCAB60 0x1C6 IsPurchase                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MImageList                                = GetObjectList<Image>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.Image.FromPointer); // 024660CCAB80 0x1C8 MImageList                  ( 000185CEAE78 ModelClassListType List`1<Image> List`1<Image> List<Image> Pointer )
            value.MTextList                                 = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024660CCABA0 0x1D0 MTextList                   ( 000185D18A08 ModelClassListType List`1<UITextMeshProUGUI> List`1<UITextMeshProUGUI> List<UITextMeshProUGUI> Pointer )
            value.MStatus                                   = (ToggleStatusType)GetInt32(new IntPtr(p + 0x1D8)); // 024660CCABC0 0x1D8 MStatus                     ( 000186686360 ModelEnumType ToggleStatusType ToggleStatusType ToggleStatusType Int32 )
            value.MColorKind                                = (ButtonColorKind)GetInt32(new IntPtr(p + 0x1DC)); // 024660CCABE0 0x1DC MColorKind                  ( 000186516030 ModelEnumType ButtonColorKind ButtonColorKind ButtonColorKind Int32 )

            return value;
        }
    }
}
