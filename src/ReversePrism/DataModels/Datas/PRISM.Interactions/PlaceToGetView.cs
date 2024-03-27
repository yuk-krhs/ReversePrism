using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Btn                                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 TxtTitle                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtPlace                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 onClick                                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class PlaceToGetView
    {
        public UIButton?                                Btn                                     { get; set; }
        public UITextMeshProUGUI?                       TxtTitle                                { get; set; }
        public UITextMeshProUGUI?                       TxtPlace                                { get; set; }

        public static PlaceToGetView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlaceToGetView();

            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA2FDEB0 0x20 Btn                         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TxtTitle                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2FDED0 0x28 TxtTitle                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtPlace                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2FDEF0 0x30 TxtPlace                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
