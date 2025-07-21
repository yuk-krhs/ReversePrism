using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BackText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 BackButton                               ModelClassType ButtonToggleBase ButtonToggleBase ButtonToggleBase Pointer
    public partial class ViewBackButton : DataModel
    {
        public UITextMeshProUGUI?                       BackText                                { get; set; }
        public ButtonToggleBase?                        BackButton                              { get; set; }

        public static ViewBackButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewBackButton() { Pointer= p0 };

            value.BackText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 BackText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BackButton                                = GetObject<ButtonToggleBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.ButtonToggleBase.FromPointer); // 0x28 BackButton                  ( ModelClassType ButtonToggleBase ButtonToggleBase ButtonToggleBase Pointer )

            return value;
        }
    }
}
