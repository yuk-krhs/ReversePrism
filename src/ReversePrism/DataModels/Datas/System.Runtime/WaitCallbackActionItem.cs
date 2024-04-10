using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <ShouldUseActivity>k__BackingField       bool IL2CPP_TYPE_BOOLEAN
    public partial class WaitCallbackActionItem : DataModel
    {

        public static WaitCallbackActionItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WaitCallbackActionItem() { Pointer= p0 };


            return value;
        }
    }
}
