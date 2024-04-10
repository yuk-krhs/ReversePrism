using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ErrorFailedToFree                        int IL2CPP_TYPE_I4
    // 000 ErrorFailedToAllocate                    int IL2CPP_TYPE_I4
    // 000 ErrorAllocationCrossesWordBoundary       int IL2CPP_TYPE_I4
    // 000 EmptyBeforeAllocation                    int IL2CPP_TYPE_I4
    // 000 EmptyAfterFree                           int IL2CPP_TYPE_I4
    public partial class ConcurrentMask : DataModel
    {

        public static ConcurrentMask? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConcurrentMask() { Pointer= p0 };


            return value;
        }
    }
}
