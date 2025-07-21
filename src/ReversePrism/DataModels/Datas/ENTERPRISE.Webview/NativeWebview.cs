using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Webview                                  ModelClassType NativeWebviewObject NativeWebviewObject NativeWebviewObject Pointer
    // 028 InitURL                                  ModelPrimitiveType string string string String
    // 030 CameraObject                             ModelClassType Camera Camera Camera Pointer
    // 038 Webviewrect                              ModelEnumType Rect Rect Rect Int32
    public partial class NativeWebview : DataModel
    {
        public NativeWebviewObject?                     Webview                                 { get; set; }
        public string                                   InitURL                                 { get; set; }
        public Camera?                                  CameraObject                            { get; set; }
        public Rect                                     Webviewrect                             { get; set; }

        public static NativeWebview? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeWebview() { Pointer= p0 };

            value.Webview                                   = GetObject<NativeWebviewObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.NativeWebviewObject.FromPointer); // 0x20 Webview                     ( ModelClassType NativeWebviewObject NativeWebviewObject NativeWebviewObject Pointer )
            value.InitURL                                   = GetString(new IntPtr(p + 0x028)); // 0x28 InitURL                     ( ModelPrimitiveType string string string String )
            value.CameraObject                              = GetObject<Camera>(new IntPtr(p + 0x030), ReversePrism.DataModels.Camera.FromPointer); // 0x30 CameraObject                ( ModelClassType Camera Camera Camera Pointer )
            value.Webviewrect                               = (Rect)GetInt32(new IntPtr(p + 0x038)); // 0x38 Webviewrect                 ( ModelEnumType Rect Rect Rect Int32 )

            return value;
        }
    }
}
