using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Double                                   FloatingPointInfo IL2CPP_TYPE_VALUETYPE
    // 038 Single                                   000186704B60 ModelEnumType FloatingPointInfo FloatingPointInfo FloatingPointInfo Int32
    // 010 ZeroBits                                 00018669C270 ModelPrimitiveType ulong ulong ulong UInt64
    // 018 InfinityBits                             00018669C270 ModelPrimitiveType ulong ulong ulong UInt64
    // 020 NormalMantissaMask                       00018669C270 ModelPrimitiveType ulong ulong ulong UInt64
    // 028 DenormalMantissaMask                     00018669C270 ModelPrimitiveType ulong ulong ulong UInt64
    // 030 MinBinaryExponent                        0001865F4260 ModelPrimitiveType int int int Int32
    // 034 MaxBinaryExponent                        0001865F4260 ModelPrimitiveType int int int Int32
    // 038 ExponentBias                             0001865F4260 ModelPrimitiveType int int int Int32
    // 03C OverflowDecimalExponent                  0001865F4260 ModelPrimitiveType int int int Int32
    // 040 NormalMantissaBits                       000186697450 ModelPrimitiveType ushort ushort ushort UInt16
    // 042 DenormalMantissaBits                     000186697450 ModelPrimitiveType ushort ushort ushort UInt16
    // 044 ExponentBits                             000186697450 ModelPrimitiveType ushort ushort ushort UInt16
    public partial class FloatingPointInfo
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
            var value   = new FloatingPointInfo();

            value.Single                                    = (FloatingPointInfo)GetInt32(new IntPtr(p + 0x038)); // 0270DAB1CBB0 0x38 Single                      ( 000186704B60 ModelEnumType FloatingPointInfo FloatingPointInfo FloatingPointInfo Int32 )
            value.ZeroBits                                  = GetUInt64(new IntPtr(p + 0x010)); // 0270DAB1CBD0 0x10 ZeroBits                    ( 00018669C270 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.InfinityBits                              = GetUInt64(new IntPtr(p + 0x018)); // 0270DAB1CBF0 0x18 InfinityBits                ( 00018669C270 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.NormalMantissaMask                        = GetUInt64(new IntPtr(p + 0x020)); // 0270DAB1CC10 0x20 NormalMantissaMask          ( 00018669C270 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.DenormalMantissaMask                      = GetUInt64(new IntPtr(p + 0x028)); // 0270DAB1CC30 0x28 DenormalMantissaMask        ( 00018669C270 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.MinBinaryExponent                         = GetInt32(new IntPtr(p + 0x030)); // 0270DAB1CC50 0x30 MinBinaryExponent           ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MaxBinaryExponent                         = GetInt32(new IntPtr(p + 0x034)); // 0270DAB1CC70 0x34 MaxBinaryExponent           ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ExponentBias                              = GetInt32(new IntPtr(p + 0x038)); // 0270DAB1CC90 0x38 ExponentBias                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.OverflowDecimalExponent                   = GetInt32(new IntPtr(p + 0x03C)); // 0270DAB1CCB0 0x3C OverflowDecimalExponent     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.NormalMantissaBits                        = GetUInt16(new IntPtr(p + 0x040)); // 0270DAB1CCD0 0x40 NormalMantissaBits          ( 000186697450 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.DenormalMantissaBits                      = GetUInt16(new IntPtr(p + 0x042)); // 0270DAB1CCF0 0x42 DenormalMantissaBits        ( 000186697450 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.ExponentBits                              = GetUInt16(new IntPtr(p + 0x044)); // 0270DAB1CD10 0x44 ExponentBits                ( 000186697450 ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
