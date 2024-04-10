using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 onPointerEnter                           Subject`1<PointerEventData> IL2CPP_TYPE_GENERICINST
    public partial class ObservablePointerEnterTrigger : DataModel
    {

        public static ObservablePointerEnterTrigger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObservablePointerEnterTrigger() { Pointer= p0 };


            return value;
        }
    }
}
