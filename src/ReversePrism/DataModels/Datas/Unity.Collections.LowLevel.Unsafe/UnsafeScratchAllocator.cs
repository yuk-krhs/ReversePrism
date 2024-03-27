using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Pointer                                IntPtr IL2CPP_TYPE_PTR
    // 018 M_LengthInBytes                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C M_CapacityInBytes                        0001865F4260 ModelPrimitiveType int int int Int32
    public partial class UnsafeScratchAllocator
    {
        public int                                      M_LengthInBytes                         { get; set; }
        public int                                      M_CapacityInBytes                       { get; set; }

        public static UnsafeScratchAllocator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnsafeScratchAllocator();

            value.M_LengthInBytes                           = GetInt32(new IntPtr(p + 0x018)); // 0270D9E94608 0x18 M_LengthInBytes             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_CapacityInBytes                         = GetInt32(new IntPtr(p + 0x01C)); // 0270D9E94628 0x1C M_CapacityInBytes           ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
