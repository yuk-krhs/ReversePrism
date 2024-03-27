using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SignMask                                 int IL2CPP_TYPE_I4
    // 000 ScaleMask                                int IL2CPP_TYPE_I4
    // 000 ScaleShift                               int IL2CPP_TYPE_I4
    // 000 Zero                                     Decimal IL2CPP_TYPE_VALUETYPE
    // 010 One                                      0001865C12F0 ModelEnumType Decimal Decimal Decimal Int32
    // 020 MinusOne                                 0001865C12F0 ModelEnumType Decimal Decimal Decimal Int32
    // 030 MaxValue                                 0001865C12F0 ModelEnumType Decimal Decimal Decimal Int32
    // 040 MinValue                                 0001865C12F0 ModelEnumType Decimal Decimal Decimal Int32
    // 010 Flags                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 014 Hi                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Lo                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 01C Mid                                      0001865F4260 ModelPrimitiveType int int int Int32
    // 018 UlomidLE                                 00018669CEA0 ModelPrimitiveType ulong ulong ulong UInt64
    public partial class Decimal
    {
        public Decimal                                  One                                     { get; set; }
        public Decimal                                  MinusOne                                { get; set; }
        public Decimal                                  MaxValue                                { get; set; }
        public Decimal                                  MinValue                                { get; set; }
        public int                                      Flags                                   { get; set; }
        public int                                      Hi                                      { get; set; }
        public int                                      Lo                                      { get; set; }
        public int                                      Mid                                     { get; set; }
        public ulong                                    UlomidLE                                { get; set; }

        public static Decimal? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Decimal();

            value.One                                       = (Decimal)GetInt32(new IntPtr(p + 0x010)); // 027003D4E150 0x10 One                         ( 0001865C12F0 ModelEnumType Decimal Decimal Decimal Int32 )
            value.MinusOne                                  = (Decimal)GetInt32(new IntPtr(p + 0x020)); // 027003D4E170 0x20 MinusOne                    ( 0001865C12F0 ModelEnumType Decimal Decimal Decimal Int32 )
            value.MaxValue                                  = (Decimal)GetInt32(new IntPtr(p + 0x030)); // 027003D4E190 0x30 MaxValue                    ( 0001865C12F0 ModelEnumType Decimal Decimal Decimal Int32 )
            value.MinValue                                  = (Decimal)GetInt32(new IntPtr(p + 0x040)); // 027003D4E1B0 0x40 MinValue                    ( 0001865C12F0 ModelEnumType Decimal Decimal Decimal Int32 )
            value.Flags                                     = GetInt32(new IntPtr(p + 0x010)); // 027003D4E1D0 0x10 Flags                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Hi                                        = GetInt32(new IntPtr(p + 0x014)); // 027003D4E1F0 0x14 Hi                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Lo                                        = GetInt32(new IntPtr(p + 0x018)); // 027003D4E210 0x18 Lo                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Mid                                       = GetInt32(new IntPtr(p + 0x01C)); // 027003D4E230 0x1C Mid                         ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.UlomidLE                                  = GetUInt64(new IntPtr(p + 0x018)); // 027003D4E250 0x18 UlomidLE                    ( 00018669CEA0 ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
