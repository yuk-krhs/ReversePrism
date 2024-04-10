using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Parent                                   0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 040 ContentTabButtonObj                      0001866F4F80 ModelClassType UITabButton UITabButton UITabButton Pointer
    // 048 OnSelected                               Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class LabelTabGroupView : DataModel
    {
        public Transform?                               Parent                                  { get; set; }
        public UITabButton?                             ContentTabButtonObj                     { get; set; }

        public static LabelTabGroupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LabelTabGroupView() { Pointer= p0 };

            value.Parent                                    = GetObject<Transform>(new IntPtr(p + 0x038), ReversePrism.DataModels.Transform.FromPointer); // 02466A2C62D8 0x38 Parent                      ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ContentTabButtonObj                       = GetObject<UITabButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITabButton.FromPointer); // 02466A2C62F8 0x40 ContentTabButtonObj         ( 0001866F4F80 ModelClassType UITabButton UITabButton UITabButton Pointer )

            return value;
        }
    }
}
