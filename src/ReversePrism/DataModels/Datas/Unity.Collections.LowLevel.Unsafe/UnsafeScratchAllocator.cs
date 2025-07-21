using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Pointer                                IntPtr IL2CPP_TYPE_PTR
    // 018 M_LengthInBytes                          ModelPrimitiveType int int int Int32
    // 01C M_CapacityInBytes                        ModelPrimitiveType int int int Int32
    public partial class UnsafeScratchAllocator : DataModel
    {
        public int                                      M_LengthInBytes                         { get; set; }
        public int                                      M_CapacityInBytes                       { get; set; }

        public static UnsafeScratchAllocator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnsafeScratchAllocator() { Pointer= p0 };

            value.M_LengthInBytes                           = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_LengthInBytes             ( ModelPrimitiveType int int int Int32 )
            value.M_CapacityInBytes                         = GetInt32(new IntPtr(p + 0x01C)); // 0x1C M_CapacityInBytes           ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
