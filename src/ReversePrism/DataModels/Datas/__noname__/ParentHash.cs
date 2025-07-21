using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Hash                                   ModelPrimitiveType int int int Int32
    // 014 M_ParentHash                             ModelPrimitiveType int int int Int32
    public partial class ParentHash : DataModel
    {
        public int                                      M_Hash                                  { get; set; }
        public int                                      M_ParentHash                            { get; set; }

        public static ParentHash? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParentHash() { Pointer= p0 };

            value.M_Hash                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Hash                      ( ModelPrimitiveType int int int Int32 )
            value.M_ParentHash                              = GetInt32(new IntPtr(p + 0x014)); // 0x14 M_ParentHash                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
