using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 onCanvasGroupChanged                     Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ObservableCanvasGroupChangedTrigger : DataModel
    {

        public static ObservableCanvasGroupChangedTrigger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObservableCanvasGroupChangedTrigger() { Pointer= p0 };


            return value;
        }
    }
}
