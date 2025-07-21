using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IsEnableBackKey                          ModelPrimitiveType bool bool bool Bool
    // 021 IsInitialized                            ModelPrimitiveType bool bool bool Bool
    // 028 PopupBaseWindow                          ModelClassType PopupBase PopupBase PopupBase Pointer
    // 030 ClickButtonID                            ModelPrimitiveType int int int Int32
    // 034 WindowSize                               ModelEnumType Vector2 Vector2 Vector2 Int32
    // 03C IsAppearanceReady                        ModelPrimitiveType bool bool bool Bool
    // 040 PopupAssets                              ModelPrimitiveListType string[] string[] List<string> Pointer
    // 048 PopupNames                               ModelPrimitiveListType string[] string[] List<string> Pointer
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

            value.IsEnableBackKey                           = GetBool(new IntPtr(p + 0x020)); // 0x20 IsEnableBackKey             ( ModelPrimitiveType bool bool bool Bool )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x021)); // 0x21 IsInitialized               ( ModelPrimitiveType bool bool bool Bool )
            value.PopupBaseWindow                           = GetObject<PopupBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.PopupBase.FromPointer); // 0x28 PopupBaseWindow             ( ModelClassType PopupBase PopupBase PopupBase Pointer )
            value.ClickButtonID                             = GetInt32(new IntPtr(p + 0x030)); // 0x30 ClickButtonID               ( ModelPrimitiveType int int int Int32 )
            value.WindowSize                                = (Vector2)GetInt32(new IntPtr(p + 0x034)); // 0x34 WindowSize                  ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.IsAppearanceReady                         = GetBool(new IntPtr(p + 0x03C)); // 0x3C IsAppearanceReady           ( ModelPrimitiveType bool bool bool Bool )
            value.PopupAssets                               = GetStringList(new IntPtr(p + 0x040)); // 0x40 PopupAssets                 ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.PopupNames                                = GetStringList(new IntPtr(p + 0x048)); // 0x48 PopupNames                  ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
