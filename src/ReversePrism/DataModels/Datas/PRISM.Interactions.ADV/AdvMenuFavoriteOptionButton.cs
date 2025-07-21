using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 028 ButtonText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class AdvMenuFavoriteOptionButton : DataModel
    {
        public ToggleButton?                            Button                                  { get; set; }
        public UITextMeshProUGUI?                       ButtonText                              { get; set; }

        public static AdvMenuFavoriteOptionButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvMenuFavoriteOptionButton() { Pointer= p0 };

            value.Button                                    = GetObject<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x20 Button                      ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.ButtonText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 ButtonText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
