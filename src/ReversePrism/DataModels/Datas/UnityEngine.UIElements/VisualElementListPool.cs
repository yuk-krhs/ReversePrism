using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     ObjectPool`1<List`1<VisualElement>> IL2CPP_TYPE_GENERICINST
    public partial class VisualElementListPool : DataModel
    {

        public static VisualElementListPool? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VisualElementListPool() { Pointer= p0 };


            return value;
        }
    }
}
