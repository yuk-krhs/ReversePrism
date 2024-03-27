using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Webview                                  000186695400 ModelClassType NativeWebviewObject NativeWebviewObject NativeWebviewObject Pointer
    // 028 InitURL                                  0001866722E0 ModelPrimitiveType string string string String
    // 030 CameraObject                             0001865A2380 ModelClassType Camera Camera Camera Pointer
    // 038 Webviewrect                              00018664F620 ModelEnumType Rect Rect Rect Int32
    public partial class NativeWebview
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
            var value   = new NativeWebview();

            value.Webview                                   = GetObject<NativeWebviewObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.NativeWebviewObject.FromPointer); // 027004404068 0x20 Webview                     ( 000186695400 ModelClassType NativeWebviewObject NativeWebviewObject NativeWebviewObject Pointer )
            value.InitURL                                   = GetString(new IntPtr(p + 0x028)); // 027004404088 0x28 InitURL                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.CameraObject                              = GetObject<Camera>(new IntPtr(p + 0x030), ReversePrism.DataModels.Camera.FromPointer); // 0270044040A8 0x30 CameraObject                ( 0001865A2380 ModelClassType Camera Camera Camera Pointer )
            value.Webviewrect                               = (Rect)GetInt32(new IntPtr(p + 0x038)); // 0270044040C8 0x38 Webviewrect                 ( 00018664F620 ModelEnumType Rect Rect Rect Int32 )

            return value;
        }
    }
}
