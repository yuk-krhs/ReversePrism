using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Double                                   FloatingPointInfo IL2CPP_TYPE_VALUETYPE
    // 038 Single                                   ModelEnumType FloatingPointInfo FloatingPointInfo FloatingPointInfo Int32
    // 010 ZeroBits                                 ModelPrimitiveType ulong ulong ulong UInt64
    // 018 InfinityBits                             ModelPrimitiveType ulong ulong ulong UInt64
    // 020 NormalMantissaMask                       ModelPrimitiveType ulong ulong ulong UInt64
    // 028 DenormalMantissaMask                     ModelPrimitiveType ulong ulong ulong UInt64
    // 030 MinBinaryExponent                        ModelPrimitiveType int int int Int32
    // 034 MaxBinaryExponent                        ModelPrimitiveType int int int Int32
    // 038 ExponentBias                             ModelPrimitiveType int int int Int32
    // 03C OverflowDecimalExponent                  ModelPrimitiveType int int int Int32
    // 040 NormalMantissaBits                       ModelPrimitiveType ushort ushort ushort UInt16
    // 042 DenormalMantissaBits                     ModelPrimitiveType ushort ushort ushort UInt16
    // 044 ExponentBits                             ModelPrimitiveType ushort ushort ushort UInt16
    public partial class FloatingPointInfo : DataModel
    {
        public FloatingPointInfo                        Single                                  { get; set; }
        public ulong                                    ZeroBits                                { get; set; }
        public ulong                                    InfinityBits                            { get; set; }
        public ulong                                    NormalMantissaMask                      { get; set; }
        public ulong                                    DenormalMantissaMask                    { get; set; }
        public int                                      MinBinaryExponent                       { get; set; }
        public int                                      MaxBinaryExponent                       { get; set; }
        public int                                      ExponentBias                            { get; set; }
        public int                                      OverflowDecimalExponent                 { get; set; }
        public ushort                                   NormalMantissaBits                      { get; set; }
        public ushort                                   DenormalMantissaBits                    { get; set; }
        public ushort                                   ExponentBits                            { get; set; }

        public static FloatingPointInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FloatingPointInfo() { Pointer= p0 };

            value.Single                                    = (FloatingPointInfo)GetInt32(new IntPtr(p + 0x038)); // 0x38 Single                      ( ModelEnumType FloatingPointInfo FloatingPointInfo FloatingPointInfo Int32 )
            value.ZeroBits                                  = GetUInt64(new IntPtr(p + 0x010)); // 0x10 ZeroBits                    ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.InfinityBits                              = GetUInt64(new IntPtr(p + 0x018)); // 0x18 InfinityBits                ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.NormalMantissaMask                        = GetUInt64(new IntPtr(p + 0x020)); // 0x20 NormalMantissaMask          ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.DenormalMantissaMask                      = GetUInt64(new IntPtr(p + 0x028)); // 0x28 DenormalMantissaMask        ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.MinBinaryExponent                         = GetInt32(new IntPtr(p + 0x030)); // 0x30 MinBinaryExponent           ( ModelPrimitiveType int int int Int32 )
            value.MaxBinaryExponent                         = GetInt32(new IntPtr(p + 0x034)); // 0x34 MaxBinaryExponent           ( ModelPrimitiveType int int int Int32 )
            value.ExponentBias                              = GetInt32(new IntPtr(p + 0x038)); // 0x38 ExponentBias                ( ModelPrimitiveType int int int Int32 )
            value.OverflowDecimalExponent                   = GetInt32(new IntPtr(p + 0x03C)); // 0x3C OverflowDecimalExponent     ( ModelPrimitiveType int int int Int32 )
            value.NormalMantissaBits                        = GetUInt16(new IntPtr(p + 0x040)); // 0x40 NormalMantissaBits          ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.DenormalMantissaBits                      = GetUInt16(new IntPtr(p + 0x042)); // 0x42 DenormalMantissaBits        ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.ExponentBits                              = GetUInt16(new IntPtr(p + 0x044)); // 0x44 ExponentBits                ( ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
