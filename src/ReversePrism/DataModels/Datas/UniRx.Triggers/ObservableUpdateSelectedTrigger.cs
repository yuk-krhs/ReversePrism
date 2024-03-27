using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 onUpdateSelected                         Subject`1<BaseEventData> IL2CPP_TYPE_GENERICINST
    public partial class ObservableUpdateSelectedTrigger
    {

        public static ObservableUpdateSelectedTrigger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObservableUpdateSelectedTrigger();


            return value;
        }
    }
}
