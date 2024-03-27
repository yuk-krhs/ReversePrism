using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 data                                     IntPtr IL2CPP_TYPE_PTR
    // 018 Len                                      0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class GPtrArray
    {
        public int                                      Len                                     { get; set; }

        public static GPtrArray? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GPtrArray();

            value.Len                                       = GetInt32(new IntPtr(p + 0x018)); // 0270D692FB00 0x18 Len                         ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
