using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IsEnableBackKey                          000186595960 ModelPrimitiveType bool bool bool Bool
    // 021 IsInitialized                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 PopupBaseWindow                          00018675FC50 ModelClassType PopupBase PopupBase PopupBase Pointer
    // 030 ClickButtonID                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 WindowSize                               0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 03C IsAppearanceReady                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 PopupAssets                              000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 048 PopupNames                               000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 050 customPopup                              AssetCollection`1<PopupContentBase> IL2CPP_TYPE_GENERICINST
    // 000 SizeTypeInfoList                         Dictionary`2<PopupSizeType, SizeTypeInfo> IL2CPP_TYPE_GENERICINST
    public partial class PopupContentBase : DataModel
    {
        public bool                                     IsEnableBackKey                         { get; set; }
        public bool                                     IsInitialized                           { get; set; }
        public PopupBase?                               PopupBaseWindow                         { get; set; }
        public int                                      ClickButtonID                           { get; set; }
        public Vector2                                  WindowSize                              { get; set; }
        public bool                                     IsAppearanceReady                       { get; set; }
        public List<string>?                            PopupAssets                             { get; set; }
        public List<string>?                            PopupNames                              { get; set; }

        public static PopupContentBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PopupContentBase() { Pointer= p0 };

            value.IsEnableBackKey                           = GetBool(new IntPtr(p + 0x020)); // 024660D771B8 0x20 IsEnableBackKey             ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x021)); // 024660D771D8 0x21 IsInitialized               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PopupBaseWindow                           = GetObject<PopupBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.PopupBase.FromPointer); // 024660D771F8 0x28 PopupBaseWindow             ( 00018675FC50 ModelClassType PopupBase PopupBase PopupBase Pointer )
            value.ClickButtonID                             = GetInt32(new IntPtr(p + 0x030)); // 024660D77218 0x30 ClickButtonID               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.WindowSize                                = (Vector2)GetInt32(new IntPtr(p + 0x034)); // 024660D77238 0x34 WindowSize                  ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.IsAppearanceReady                         = GetBool(new IntPtr(p + 0x03C)); // 024660D77258 0x3C IsAppearanceReady           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PopupAssets                               = GetStringList(new IntPtr(p + 0x040)); // 024660D77278 0x40 PopupAssets                 ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.PopupNames                                = GetStringList(new IntPtr(p + 0x048)); // 024660D77298 0x48 PopupNames                  ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
