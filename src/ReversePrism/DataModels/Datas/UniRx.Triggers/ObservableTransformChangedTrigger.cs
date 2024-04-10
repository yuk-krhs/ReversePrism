using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 onBeforeTransformParentChanged           Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 onTransformParentChanged                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 onTransformChildrenChanged               Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ObservableTransformChangedTrigger : DataModel
    {

        public static ObservableTransformChangedTrigger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObservableTransformChangedTrigger() { Pointer= p0 };


            return value;
        }
    }
}
