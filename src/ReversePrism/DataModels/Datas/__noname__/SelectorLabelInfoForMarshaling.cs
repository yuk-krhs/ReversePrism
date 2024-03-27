using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 selectorNamePtr                          <int> IL2CPP_TYPE_I
    // 018 labelNamePtr                             <int> IL2CPP_TYPE_I
    public partial class SelectorLabelInfoForMarshaling
    {

        public static SelectorLabelInfoForMarshaling? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectorLabelInfoForMarshaling();


            return value;
        }
    }
}
