using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kMaximumAlignment                        int IL2CPP_TYPE_I4
    // 010 m_pointer                                IntPtr IL2CPP_TYPE_PTR
    // 018 M_bytes                                  ModelPrimitiveType long long long Int64
    // 020 M_union                                  ModelEnumType Union Union Union Int32
    public partial class MemoryBlock : DataModel
    {
        public long                                     M_bytes                                 { get; set; }
        public Union                                    M_union                                 { get; set; }

        public static MemoryBlock? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemoryBlock() { Pointer= p0 };

            value.M_bytes                                   = GetInt64(new IntPtr(p + 0x018)); // 0x18 M_bytes                     ( ModelPrimitiveType long long long Int64 )
            value.M_union                                   = (Union)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_union                     ( ModelEnumType Union Union Union Int32 )

            return value;
        }
    }
}
