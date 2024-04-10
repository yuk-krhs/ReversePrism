using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 WithFade                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 BackText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 BackButton                               000186518FC0 ModelClassType ButtonToggleBase ButtonToggleBase ButtonToggleBase Pointer
    public partial class ViewBackButton : DataModel
    {
        public bool                                     WithFade                                { get; set; }
        public UITextMeshProUGUI?                       BackText                                { get; set; }
        public ButtonToggleBase?                        BackButton                              { get; set; }

        public static ViewBackButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewBackButton() { Pointer= p0 };

            value.WithFade                                  = GetBool(new IntPtr(p + 0x020)); // 024660CC9BE8 0x20 WithFade                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.BackText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024660CC9C08 0x28 BackText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BackButton                                = GetObject<ButtonToggleBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonToggleBase.FromPointer); // 024660CC9C28 0x30 BackButton                  ( 000186518FC0 ModelClassType ButtonToggleBase ButtonToggleBase ButtonToggleBase Pointer )

            return value;
        }
    }
}
