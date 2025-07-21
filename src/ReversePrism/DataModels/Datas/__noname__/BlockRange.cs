using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Current                                ModelPrimitiveType int int int Int32
    // 014 M_End                                    ModelPrimitiveType int int int Int32
    public partial class BlockRange : DataModel
    {
        public int                                      M_Current                               { get; set; }
        public int                                      M_End                                   { get; set; }

        public static BlockRange? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BlockRange() { Pointer= p0 };

            value.M_Current                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Current                   ( ModelPrimitiveType int int int Int32 )
            value.M_End                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 M_End                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
