using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Buffer                                 IntPtr IL2CPP_TYPE_PTR
    // 018 m_QueuePool                              IntPtr IL2CPP_TYPE_PTR
    // 020 M_AllocatorLabel                         ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32
    public partial class UnsafeQueueDispose : DataModel
    {
        public AllocatorHandle                          M_AllocatorLabel                        { get; set; }

        public static UnsafeQueueDispose? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnsafeQueueDispose() { Pointer= p0 };

            value.M_AllocatorLabel                          = (AllocatorHandle)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_AllocatorLabel            ( ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32 )

            return value;
        }
    }
}
