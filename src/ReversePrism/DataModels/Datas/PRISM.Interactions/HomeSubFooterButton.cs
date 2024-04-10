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
    // 030 BadgeOnPanelObj                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 BadgeOffPanelObj                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 BadgeBluePanelObj                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class HomeSubFooterButton : DataModel
    {
        public UIButton?                                Button                                  { get; set; }
        public BadgeView?                               BadgeView                               { get; set; }
        public GameObject?                              BadgeOnPanelObj                         { get; set; }
        public GameObject?                              BadgeOffPanelObj                        { get; set; }
        public GameObject?                              BadgeBluePanelObj                       { get; set; }

        public static HomeSubFooterButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeSubFooterButton() { Pointer= p0 };

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0245A4F661C8 0x20 Button                      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BadgeView                                 = GetObject<BadgeView>(new IntPtr(p + 0x028), ReversePrism.DataModels.BadgeView.FromPointer); // 0245A4F661E8 0x28 BadgeView                   ( 000186738540 ModelClassType BadgeView BadgeView BadgeView Pointer )
            value.BadgeOnPanelObj                           = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0245A4F66208 0x30 BadgeOnPanelObj             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BadgeOffPanelObj                          = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0245A4F66228 0x38 BadgeOffPanelObj            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BadgeBluePanelObj                         = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0245A4F66248 0x40 BadgeBluePanelObj           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
