using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 TextMessage                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 ButtonStart                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 070 ButtonStartText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 ButtonTransferData                       0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 080 ButtonTransferDataText                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class GameStartContent : DataModel
    {
        public UITextMeshProUGUI?                       TextMessage                             { get; set; }
        public UIButton?                                ButtonStart                             { get; set; }
        public UITextMeshProUGUI?                       ButtonStartText                         { get; set; }
        public UIButton?                                ButtonTransferData                      { get; set; }
        public UITextMeshProUGUI?                       ButtonTransferDataText                  { get; set; }

        public static GameStartContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GameStartContent() { Pointer= p0 };

            value.TextMessage                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0245A4400650 0x60 TextMessage                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ButtonStart                               = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0245A4400670 0x68 ButtonStart                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ButtonStartText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0245A4400690 0x70 ButtonStartText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ButtonTransferData                        = GetObject<UIButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIButton.FromPointer); // 0245A44006B0 0x78 ButtonTransferData          ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ButtonTransferDataText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0245A44006D0 0x80 ButtonTransferDataText      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
