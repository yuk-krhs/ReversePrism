using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Txt                                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 TxtBefore                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 GoAfter                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 TxtAfter                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 GoNewDress                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 TxtNewDress                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class OtherBonusContentView
    {
        public UITextMeshProUGUI?                       Txt                                     { get; set; }
        public UITextMeshProUGUI?                       TxtBefore                               { get; set; }
        public GameObject?                              GoAfter                                 { get; set; }
        public UITextMeshProUGUI?                       TxtAfter                                { get; set; }
        public GameObject?                              GoNewDress                              { get; set; }
        public UITextMeshProUGUI?                       TxtNewDress                             { get; set; }

        public static OtherBonusContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OtherBonusContentView();

            value.Txt                                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA348D38 0x20 Txt                         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtBefore                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA348D58 0x28 TxtBefore                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoAfter                                   = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA348D78 0x30 GoAfter                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtAfter                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA348D98 0x38 TxtAfter                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoNewDress                                = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA348DB8 0x40 GoNewDress                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtNewDress                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA348DD8 0x48 TxtNewDress                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
