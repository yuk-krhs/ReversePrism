using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Byte0                                    00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 Byte1                                    00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 Byte2                                    00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 Byte3                                    00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 Byte4                                    00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 015 Byte5                                    00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 016 Byte6                                    00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 017 Byte7                                    00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 Byte8                                    00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 019 Byte9                                    00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01A Byte10                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01B Byte11                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01C Byte12                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01D Byte13                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01E Byte14                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01F Byte15                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 010 SByte0                                   00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 SByte1                                   00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 SByte2                                   00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 SByte3                                   00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 SByte4                                   00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 015 SByte5                                   00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 016 SByte6                                   00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 017 SByte7                                   00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 SByte8                                   00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 019 SByte9                                   00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01A SByte10                                  00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01B SByte11                                  00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01C SByte12                                  00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01D SByte13                                  00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01E SByte14                                  00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01F SByte15                                  00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 010 UShort0                                  000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 012 UShort1                                  000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 014 UShort2                                  000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 016 UShort3                                  000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 018 UShort4                                  000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01A UShort5                                  000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01C UShort6                                  000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01E UShort7                                  000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 010 SShort0                                  0001865F1520 ModelPrimitiveType short short short Int16
    // 012 SShort1                                  0001865F1520 ModelPrimitiveType short short short Int16
    // 014 SShort2                                  0001865F1520 ModelPrimitiveType short short short Int16
    // 016 SShort3                                  0001865F1520 ModelPrimitiveType short short short Int16
    // 018 SShort4                                  0001865F1520 ModelPrimitiveType short short short Int16
    // 01A SShort5                                  0001865F1520 ModelPrimitiveType short short short Int16
    // 01C SShort6                                  0001865F1520 ModelPrimitiveType short short short Int16
    // 01E SShort7                                  0001865F1520 ModelPrimitiveType short short short Int16
    // 010 UInt0                                    0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 UInt1                                    0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 UInt2                                    0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 01C UInt3                                    0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 010 SInt0                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 SInt1                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 SInt2                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C SInt3                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 010 ULong0                                   00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64
    // 018 ULong1                                   00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64
    // 010 SLong0                                   0001865F7E40 ModelPrimitiveType long long long Int64
    // 018 SLong1                                   0001865F7E40 ModelPrimitiveType long long long Int64
    // 010 Float0                                   000186666050 ModelPrimitiveType float float float Single
    // 014 Float1                                   000186666050 ModelPrimitiveType float float float Single
    // 018 Float2                                   000186666050 ModelPrimitiveType float float float Single
    // 01C Float3                                   000186666050 ModelPrimitiveType float float float Single
    // 010 Double0                                  0001865C2E50 ModelPrimitiveType double double double Double
    // 018 Double1                                  0001865C2E50 ModelPrimitiveType double double double Double
    // 010 Lo64                                     0001865F81B0 ModelEnumType v64 v64 v64 Int32
    // 018 Hi64                                     0001865F81B0 ModelEnumType v64 v64 v64 Int32
    public partial class v128 : DataModel
    {
        public sbyte                                    Byte0                                   { get; set; }
        public sbyte                                    Byte1                                   { get; set; }
        public sbyte                                    Byte2                                   { get; set; }
        public sbyte                                    Byte3                                   { get; set; }
        public sbyte                                    Byte4                                   { get; set; }
        public sbyte                                    Byte5                                   { get; set; }
        public sbyte                                    Byte6                                   { get; set; }
        public sbyte                                    Byte7                                   { get; set; }
        public sbyte                                    Byte8                                   { get; set; }
        public sbyte                                    Byte9                                   { get; set; }
        public sbyte                                    Byte10                                  { get; set; }
        public sbyte                                    Byte11                                  { get; set; }
        public sbyte                                    Byte12                                  { get; set; }
        public sbyte                                    Byte13                                  { get; set; }
        public sbyte                                    Byte14                                  { get; set; }
        public sbyte                                    Byte15                                  { get; set; }
        public sbyte                                    SByte0                                  { get; set; }
        public sbyte                                    SByte1                                  { get; set; }
        public sbyte                                    SByte2                                  { get; set; }
        public sbyte                                    SByte3                                  { get; set; }
        public sbyte                                    SByte4                                  { get; set; }
        public sbyte                                    SByte5                                  { get; set; }
        public sbyte                                    SByte6                                  { get; set; }
        public sbyte                                    SByte7                                  { get; set; }
        public sbyte                                    SByte8                                  { get; set; }
        public sbyte                                    SByte9                                  { get; set; }
        public sbyte                                    SByte10                                 { get; set; }
        public sbyte                                    SByte11                                 { get; set; }
        public sbyte                                    SByte12                                 { get; set; }
        public sbyte                                    SByte13                                 { get; set; }
        public sbyte                                    SByte14                                 { get; set; }
        public sbyte                                    SByte15                                 { get; set; }
        public ushort                                   UShort0                                 { get; set; }
        public ushort                                   UShort1                                 { get; set; }
        public ushort                                   UShort2                                 { get; set; }
        public ushort                                   UShort3                                 { get; set; }
        public ushort                                   UShort4                                 { get; set; }
        public ushort                                   UShort5                                 { get; set; }
        public ushort                                   UShort6                                 { get; set; }
        public ushort                                   UShort7                                 { get; set; }
        public short                                    SShort0                                 { get; set; }
        public short                                    SShort1                                 { get; set; }
        public short                                    SShort2                                 { get; set; }
        public short                                    SShort3                                 { get; set; }
        public short                                    SShort4                                 { get; set; }
        public short                                    SShort5                                 { get; set; }
        public short                                    SShort6                                 { get; set; }
        public short                                    SShort7                                 { get; set; }
        public uint                                     UInt0                                   { get; set; }
        public uint                                     UInt1                                   { get; set; }
        public uint                                     UInt2                                   { get; set; }
        public uint                                     UInt3                                   { get; set; }
        public int                                      SInt0                                   { get; set; }
        public int                                      SInt1                                   { get; set; }
        public int                                      SInt2                                   { get; set; }
        public int                                      SInt3                                   { get; set; }
        public ulong                                    ULong0                                  { get; set; }
        public ulong                                    ULong1                                  { get; set; }
        public long                                     SLong0                                  { get; set; }
        public long                                     SLong1                                  { get; set; }
        public float                                    Float0                                  { get; set; }
        public float                                    Float1                                  { get; set; }
        public float                                    Float2                                  { get; set; }
        public float                                    Float3                                  { get; set; }
        public double                                   Double0                                 { get; set; }
        public double                                   Double1                                 { get; set; }
        public v64                                      Lo64                                    { get; set; }
        public v64                                      Hi64                                    { get; set; }

        public static v128? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new v128() { Pointer= p0 };

            value.Byte0                                     = GetSByte(new IntPtr(p + 0x010)); // 02466A96E178 0x10 Byte0                       ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte1                                     = GetSByte(new IntPtr(p + 0x011)); // 02466A96E198 0x11 Byte1                       ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte2                                     = GetSByte(new IntPtr(p + 0x012)); // 02466A96E1B8 0x12 Byte2                       ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte3                                     = GetSByte(new IntPtr(p + 0x013)); // 02466A96E1D8 0x13 Byte3                       ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte4                                     = GetSByte(new IntPtr(p + 0x014)); // 02466A96E1F8 0x14 Byte4                       ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte5                                     = GetSByte(new IntPtr(p + 0x015)); // 02466A96E218 0x15 Byte5                       ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte6                                     = GetSByte(new IntPtr(p + 0x016)); // 02466A96E238 0x16 Byte6                       ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte7                                     = GetSByte(new IntPtr(p + 0x017)); // 02466A96E258 0x17 Byte7                       ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte8                                     = GetSByte(new IntPtr(p + 0x018)); // 02466A96E278 0x18 Byte8                       ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte9                                     = GetSByte(new IntPtr(p + 0x019)); // 02466A96E298 0x19 Byte9                       ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte10                                    = GetSByte(new IntPtr(p + 0x01A)); // 02466A96E2B8 0x1A Byte10                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte11                                    = GetSByte(new IntPtr(p + 0x01B)); // 02466A96E2D8 0x1B Byte11                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte12                                    = GetSByte(new IntPtr(p + 0x01C)); // 02466A96E2F8 0x1C Byte12                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte13                                    = GetSByte(new IntPtr(p + 0x01D)); // 02466A96E318 0x1D Byte13                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte14                                    = GetSByte(new IntPtr(p + 0x01E)); // 02466A96E338 0x1E Byte14                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte15                                    = GetSByte(new IntPtr(p + 0x01F)); // 02466A96E358 0x1F Byte15                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte0                                    = GetSByte(new IntPtr(p + 0x010)); // 02466A96E378 0x10 SByte0                      ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte1                                    = GetSByte(new IntPtr(p + 0x011)); // 02466A96E398 0x11 SByte1                      ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte2                                    = GetSByte(new IntPtr(p + 0x012)); // 02466A96E3B8 0x12 SByte2                      ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte3                                    = GetSByte(new IntPtr(p + 0x013)); // 02466A96E3D8 0x13 SByte3                      ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte4                                    = GetSByte(new IntPtr(p + 0x014)); // 02466A96E3F8 0x14 SByte4                      ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte5                                    = GetSByte(new IntPtr(p + 0x015)); // 02466A96E418 0x15 SByte5                      ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte6                                    = GetSByte(new IntPtr(p + 0x016)); // 02466A96E438 0x16 SByte6                      ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte7                                    = GetSByte(new IntPtr(p + 0x017)); // 02466A96E458 0x17 SByte7                      ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte8                                    = GetSByte(new IntPtr(p + 0x018)); // 02466A96E478 0x18 SByte8                      ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte9                                    = GetSByte(new IntPtr(p + 0x019)); // 02466A96E498 0x19 SByte9                      ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte10                                   = GetSByte(new IntPtr(p + 0x01A)); // 02466A96E4B8 0x1A SByte10                     ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte11                                   = GetSByte(new IntPtr(p + 0x01B)); // 02466A96E4D8 0x1B SByte11                     ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte12                                   = GetSByte(new IntPtr(p + 0x01C)); // 02466A96E4F8 0x1C SByte12                     ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte13                                   = GetSByte(new IntPtr(p + 0x01D)); // 02466A96E518 0x1D SByte13                     ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte14                                   = GetSByte(new IntPtr(p + 0x01E)); // 02466A96E538 0x1E SByte14                     ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte15                                   = GetSByte(new IntPtr(p + 0x01F)); // 02466A96E558 0x1F SByte15                     ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.UShort0                                   = GetUInt16(new IntPtr(p + 0x010)); // 02466A96E578 0x10 UShort0                     ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UShort1                                   = GetUInt16(new IntPtr(p + 0x012)); // 02466A96E598 0x12 UShort1                     ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UShort2                                   = GetUInt16(new IntPtr(p + 0x014)); // 02466A96E5B8 0x14 UShort2                     ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UShort3                                   = GetUInt16(new IntPtr(p + 0x016)); // 02466A96E5D8 0x16 UShort3                     ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UShort4                                   = GetUInt16(new IntPtr(p + 0x018)); // 02466A96E5F8 0x18 UShort4                     ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UShort5                                   = GetUInt16(new IntPtr(p + 0x01A)); // 02466A96E618 0x1A UShort5                     ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UShort6                                   = GetUInt16(new IntPtr(p + 0x01C)); // 02466A96E638 0x1C UShort6                     ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UShort7                                   = GetUInt16(new IntPtr(p + 0x01E)); // 02466A96E658 0x1E UShort7                     ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.SShort0                                   = GetInt16(new IntPtr(p + 0x010)); // 02466A96E678 0x10 SShort0                     ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.SShort1                                   = GetInt16(new IntPtr(p + 0x012)); // 02466A96E698 0x12 SShort1                     ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.SShort2                                   = GetInt16(new IntPtr(p + 0x014)); // 02466A96E6B8 0x14 SShort2                     ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.SShort3                                   = GetInt16(new IntPtr(p + 0x016)); // 02466A96E6D8 0x16 SShort3                     ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.SShort4                                   = GetInt16(new IntPtr(p + 0x018)); // 02466A96E6F8 0x18 SShort4                     ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.SShort5                                   = GetInt16(new IntPtr(p + 0x01A)); // 02466A96E718 0x1A SShort5                     ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.SShort6                                   = GetInt16(new IntPtr(p + 0x01C)); // 02466A96E738 0x1C SShort6                     ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.SShort7                                   = GetInt16(new IntPtr(p + 0x01E)); // 02466A96E758 0x1E SShort7                     ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.UInt0                                     = GetUInt32(new IntPtr(p + 0x010)); // 02466A96E778 0x10 UInt0                       ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.UInt1                                     = GetUInt32(new IntPtr(p + 0x014)); // 02466A96E798 0x14 UInt1                       ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.UInt2                                     = GetUInt32(new IntPtr(p + 0x018)); // 02466A96E7B8 0x18 UInt2                       ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.UInt3                                     = GetUInt32(new IntPtr(p + 0x01C)); // 02466A96E7D8 0x1C UInt3                       ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.SInt0                                     = GetInt32(new IntPtr(p + 0x010)); // 02466A96E7F8 0x10 SInt0                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SInt1                                     = GetInt32(new IntPtr(p + 0x014)); // 02466A96E818 0x14 SInt1                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SInt2                                     = GetInt32(new IntPtr(p + 0x018)); // 02466A96E838 0x18 SInt2                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SInt3                                     = GetInt32(new IntPtr(p + 0x01C)); // 02466A96E858 0x1C SInt3                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ULong0                                    = GetUInt64(new IntPtr(p + 0x010)); // 02466A96E878 0x10 ULong0                      ( 00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.ULong1                                    = GetUInt64(new IntPtr(p + 0x018)); // 02466A96E898 0x18 ULong1                      ( 00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.SLong0                                    = GetInt64(new IntPtr(p + 0x010)); // 02466A96E8B8 0x10 SLong0                      ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.SLong1                                    = GetInt64(new IntPtr(p + 0x018)); // 02466A96E8D8 0x18 SLong1                      ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.Float0                                    = GetSingle(new IntPtr(p + 0x010)); // 02466A96E8F8 0x10 Float0                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Float1                                    = GetSingle(new IntPtr(p + 0x014)); // 02466A96E918 0x14 Float1                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Float2                                    = GetSingle(new IntPtr(p + 0x018)); // 02466A96E938 0x18 Float2                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Float3                                    = GetSingle(new IntPtr(p + 0x01C)); // 02466A96E958 0x1C Float3                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Double0                                   = GetDouble(new IntPtr(p + 0x010)); // 02466A96E978 0x10 Double0                     ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.Double1                                   = GetDouble(new IntPtr(p + 0x018)); // 02466A96E998 0x18 Double1                     ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.Lo64                                      = (v64)GetInt32(new IntPtr(p + 0x010)); // 02466A96E9B8 0x10 Lo64                        ( 0001865F81B0 ModelEnumType v64 v64 v64 Int32 )
            value.Hi64                                      = (v64)GetInt32(new IntPtr(p + 0x018)); // 02466A96E9D8 0x18 Hi64                        ( 0001865F81B0 ModelEnumType v64 v64 v64 Int32 )

            return value;
        }
    }
}
