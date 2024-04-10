using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 onDrag                                   Subject`1<PointerEventData> IL2CPP_TYPE_GENERICINST
    public partial class ObservableDragTrigger : DataModel
    {

        public static ObservableDragTrigger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObservableDragTrigger() { Pointer= p0 };


            return value;
        }
    }
}
