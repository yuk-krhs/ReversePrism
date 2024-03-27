using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 BadgeView                                000186738540 ModelClassType BadgeView BadgeView BadgeView Pointer
    // 030 Text                                     0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class GlobalMenuButton
    {
        public UIButton?                                Button                                  { get; set; }
        public BadgeView?                               BadgeView                               { get; set; }
        public UITextMeshProUGUI?                       Text                                    { get; set; }

        public static GlobalMenuButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlobalMenuButton();

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0270DBEB0BC8 0x20 Button                      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BadgeView                                 = GetObject<BadgeView>(new IntPtr(p + 0x028), ReversePrism.DataModels.BadgeView.FromPointer); // 0270DBEB0BE8 0x28 BadgeView                   ( 000186738540 ModelClassType BadgeView BadgeView BadgeView Pointer )
            value.Text                                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBEB0C08 0x30 Text                        ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
