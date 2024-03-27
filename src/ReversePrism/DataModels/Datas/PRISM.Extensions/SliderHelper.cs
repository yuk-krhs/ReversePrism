using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PointerUpAction                          0001866792B0 ModelClassType Action Action Action Pointer
    public partial class SliderHelper
    {
        public Action?                                  PointerUpAction                         { get; set; }

        public static SliderHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SliderHelper();

            value.PointerUpAction                           = GetObject<Action>(new IntPtr(p + 0x020), ReversePrism.DataModels.Action.FromPointer); // 0270D4C09058 0x20 PointerUpAction             ( 0001866792B0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
