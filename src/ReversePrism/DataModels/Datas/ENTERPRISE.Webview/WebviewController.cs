using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AuthStr                                  000186672F10 ModelPrimitiveType string string string String
    // 028 Unitywebviewobj                          000186695400 ModelClassType NativeWebviewObject NativeWebviewObject NativeWebviewObject Pointer
    // 030 IsInitialized                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 031 IsPageFinished                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 032 IsOverrideUrl                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 033 IsLoadBlankPage                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 TargetUrl                                000186671910 ModelPrimitiveType string string string String
    // 040 LastUrlPageFinished                      000186671910 ModelPrimitiveType string string string String
    // 048 LastSchemeOverrideUrl                    000186671910 ModelPrimitiveType string string string String
    // 050 LastUrlOverrideUrl                       000186671910 ModelPrimitiveType string string string String
    // 058 LastURL                                  000186671910 ModelPrimitiveType string string string String
    // 060 OverrideUrlCallBack                      00018670FE10 ModelClassType OverrideUrlDelegate OverrideUrlDelegate OverrideUrlDelegate Pointer
    // 068 overridePageFinished_                    Action`1<string> IL2CPP_TYPE_GENERICINST
    // 000 isSetHeader                              bool IL2CPP_TYPE_BOOLEAN
    public partial class WebviewController : DataModel
    {
        public string                                   AuthStr                                 { get; set; }
        public NativeWebviewObject?                     Unitywebviewobj                         { get; set; }
        public bool                                     IsInitialized                           { get; set; }
        public bool                                     IsPageFinished                          { get; set; }
        public bool                                     IsOverrideUrl                           { get; set; }
        public bool                                     IsLoadBlankPage                         { get; set; }
        public string                                   TargetUrl                               { get; set; }
        public string                                   LastUrlPageFinished                     { get; set; }
        public string                                   LastSchemeOverrideUrl                   { get; set; }
        public string                                   LastUrlOverrideUrl                      { get; set; }
        public string                                   LastURL                                 { get; set; }
        public OverrideUrlDelegate?                     OverrideUrlCallBack                     { get; set; }

        public static WebviewController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebviewController() { Pointer= p0 };

            value.AuthStr                                   = GetString(new IntPtr(p + 0x020)); // 0245A4434A68 0x20 AuthStr                     ( 000186672F10 ModelPrimitiveType string string string String )
            value.Unitywebviewobj                           = GetObject<NativeWebviewObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.NativeWebviewObject.FromPointer); // 0245A4434A88 0x28 Unitywebviewobj             ( 000186695400 ModelClassType NativeWebviewObject NativeWebviewObject NativeWebviewObject Pointer )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x030)); // 0245A4434AA8 0x30 IsInitialized               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsPageFinished                            = GetBool(new IntPtr(p + 0x031)); // 0245A4434AC8 0x31 IsPageFinished              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsOverrideUrl                             = GetBool(new IntPtr(p + 0x032)); // 0245A4434AE8 0x32 IsOverrideUrl               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsLoadBlankPage                           = GetBool(new IntPtr(p + 0x033)); // 0245A4434B08 0x33 IsLoadBlankPage             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TargetUrl                                 = GetString(new IntPtr(p + 0x038)); // 0245A4434B28 0x38 TargetUrl                   ( 000186671910 ModelPrimitiveType string string string String )
            value.LastUrlPageFinished                       = GetString(new IntPtr(p + 0x040)); // 0245A4434B48 0x40 LastUrlPageFinished         ( 000186671910 ModelPrimitiveType string string string String )
            value.LastSchemeOverrideUrl                     = GetString(new IntPtr(p + 0x048)); // 0245A4434B68 0x48 LastSchemeOverrideUrl       ( 000186671910 ModelPrimitiveType string string string String )
            value.LastUrlOverrideUrl                        = GetString(new IntPtr(p + 0x050)); // 0245A4434B88 0x50 LastUrlOverrideUrl          ( 000186671910 ModelPrimitiveType string string string String )
            value.LastURL                                   = GetString(new IntPtr(p + 0x058)); // 0245A4434BA8 0x58 LastURL                     ( 000186671910 ModelPrimitiveType string string string String )
            value.OverrideUrlCallBack                       = GetObject<OverrideUrlDelegate>(new IntPtr(p + 0x060), ReversePrism.DataModels.OverrideUrlDelegate.FromPointer); // 0245A4434BC8 0x60 OverrideUrlCallBack         ( 00018670FE10 ModelClassType OverrideUrlDelegate OverrideUrlDelegate OverrideUrlDelegate Pointer )

            return value;
        }
    }
}
