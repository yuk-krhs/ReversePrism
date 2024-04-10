using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 exception                                Exception IL2CPP_TYPE_CLASS
    // 000 cancellationToken                        CancellationToken IL2CPP_TYPE_VALUETYPE
    public partial class _Throw : DataModel
    {

        public static _Throw? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _Throw() { Pointer= p0 };


            return value;
        }
    }
}
