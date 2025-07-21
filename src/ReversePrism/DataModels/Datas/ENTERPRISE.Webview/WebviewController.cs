using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AuthStr                                  ModelPrimitiveType string string string String
    // 028 Unitywebviewobj                          ModelClassType NativeWebviewObject NativeWebviewObject NativeWebviewObject Pointer
    // 030 IsInitialized                            ModelPrimitiveType bool bool bool Bool
    // 031 IsPageFinished                           ModelPrimitiveType bool bool bool Bool
    // 032 IsOverrideUrl                            ModelPrimitiveType bool bool bool Bool
    // 033 IsLoadBlankPage                          ModelPrimitiveType bool bool bool Bool
    // 038 TargetUrl                                ModelPrimitiveType string string string String
    // 040 LastUrlPageFinished                      ModelPrimitiveType string string string String
    // 048 LastSchemeOverrideUrl                    ModelPrimitiveType string string string String
    // 050 LastUrlOverrideUrl                       ModelPrimitiveType string string string String
    // 058 LastURL                                  ModelPrimitiveType string string string String
    // 060 OverrideUrlCallBack                      ModelClassType OverrideUrlDelegate OverrideUrlDelegate OverrideUrlDelegate Pointer
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

            value.AuthStr                                   = GetString(new IntPtr(p + 0x020)); // 0x20 AuthStr                     ( ModelPrimitiveType string string string String )
            value.Unitywebviewobj                           = GetObject<NativeWebviewObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.NativeWebviewObject.FromPointer); // 0x28 Unitywebviewobj             ( ModelClassType NativeWebviewObject NativeWebviewObject NativeWebviewObject Pointer )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x030)); // 0x30 IsInitialized               ( ModelPrimitiveType bool bool bool Bool )
            value.IsPageFinished                            = GetBool(new IntPtr(p + 0x031)); // 0x31 IsPageFinished              ( ModelPrimitiveType bool bool bool Bool )
            value.IsOverrideUrl                             = GetBool(new IntPtr(p + 0x032)); // 0x32 IsOverrideUrl               ( ModelPrimitiveType bool bool bool Bool )
            value.IsLoadBlankPage                           = GetBool(new IntPtr(p + 0x033)); // 0x33 IsLoadBlankPage             ( ModelPrimitiveType bool bool bool Bool )
            value.TargetUrl                                 = GetString(new IntPtr(p + 0x038)); // 0x38 TargetUrl                   ( ModelPrimitiveType string string string String )
            value.LastUrlPageFinished                       = GetString(new IntPtr(p + 0x040)); // 0x40 LastUrlPageFinished         ( ModelPrimitiveType string string string String )
            value.LastSchemeOverrideUrl                     = GetString(new IntPtr(p + 0x048)); // 0x48 LastSchemeOverrideUrl       ( ModelPrimitiveType string string string String )
            value.LastUrlOverrideUrl                        = GetString(new IntPtr(p + 0x050)); // 0x50 LastUrlOverrideUrl          ( ModelPrimitiveType string string string String )
            value.LastURL                                   = GetString(new IntPtr(p + 0x058)); // 0x58 LastURL                     ( ModelPrimitiveType string string string String )
            value.OverrideUrlCallBack                       = GetObject<OverrideUrlDelegate>(new IntPtr(p + 0x060), ReversePrism.DataModels.OverrideUrlDelegate.FromPointer); // 0x60 OverrideUrlCallBack         ( ModelClassType OverrideUrlDelegate OverrideUrlDelegate OverrideUrlDelegate Pointer )

            return value;
        }
    }
}
