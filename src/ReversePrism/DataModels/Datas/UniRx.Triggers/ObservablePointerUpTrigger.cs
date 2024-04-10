using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 onPointerUp                              Subject`1<PointerEventData> IL2CPP_TYPE_GENERICINST
    public partial class ObservablePointerUpTrigger : DataModel
    {

        public static ObservablePointerUpTrigger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObservablePointerUpTrigger() { Pointer= p0 };


            return value;
        }
    }
}
