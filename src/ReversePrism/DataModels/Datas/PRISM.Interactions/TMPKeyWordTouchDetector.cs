using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UiTMP                                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 UIDisplayCamera                          0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 030 onTouchId                                Subject`1<List`1<string>> IL2CPP_TYPE_GENERICINST
    public partial class TMPKeyWordTouchDetector : DataModel
    {
        public UITextMeshProUGUI?                       UiTMP                                   { get; set; }
        public Camera?                                  UIDisplayCamera                         { get; set; }

        public static TMPKeyWordTouchDetector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMPKeyWordTouchDetector() { Pointer= p0 };

            value.UiTMP                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A13E548 0x20 UiTMP                       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UIDisplayCamera                           = GetObject<Camera>(new IntPtr(p + 0x028), ReversePrism.DataModels.Camera.FromPointer); // 02466A13E568 0x28 UIDisplayCamera             ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )

            return value;
        }
    }
}
