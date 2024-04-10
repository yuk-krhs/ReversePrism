using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   AggregateObservable`3<<var>, <var>, <var>> IL2CPP_TYPE_GENERICINST
    // 000 accumulation                             <var> IL2CPP_TYPE_VAR
    public partial class Aggregate : DataModel
    {

        public static Aggregate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Aggregate() { Pointer= p0 };


            return value;
        }
    }
}
