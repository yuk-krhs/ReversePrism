using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Flags                                    ModelPrimitiveType int int int Int32
    // 014 Hi                                       ModelPrimitiveType int int int Int32
    // 018 Lo                                       ModelPrimitiveType int int int Int32
    // 01C Mid                                      ModelPrimitiveType int int int Int32
    public partial class DecimalBits : DataModel
    {
        public int                                      Flags                                   { get; set; }
        public int                                      Hi                                      { get; set; }
        public int                                      Lo                                      { get; set; }
        public int                                      Mid                                     { get; set; }

        public static DecimalBits? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecimalBits() { Pointer= p0 };

            value.Flags                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Flags                       ( ModelPrimitiveType int int int Int32 )
            value.Hi                                        = GetInt32(new IntPtr(p + 0x014)); // 0x14 Hi                          ( ModelPrimitiveType int int int Int32 )
            value.Lo                                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 Lo                          ( ModelPrimitiveType int int int Int32 )
            value.Mid                                       = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Mid                         ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
