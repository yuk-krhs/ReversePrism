using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Data                                   IntPtr IL2CPP_TYPE_PTR
    // 018 M_AllocatorLabel                         000186699480 ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32
    public partial class NativeReferenceDispose
    {
        public AllocatorHandle                          M_AllocatorLabel                        { get; set; }

        public static NativeReferenceDispose? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeReferenceDispose();

            value.M_AllocatorLabel                          = (AllocatorHandle)GetInt32(new IntPtr(p + 0x018)); // 0270D0869AA8 0x18 M_AllocatorLabel            ( 000186699480 ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32 )

            return value;
        }
    }
}
