using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Btns                                     000185CAE378 ModelClassListType UITabButton[] UITabButton[] List<UITabButton> Pointer
    // 040 onSelected                               Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class FUHeaderView : DataModel
    {
        public List<UITabButton>?                       Btns                                    { get; set; }

        public static FUHeaderView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FUHeaderView() { Pointer= p0 };

            value.Btns                                      = GetObjectList<UITabButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITabButton.FromPointer); // 02466A2C6198 0x38 Btns                        ( 000185CAE378 ModelClassListType UITabButton[] UITabButton[] List<UITabButton> Pointer )

            return value;
        }
    }
}
