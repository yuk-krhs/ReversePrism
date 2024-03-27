using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 WorkOnRawImage                           0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 WorkOnText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 WorkOnLineObject                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 WorkOffRawImage                          0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 040 WorkOffText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 WorkOffLineObject                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class WeekDisplayContent
    {
        public UIRawImage?                              WorkOnRawImage                          { get; set; }
        public UITextMeshProUGUI?                       WorkOnText                              { get; set; }
        public GameObject?                              WorkOnLineObject                        { get; set; }
        public UIRawImage?                              WorkOffRawImage                         { get; set; }
        public UITextMeshProUGUI?                       WorkOffText                             { get; set; }
        public GameObject?                              WorkOffLineObject                       { get; set; }

        public static WeekDisplayContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WeekDisplayContent();

            value.WorkOnRawImage                            = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270DA0CD0F8 0x20 WorkOnRawImage              ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.WorkOnText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA0CD118 0x28 WorkOnText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.WorkOnLineObject                          = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0CD138 0x30 WorkOnLineObject            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.WorkOffRawImage                           = GetObject<UIRawImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270DA0CD158 0x38 WorkOffRawImage             ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.WorkOffText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA0CD178 0x40 WorkOffText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.WorkOffLineObject                         = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0CD198 0x48 WorkOffLineObject           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
