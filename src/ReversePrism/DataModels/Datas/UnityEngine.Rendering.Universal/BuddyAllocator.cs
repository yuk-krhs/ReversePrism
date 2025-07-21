using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Data                                   IntPtr IL2CPP_TYPE_PTR
    // 018 m_ActiveFreeMaskCounts                   ValueTuple`2<int, int> IL2CPP_TYPE_GENERICINST
    // 020 m_FreeMasksStorage                       ValueTuple`2<int, int> IL2CPP_TYPE_GENERICINST
    // 028 m_FreeMaskIndicesStorage                 ValueTuple`2<int, int> IL2CPP_TYPE_GENERICINST
    // 030 M_Allocator                              ModelEnumType Allocator Allocator Allocator Int32
    public partial class BuddyAllocator : DataModel
    {
        public Allocator                                M_Allocator                             { get; set; }

        public static BuddyAllocator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BuddyAllocator() { Pointer= p0 };

            value.M_Allocator                               = (Allocator)GetInt32(new IntPtr(p + 0x030)); // 0x30 M_Allocator                 ( ModelEnumType Allocator Allocator Allocator Int32 )

            return value;
        }
    }
}
