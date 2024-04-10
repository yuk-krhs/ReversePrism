using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 value                                    <var> IL2CPP_TYPE_VAR
    // 000 cancellationToken                        CancellationToken IL2CPP_TYPE_VALUETYPE
    // 000 called                                   bool IL2CPP_TYPE_BOOLEAN
    public partial class _Return : DataModel
    {

        public static _Return? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _Return() { Pointer= p0 };


            return value;
        }
    }
}
