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
    // 010 One                                      ModelEnumType Decimal Decimal Decimal Int32
    // 020 MinusOne                                 ModelEnumType Decimal Decimal Decimal Int32
    // 030 MaxValue                                 ModelEnumType Decimal Decimal Decimal Int32
    // 040 MinValue                                 ModelEnumType Decimal Decimal Decimal Int32
    // 010 Flags                                    ModelPrimitiveType int int int Int32
    // 014 Hi                                       ModelPrimitiveType int int int Int32
    // 018 Lo                                       ModelPrimitiveType int int int Int32
    // 01C Mid                                      ModelPrimitiveType int int int Int32
    // 018 UlomidLE                                 ModelPrimitiveType ulong ulong ulong UInt64
    public partial class Decimal : DataModel
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
            var value   = new Decimal() { Pointer= p0 };

            value.One                                       = (Decimal)GetInt32(new IntPtr(p + 0x010)); // 0x10 One                         ( ModelEnumType Decimal Decimal Decimal Int32 )
            value.MinusOne                                  = (Decimal)GetInt32(new IntPtr(p + 0x020)); // 0x20 MinusOne                    ( ModelEnumType Decimal Decimal Decimal Int32 )
            value.MaxValue                                  = (Decimal)GetInt32(new IntPtr(p + 0x030)); // 0x30 MaxValue                    ( ModelEnumType Decimal Decimal Decimal Int32 )
            value.MinValue                                  = (Decimal)GetInt32(new IntPtr(p + 0x040)); // 0x40 MinValue                    ( ModelEnumType Decimal Decimal Decimal Int32 )
            value.Flags                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Flags                       ( ModelPrimitiveType int int int Int32 )
            value.Hi                                        = GetInt32(new IntPtr(p + 0x014)); // 0x14 Hi                          ( ModelPrimitiveType int int int Int32 )
            value.Lo                                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 Lo                          ( ModelPrimitiveType int int int Int32 )
            value.Mid                                       = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Mid                         ( ModelPrimitiveType int int int Int32 )
            value.UlomidLE                                  = GetUInt64(new IntPtr(p + 0x018)); // 0x18 UlomidLE                    ( ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
