using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 element                                  <var> IL2CPP_TYPE_VAR
    // 000 count                                    int IL2CPP_TYPE_I4
    // 000 remaining                                int IL2CPP_TYPE_I4
    // 000 cancellationToken                        CancellationToken IL2CPP_TYPE_VALUETYPE
    public partial class _Repeat : DataModel
    {

        public static _Repeat? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _Repeat() { Pointer= p0 };


            return value;
        }
    }
}
