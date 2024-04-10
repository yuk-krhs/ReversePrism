using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_allocated                              ArrayOfArrays`1<<int>> IL2CPP_TYPE_GENERICINST
    // 030 m_tofree                                 ArrayOfArrays`1<<int>> IL2CPP_TYPE_GENERICINST
    // 050 M_handle                                 0001866991F0 ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32
    // 054 M_backingAllocatorHandle                 0001866991F0 ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32
    public partial class AutoFreeAllocator : DataModel
    {
        public AllocatorHandle                          M_handle                                { get; set; }
        public AllocatorHandle                          M_backingAllocatorHandle                { get; set; }

        public static AutoFreeAllocator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AutoFreeAllocator() { Pointer= p0 };

            value.M_handle                                  = (AllocatorHandle)GetInt32(new IntPtr(p + 0x050)); // 0245A3561BA8 0x50 M_handle                    ( 0001866991F0 ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32 )
            value.M_backingAllocatorHandle                  = (AllocatorHandle)GetInt32(new IntPtr(p + 0x054)); // 0245A3561BC8 0x54 M_backingAllocatorHandle    ( 0001866991F0 ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32 )

            return value;
        }
    }
}
