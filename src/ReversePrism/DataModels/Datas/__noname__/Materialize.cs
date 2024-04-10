using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   MaterializeObservable`1<<var>> IL2CPP_TYPE_GENERICINST
    public partial class Materialize : DataModel
    {

        public static Materialize? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Materialize() { Pointer= p0 };


            return value;
        }
    }
}
