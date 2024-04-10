using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // FFFFFFFF threadLocalExceptions                    List`1<Exception> IL2CPP_TYPE_GENERICINST
    public partial class ExceptionAggregator : DataModel
    {

        public static ExceptionAggregator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExceptionAggregator() { Pointer= p0 };


            return value;
        }
    }
}
