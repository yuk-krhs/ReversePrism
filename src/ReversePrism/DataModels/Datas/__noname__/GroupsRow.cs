using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Group                                    000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 018 Label                                    0001865F7700 ModelPrimitiveType long long long Int64
    public partial class GroupsRow
    {
        public uint                                     Group                                   { get; set; }
        public long                                     Label                                   { get; set; }

        public static GroupsRow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GroupsRow();

            value.Group                                     = GetUInt32(new IntPtr(p + 0x010)); // 027003E03528 0x10 Group                       ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.Label                                     = GetInt64(new IntPtr(p + 0x018)); // 027003E03548 0x18 Label                       ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
