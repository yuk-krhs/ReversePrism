using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ReducerThreshold                         int IL2CPP_TYPE_I4
    // 004 SquareThreshold                          int IL2CPP_TYPE_I4
    // 008 AllocationThreshold                      int IL2CPP_TYPE_I4
    // 00C MultiplyThreshold                        int IL2CPP_TYPE_I4
    public partial class BigIntegerCalculator : DataModel
    {

        public static BigIntegerCalculator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BigIntegerCalculator() { Pointer= p0 };


            return value;
        }
    }
}
