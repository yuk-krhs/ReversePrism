using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 onDetailRequested                        Subject`1<DirectMessageItemViewModel> IL2CPP_TYPE_GENERICINST
    public partial class DirectMessageViewContext : DataModel
    {

        public static DirectMessageViewContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DirectMessageViewContext() { Pointer= p0 };


            return value;
        }
    }
}
