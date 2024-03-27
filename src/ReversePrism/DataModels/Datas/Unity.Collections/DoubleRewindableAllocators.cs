using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Pointer                                  IntPtr IL2CPP_TYPE_PTR
    // 018 UpdateAllocatorHelper0                   AllocatorHelper`1<RewindableAllocator> IL2CPP_TYPE_GENERICINST
    // 028 UpdateAllocatorHelper1                   AllocatorHelper`1<RewindableAllocator> IL2CPP_TYPE_GENERICINST
    public partial class DoubleRewindableAllocators
    {

        public static DoubleRewindableAllocators? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DoubleRewindableAllocators();


            return value;
        }
    }
}
