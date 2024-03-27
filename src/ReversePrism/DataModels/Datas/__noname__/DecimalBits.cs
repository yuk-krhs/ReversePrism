using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Flags                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Hi                                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Lo                                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C Mid                                      0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class DecimalBits
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
            var value   = new DecimalBits();

            value.Flags                                     = GetInt32(new IntPtr(p + 0x010)); // 0270DAAA89F0 0x10 Flags                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Hi                                        = GetInt32(new IntPtr(p + 0x014)); // 0270DAAA8A10 0x14 Hi                          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Lo                                        = GetInt32(new IntPtr(p + 0x018)); // 0270DAAA8A30 0x18 Lo                          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Mid                                       = GetInt32(new IntPtr(p + 0x01C)); // 0270DAAA8A50 0x1C Mid                         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
