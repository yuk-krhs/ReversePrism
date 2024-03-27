using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Buffer                                 IntPtr IL2CPP_TYPE_PTR
    // 018 M_AllocatorLabel                         0001866991F0 ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32
    public partial class UntypedUnsafeParallelHashMap
    {
        public AllocatorHandle                          M_AllocatorLabel                        { get; set; }

        public static UntypedUnsafeParallelHashMap? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UntypedUnsafeParallelHashMap();

            value.M_AllocatorLabel                          = (AllocatorHandle)GetInt32(new IntPtr(p + 0x018)); // 0270D9CF5E90 0x18 M_AllocatorLabel            ( 0001866991F0 ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32 )

            return value;
        }
    }
}
