using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 onClick                                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 048 onLongPressed                            Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ClickObservableIntContext : DataModel
    {

        public static ClickObservableIntContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClickObservableIntContext() { Pointer= p0 };


            return value;
        }
    }
}
