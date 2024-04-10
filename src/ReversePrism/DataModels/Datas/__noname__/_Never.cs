using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 cancellationToken                        CancellationToken IL2CPP_TYPE_VALUETYPE
    public partial class _Never : DataModel
    {

        public static _Never? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _Never() { Pointer= p0 };


            return value;
        }
    }
}
