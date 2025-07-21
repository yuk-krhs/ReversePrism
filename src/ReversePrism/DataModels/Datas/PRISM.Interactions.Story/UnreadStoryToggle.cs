using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Toggle                                   ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 028 LabelText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class UnreadStoryToggle : DataModel
    {
        public ToggleButton?                            Toggle                                  { get; set; }
        public UITextMeshProUGUI?                       LabelText                               { get; set; }

        public static UnreadStoryToggle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnreadStoryToggle() { Pointer= p0 };

            value.Toggle                                    = GetObject<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x20 Toggle                      ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.LabelText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 LabelText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
