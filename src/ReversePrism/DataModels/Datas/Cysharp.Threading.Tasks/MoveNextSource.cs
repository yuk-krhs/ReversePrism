using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 completionSource                         UniTaskCompletionSourceCore`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class MoveNextSource : DataModel
    {

        public static MoveNextSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MoveNextSource() { Pointer= p0 };


            return value;
        }
    }
}
