using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 data                                     IntPtr IL2CPP_TYPE_PTR
    // 018 Len                                      ModelPrimitiveType int int int Int32
    public partial class GPtrArray : DataModel
    {
        public int                                      Len                                     { get; set; }

        public static GPtrArray? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GPtrArray() { Pointer= p0 };

            value.Len                                       = GetInt32(new IntPtr(p + 0x018)); // 0x18 Len                         ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
