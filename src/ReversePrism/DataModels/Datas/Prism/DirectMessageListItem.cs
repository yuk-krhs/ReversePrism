using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DateText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 TitleText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 NewmarkObject                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 OpenButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    public partial class DirectMessageListItem
    {
        public UITextMeshProUGUI?                       DateText                                { get; set; }
        public UITextMeshProUGUI?                       TitleText                               { get; set; }
        public GameObject?                              NewmarkObject                           { get; set; }
        public UIButton?                                OpenButton                              { get; set; }

        public static DirectMessageListItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DirectMessageListItem();

            value.DateText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D4CA2CB8 0x20 DateText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D4CA2CD8 0x28 TitleText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NewmarkObject                             = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4CA2CF8 0x30 NewmarkObject               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.OpenButton                                = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0270D4CA2D18 0x38 OpenButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
