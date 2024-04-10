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
    // 020 Byte16                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 021 Byte17                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 022 Byte18                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 023 Byte19                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 024 Byte20                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 025 Byte21                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 026 Byte22                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 027 Byte23                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 028 Byte24                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 029 Byte25                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02A Byte26                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02B Byte27                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02C Byte28                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02D Byte29                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02E Byte30                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02F Byte31                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
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
    // 020 SByte16                                  00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 021 SByte17                                  00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 022 SByte18                                  00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 023 SByte19                                  00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 024 SByte20                                  00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 025 SByte21                                  00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 026 SByte22                                  00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 027 SByte23                                  00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 028 SByte24                                  00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 029 SByte25                                  00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02A SByte26                                  00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02B SByte27                                  00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02C SByte28                                  00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02D SByte29                                  00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02E SByte30                                  00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02F SByte31                                  00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 010 UShort0                                  000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 012 UShort1                                  000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 014 UShort2                                  000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 016 UShort3                                  000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 018 UShort4                                  000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01A UShort5                                  000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01C UShort6                                  000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01E UShort7                                  000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 020 UShort8                                  000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 022 UShort9                                  000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 024 UShort10                                 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 026 UShort11                                 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 028 UShort12                                 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 02A UShort13                                 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 02C UShort14                                 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 02E UShort15                                 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 010 SShort0                                  0001865F1520 ModelPrimitiveType short short short Int16
    // 012 SShort1                                  0001865F1520 ModelPrimitiveType short short short Int16
    // 014 SShort2                                  0001865F1520 ModelPrimitiveType short short short Int16
    // 016 SShort3                                  0001865F1520 ModelPrimitiveType short short short Int16
    // 018 SShort4                                  0001865F1520 ModelPrimitiveType short short short Int16
    // 01A SShort5                                  0001865F1520 ModelPrimitiveType short short short Int16
    // 01C SShort6                                  0001865F1520 ModelPrimitiveType short short short Int16
    // 01E SShort7                                  0001865F1520 ModelPrimitiveType short short short Int16
    // 020 SShort8                                  0001865F1520 ModelPrimitiveType short short short Int16
    // 022 SShort9                                  0001865F1520 ModelPrimitiveType short short short Int16
    // 024 SShort10                                 0001865F1520 ModelPrimitiveType short short short Int16
    // 026 SShort11                                 0001865F1520 ModelPrimitiveType short short short Int16
    // 028 SShort12                                 0001865F1520 ModelPrimitiveType short short short Int16
    // 02A SShort13                                 0001865F1520 ModelPrimitiveType short short short Int16
    // 02C SShort14                                 0001865F1520 ModelPrimitiveType short short short Int16
    // 02E SShort15                                 0001865F1520 ModelPrimitiveType short short short Int16
    // 010 UInt0                                    0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 UInt1                                    0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 UInt2                                    0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 01C UInt3                                    0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 020 UInt4                                    0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 024 UInt5                                    0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 028 UInt6                                    0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 02C UInt7                                    0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 010 SInt0                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 SInt1                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 SInt2                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C SInt3                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 SInt4                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 SInt5                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 SInt6                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 02C SInt7                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 010 ULong0                                   00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64
    // 018 ULong1                                   00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64
    // 020 ULong2                                   00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64
    // 028 ULong3                                   00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64
    // 010 SLong0                                   0001865F7E40 ModelPrimitiveType long long long Int64
    // 018 SLong1                                   0001865F7E40 ModelPrimitiveType long long long Int64
    // 020 SLong2                                   0001865F7E40 ModelPrimitiveType long long long Int64
    // 028 SLong3                                   0001865F7E40 ModelPrimitiveType long long long Int64
    // 010 Float0                                   000186666050 ModelPrimitiveType float float float Single
    // 014 Float1                                   000186666050 ModelPrimitiveType float float float Single
    // 018 Float2                                   000186666050 ModelPrimitiveType float float float Single
    // 01C Float3                                   000186666050 ModelPrimitiveType float float float Single
    // 020 Float4                                   000186666050 ModelPrimitiveType float float float Single
    // 024 Float5                                   000186666050 ModelPrimitiveType float float float Single
    // 028 Float6                                   000186666050 ModelPrimitiveType float float float Single
    // 02C Float7                                   000186666050 ModelPrimitiveType float float float Single
    // 010 Double0                                  0001865C2E50 ModelPrimitiveType double double double Double
    // 018 Double1                                  0001865C2E50 ModelPrimitiveType double double double Double
    // 020 Double2                                  0001865C2E50 ModelPrimitiveType double double double Double
    // 028 Double3                                  0001865C2E50 ModelPrimitiveType double double double Double
    // 010 Lo128                                    0001866CC760 ModelEnumType v128 v128 v128 Int32
    // 020 Hi128                                    0001866CC760 ModelEnumType v128 v128 v128 Int32
    public partial class v256 : DataModel
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
        public sbyte                                    Byte16                                  { get; set; }
        public sbyte                                    Byte17                                  { get; set; }
        public sbyte                                    Byte18                                  { get; set; }
        public sbyte                                    Byte19                                  { get; set; }
        public sbyte                                    Byte20                                  { get; set; }
        public sbyte                                    Byte21                                  { get; set; }
        public sbyte                                    Byte22                                  { get; set; }
        public sbyte                                    Byte23                                  { get; set; }
        public sbyte                                    Byte24                                  { get; set; }
        public sbyte                                    Byte25                                  { get; set; }
        public sbyte                                    Byte26                                  { get; set; }
        public sbyte                                    Byte27                                  { get; set; }
        public sbyte                                    Byte28                                  { get; set; }
        public sbyte                                    Byte29                                  { get; set; }
        public sbyte                                    Byte30                                  { get; set; }
        public sbyte                                    Byte31                                  { get; set; }
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
        public sbyte                                    SByte16                                 { get; set; }
        public sbyte                                    SByte17                                 { get; set; }
        public sbyte                                    SByte18                                 { get; set; }
        public sbyte                                    SByte19                                 { get; set; }
        public sbyte                                    SByte20                                 { get; set; }
        public sbyte                                    SByte21                                 { get; set; }
        public sbyte                                    SByte22                                 { get; set; }
        public sbyte                                    SByte23                                 { get; set; }
        public sbyte                                    SByte24                                 { get; set; }
        public sbyte                                    SByte25                                 { get; set; }
        public sbyte                                    SByte26                                 { get; set; }
        public sbyte                                    SByte27                                 { get; set; }
        public sbyte                                    SByte28                                 { get; set; }
        public sbyte                                    SByte29                                 { get; set; }
        public sbyte                                    SByte30                                 { get; set; }
        public sbyte                                    SByte31                                 { get; set; }
        public ushort                                   UShort0                                 { get; set; }
        public ushort                                   UShort1                                 { get; set; }
        public ushort                                   UShort2                                 { get; set; }
        public ushort                                   UShort3                                 { get; set; }
        public ushort                                   UShort4                                 { get; set; }
        public ushort                                   UShort5                                 { get; set; }
        public ushort                                   UShort6                                 { get; set; }
        public ushort                                   UShort7                                 { get; set; }
        public ushort                                   UShort8                                 { get; set; }
        public ushort                                   UShort9                                 { get; set; }
        public ushort                                   UShort10                                { get; set; }
        public ushort                                   UShort11                                { get; set; }
        public ushort                                   UShort12                                { get; set; }
        public ushort                                   UShort13                                { get; set; }
        public ushort                                   UShort14                                { get; set; }
        public ushort                                   UShort15                                { get; set; }
        public short                                    SShort0                                 { get; set; }
        public short                                    SShort1                                 { get; set; }
        public short                                    SShort2                                 { get; set; }
        public short                                    SShort3                                 { get; set; }
        public short                                    SShort4                                 { get; set; }
        public short                                    SShort5                                 { get; set; }
        public short                                    SShort6                                 { get; set; }
        public short                                    SShort7                                 { get; set; }
        public short                                    SShort8                                 { get; set; }
        public short                                    SShort9                                 { get; set; }
        public short                                    SShort10                                { get; set; }
        public short                                    SShort11                                { get; set; }
        public short                                    SShort12                                { get; set; }
        public short                                    SShort13                                { get; set; }
        public short                                    SShort14                                { get; set; }
        public short                                    SShort15                                { get; set; }
        public uint                                     UInt0                                   { get; set; }
        public uint                                     UInt1                                   { get; set; }
        public uint                                     UInt2                                   { get; set; }
        public uint                                     UInt3                                   { get; set; }
        public uint                                     UInt4                                   { get; set; }
        public uint                                     UInt5                                   { get; set; }
        public uint                                     UInt6                                   { get; set; }
        public uint                                     UInt7                                   { get; set; }
        public int                                      SInt0                                   { get; set; }
        public int                                      SInt1                                   { get; set; }
        public int                                      SInt2                                   { get; set; }
        public int                                      SInt3                                   { get; set; }
        public int                                      SInt4                                   { get; set; }
        public int                                      SInt5                                   { get; set; }
        public int                                      SInt6                                   { get; set; }
        public int                                      SInt7                                   { get; set; }
        public ulong                                    ULong0                                  { get; set; }
        public ulong                                    ULong1                                  { get; set; }
        public ulong                                    ULong2                                  { get; set; }
        public ulong                                    ULong3                                  { get; set; }
        public long                                     SLong0                                  { get; set; }
        public long                                     SLong1                                  { get; set; }
        public long                                     SLong2                                  { get; set; }
        public long                                     SLong3                                  { get; set; }
        public float                                    Float0                                  { get; set; }
        public float                                    Float1                                  { get; set; }
        public float                                    Float2                                  { get; set; }
        public float                                    Float3                                  { get; set; }
        public float                                    Float4                                  { get; set; }
        public float                                    Float5                                  { get; set; }
        public float                                    Float6                                  { get; set; }
        public float                                    Float7                                  { get; set; }
        public double                                   Double0                                 { get; set; }
        public double                                   Double1                                 { get; set; }
        public double                                   Double2                                 { get; set; }
        public double                                   Double3                                 { get; set; }
        public v128                                     Lo128                                   { get; set; }
        public v128                                     Hi128                                   { get; set; }

        public static v256? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new v256() { Pointer= p0 };

            value.Byte0                                     = GetSByte(new IntPtr(p + 0x010)); // 02466A96F728 0x10 Byte0                       ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte1                                     = GetSByte(new IntPtr(p + 0x011)); // 02466A96F748 0x11 Byte1                       ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte2                                     = GetSByte(new IntPtr(p + 0x012)); // 02466A96F768 0x12 Byte2                       ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte3                                     = GetSByte(new IntPtr(p + 0x013)); // 02466A96F788 0x13 Byte3                       ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte4                                     = GetSByte(new IntPtr(p + 0x014)); // 02466A96F7A8 0x14 Byte4                       ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte5                                     = GetSByte(new IntPtr(p + 0x015)); // 02466A96F7C8 0x15 Byte5                       ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte6                                     = GetSByte(new IntPtr(p + 0x016)); // 02466A96F7E8 0x16 Byte6                       ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte7                                     = GetSByte(new IntPtr(p + 0x017)); // 02466A96F808 0x17 Byte7                       ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte8                                     = GetSByte(new IntPtr(p + 0x018)); // 02466A96F828 0x18 Byte8                       ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte9                                     = GetSByte(new IntPtr(p + 0x019)); // 02466A96F848 0x19 Byte9                       ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte10                                    = GetSByte(new IntPtr(p + 0x01A)); // 02466A96F868 0x1A Byte10                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte11                                    = GetSByte(new IntPtr(p + 0x01B)); // 02466A96F888 0x1B Byte11                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte12                                    = GetSByte(new IntPtr(p + 0x01C)); // 02466A96F8A8 0x1C Byte12                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte13                                    = GetSByte(new IntPtr(p + 0x01D)); // 02466A96F8C8 0x1D Byte13                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte14                                    = GetSByte(new IntPtr(p + 0x01E)); // 02466A96F8E8 0x1E Byte14                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte15                                    = GetSByte(new IntPtr(p + 0x01F)); // 02466A96F908 0x1F Byte15                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte16                                    = GetSByte(new IntPtr(p + 0x020)); // 02466A96F928 0x20 Byte16                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte17                                    = GetSByte(new IntPtr(p + 0x021)); // 02466A96F948 0x21 Byte17                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte18                                    = GetSByte(new IntPtr(p + 0x022)); // 02466A96F968 0x22 Byte18                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte19                                    = GetSByte(new IntPtr(p + 0x023)); // 02466A96F988 0x23 Byte19                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte20                                    = GetSByte(new IntPtr(p + 0x024)); // 02466A96F9A8 0x24 Byte20                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte21                                    = GetSByte(new IntPtr(p + 0x025)); // 02466A96F9C8 0x25 Byte21                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte22                                    = GetSByte(new IntPtr(p + 0x026)); // 02466A96F9E8 0x26 Byte22                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte23                                    = GetSByte(new IntPtr(p + 0x027)); // 02466A96FA08 0x27 Byte23                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte24                                    = GetSByte(new IntPtr(p + 0x028)); // 02466A96FA28 0x28 Byte24                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte25                                    = GetSByte(new IntPtr(p + 0x029)); // 02466A96FA48 0x29 Byte25                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte26                                    = GetSByte(new IntPtr(p + 0x02A)); // 02466A96FA68 0x2A Byte26                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte27                                    = GetSByte(new IntPtr(p + 0x02B)); // 02466A96FA88 0x2B Byte27                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte28                                    = GetSByte(new IntPtr(p + 0x02C)); // 02466A96FAA8 0x2C Byte28                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte29                                    = GetSByte(new IntPtr(p + 0x02D)); // 02466A96FAC8 0x2D Byte29                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte30                                    = GetSByte(new IntPtr(p + 0x02E)); // 02466A96FAE8 0x2E Byte30                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte31                                    = GetSByte(new IntPtr(p + 0x02F)); // 02466A96FB08 0x2F Byte31                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte0                                    = GetSByte(new IntPtr(p + 0x010)); // 02466A96FB28 0x10 SByte0                      ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte1                                    = GetSByte(new IntPtr(p + 0x011)); // 02466A96FB48 0x11 SByte1                      ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte2                                    = GetSByte(new IntPtr(p + 0x012)); // 02466A96FB68 0x12 SByte2                      ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte3                                    = GetSByte(new IntPtr(p + 0x013)); // 02466A96FB88 0x13 SByte3                      ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte4                                    = GetSByte(new IntPtr(p + 0x014)); // 02466A96FBA8 0x14 SByte4                      ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte5                                    = GetSByte(new IntPtr(p + 0x015)); // 02466A96FBC8 0x15 SByte5                      ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte6                                    = GetSByte(new IntPtr(p + 0x016)); // 02466A96FBE8 0x16 SByte6                      ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte7                                    = GetSByte(new IntPtr(p + 0x017)); // 02466A96FC08 0x17 SByte7                      ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte8                                    = GetSByte(new IntPtr(p + 0x018)); // 02466A96FC28 0x18 SByte8                      ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte9                                    = GetSByte(new IntPtr(p + 0x019)); // 02466A96FC48 0x19 SByte9                      ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte10                                   = GetSByte(new IntPtr(p + 0x01A)); // 02466A96FC68 0x1A SByte10                     ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte11                                   = GetSByte(new IntPtr(p + 0x01B)); // 02466A96FC88 0x1B SByte11                     ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte12                                   = GetSByte(new IntPtr(p + 0x01C)); // 02466A96FCA8 0x1C SByte12                     ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte13                                   = GetSByte(new IntPtr(p + 0x01D)); // 02466A96FCC8 0x1D SByte13                     ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte14                                   = GetSByte(new IntPtr(p + 0x01E)); // 02466A96FCE8 0x1E SByte14                     ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte15                                   = GetSByte(new IntPtr(p + 0x01F)); // 02466A96FD08 0x1F SByte15                     ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte16                                   = GetSByte(new IntPtr(p + 0x020)); // 02466A96FD28 0x20 SByte16                     ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte17                                   = GetSByte(new IntPtr(p + 0x021)); // 02466A96FD48 0x21 SByte17                     ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte18                                   = GetSByte(new IntPtr(p + 0x022)); // 02466A96FD68 0x22 SByte18                     ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte19                                   = GetSByte(new IntPtr(p + 0x023)); // 02466A96FD88 0x23 SByte19                     ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte20                                   = GetSByte(new IntPtr(p + 0x024)); // 02466A96FDA8 0x24 SByte20                     ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte21                                   = GetSByte(new IntPtr(p + 0x025)); // 02466A96FDC8 0x25 SByte21                     ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte22                                   = GetSByte(new IntPtr(p + 0x026)); // 02466A96FDE8 0x26 SByte22                     ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte23                                   = GetSByte(new IntPtr(p + 0x027)); // 02466A96FE08 0x27 SByte23                     ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte24                                   = GetSByte(new IntPtr(p + 0x028)); // 02466A96FE28 0x28 SByte24                     ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte25                                   = GetSByte(new IntPtr(p + 0x029)); // 02466A96FE48 0x29 SByte25                     ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte26                                   = GetSByte(new IntPtr(p + 0x02A)); // 02466A96FE68 0x2A SByte26                     ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte27                                   = GetSByte(new IntPtr(p + 0x02B)); // 02466A96FE88 0x2B SByte27                     ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte28                                   = GetSByte(new IntPtr(p + 0x02C)); // 02466A96FEA8 0x2C SByte28                     ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte29                                   = GetSByte(new IntPtr(p + 0x02D)); // 02466A96FEC8 0x2D SByte29                     ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte30                                   = GetSByte(new IntPtr(p + 0x02E)); // 02466A96FEE8 0x2E SByte30                     ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte31                                   = GetSByte(new IntPtr(p + 0x02F)); // 02466A96FF08 0x2F SByte31                     ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.UShort0                                   = GetUInt16(new IntPtr(p + 0x010)); // 02466A96FF28 0x10 UShort0                     ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UShort1                                   = GetUInt16(new IntPtr(p + 0x012)); // 02466A96FF48 0x12 UShort1                     ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UShort2                                   = GetUInt16(new IntPtr(p + 0x014)); // 02466A96FF68 0x14 UShort2                     ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UShort3                                   = GetUInt16(new IntPtr(p + 0x016)); // 02466A96FF88 0x16 UShort3                     ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UShort4                                   = GetUInt16(new IntPtr(p + 0x018)); // 02466A96FFA8 0x18 UShort4                     ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UShort5                                   = GetUInt16(new IntPtr(p + 0x01A)); // 02466A96FFC8 0x1A UShort5                     ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UShort6                                   = GetUInt16(new IntPtr(p + 0x01C)); // 02466A96FFE8 0x1C UShort6                     ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UShort7                                   = GetUInt16(new IntPtr(p + 0x01E)); // 02466A970008 0x1E UShort7                     ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UShort8                                   = GetUInt16(new IntPtr(p + 0x020)); // 02466A970028 0x20 UShort8                     ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UShort9                                   = GetUInt16(new IntPtr(p + 0x022)); // 02466A970048 0x22 UShort9                     ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UShort10                                  = GetUInt16(new IntPtr(p + 0x024)); // 02466A970068 0x24 UShort10                    ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UShort11                                  = GetUInt16(new IntPtr(p + 0x026)); // 02466A970088 0x26 UShort11                    ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UShort12                                  = GetUInt16(new IntPtr(p + 0x028)); // 02466A9700A8 0x28 UShort12                    ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UShort13                                  = GetUInt16(new IntPtr(p + 0x02A)); // 02466A9700C8 0x2A UShort13                    ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UShort14                                  = GetUInt16(new IntPtr(p + 0x02C)); // 02466A9700E8 0x2C UShort14                    ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UShort15                                  = GetUInt16(new IntPtr(p + 0x02E)); // 02466A970108 0x2E UShort15                    ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.SShort0                                   = GetInt16(new IntPtr(p + 0x010)); // 02466A970128 0x10 SShort0                     ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.SShort1                                   = GetInt16(new IntPtr(p + 0x012)); // 02466A970148 0x12 SShort1                     ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.SShort2                                   = GetInt16(new IntPtr(p + 0x014)); // 02466A970168 0x14 SShort2                     ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.SShort3                                   = GetInt16(new IntPtr(p + 0x016)); // 02466A970188 0x16 SShort3                     ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.SShort4                                   = GetInt16(new IntPtr(p + 0x018)); // 02466A9701A8 0x18 SShort4                     ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.SShort5                                   = GetInt16(new IntPtr(p + 0x01A)); // 02466A9701C8 0x1A SShort5                     ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.SShort6                                   = GetInt16(new IntPtr(p + 0x01C)); // 02466A9701E8 0x1C SShort6                     ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.SShort7                                   = GetInt16(new IntPtr(p + 0x01E)); // 02466A970208 0x1E SShort7                     ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.SShort8                                   = GetInt16(new IntPtr(p + 0x020)); // 02466A970228 0x20 SShort8                     ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.SShort9                                   = GetInt16(new IntPtr(p + 0x022)); // 02466A970248 0x22 SShort9                     ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.SShort10                                  = GetInt16(new IntPtr(p + 0x024)); // 02466A970268 0x24 SShort10                    ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.SShort11                                  = GetInt16(new IntPtr(p + 0x026)); // 02466A970288 0x26 SShort11                    ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.SShort12                                  = GetInt16(new IntPtr(p + 0x028)); // 02466A9702A8 0x28 SShort12                    ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.SShort13                                  = GetInt16(new IntPtr(p + 0x02A)); // 02466A9702C8 0x2A SShort13                    ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.SShort14                                  = GetInt16(new IntPtr(p + 0x02C)); // 02466A9702E8 0x2C SShort14                    ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.SShort15                                  = GetInt16(new IntPtr(p + 0x02E)); // 02466A970308 0x2E SShort15                    ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.UInt0                                     = GetUInt32(new IntPtr(p + 0x010)); // 02466A970328 0x10 UInt0                       ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.UInt1                                     = GetUInt32(new IntPtr(p + 0x014)); // 02466A970348 0x14 UInt1                       ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.UInt2                                     = GetUInt32(new IntPtr(p + 0x018)); // 02466A970368 0x18 UInt2                       ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.UInt3                                     = GetUInt32(new IntPtr(p + 0x01C)); // 02466A970388 0x1C UInt3                       ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.UInt4                                     = GetUInt32(new IntPtr(p + 0x020)); // 02466A9703A8 0x20 UInt4                       ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.UInt5                                     = GetUInt32(new IntPtr(p + 0x024)); // 02466A9703C8 0x24 UInt5                       ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.UInt6                                     = GetUInt32(new IntPtr(p + 0x028)); // 02466A9703E8 0x28 UInt6                       ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.UInt7                                     = GetUInt32(new IntPtr(p + 0x02C)); // 02466A970408 0x2C UInt7                       ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.SInt0                                     = GetInt32(new IntPtr(p + 0x010)); // 02466A970428 0x10 SInt0                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SInt1                                     = GetInt32(new IntPtr(p + 0x014)); // 02466A970448 0x14 SInt1                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SInt2                                     = GetInt32(new IntPtr(p + 0x018)); // 02466A970468 0x18 SInt2                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SInt3                                     = GetInt32(new IntPtr(p + 0x01C)); // 02466A970488 0x1C SInt3                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SInt4                                     = GetInt32(new IntPtr(p + 0x020)); // 02466A9704A8 0x20 SInt4                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SInt5                                     = GetInt32(new IntPtr(p + 0x024)); // 02466A9704C8 0x24 SInt5                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SInt6                                     = GetInt32(new IntPtr(p + 0x028)); // 02466A9704E8 0x28 SInt6                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SInt7                                     = GetInt32(new IntPtr(p + 0x02C)); // 02466A970508 0x2C SInt7                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ULong0                                    = GetUInt64(new IntPtr(p + 0x010)); // 02466A970528 0x10 ULong0                      ( 00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.ULong1                                    = GetUInt64(new IntPtr(p + 0x018)); // 02466A970548 0x18 ULong1                      ( 00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.ULong2                                    = GetUInt64(new IntPtr(p + 0x020)); // 02466A970568 0x20 ULong2                      ( 00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.ULong3                                    = GetUInt64(new IntPtr(p + 0x028)); // 02466A970588 0x28 ULong3                      ( 00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.SLong0                                    = GetInt64(new IntPtr(p + 0x010)); // 02466A9705A8 0x10 SLong0                      ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.SLong1                                    = GetInt64(new IntPtr(p + 0x018)); // 02466A9705C8 0x18 SLong1                      ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.SLong2                                    = GetInt64(new IntPtr(p + 0x020)); // 02466A9705E8 0x20 SLong2                      ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.SLong3                                    = GetInt64(new IntPtr(p + 0x028)); // 02466A970608 0x28 SLong3                      ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.Float0                                    = GetSingle(new IntPtr(p + 0x010)); // 02466A970628 0x10 Float0                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Float1                                    = GetSingle(new IntPtr(p + 0x014)); // 02466A970648 0x14 Float1                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Float2                                    = GetSingle(new IntPtr(p + 0x018)); // 02466A970668 0x18 Float2                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Float3                                    = GetSingle(new IntPtr(p + 0x01C)); // 02466A970688 0x1C Float3                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Float4                                    = GetSingle(new IntPtr(p + 0x020)); // 02466A9706A8 0x20 Float4                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Float5                                    = GetSingle(new IntPtr(p + 0x024)); // 02466A9706C8 0x24 Float5                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Float6                                    = GetSingle(new IntPtr(p + 0x028)); // 02466A9706E8 0x28 Float6                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Float7                                    = GetSingle(new IntPtr(p + 0x02C)); // 02466A970708 0x2C Float7                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Double0                                   = GetDouble(new IntPtr(p + 0x010)); // 02466A970728 0x10 Double0                     ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.Double1                                   = GetDouble(new IntPtr(p + 0x018)); // 02466A970748 0x18 Double1                     ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.Double2                                   = GetDouble(new IntPtr(p + 0x020)); // 02466A970768 0x20 Double2                     ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.Double3                                   = GetDouble(new IntPtr(p + 0x028)); // 02466A970788 0x28 Double3                     ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.Lo128                                     = (v128)GetInt32(new IntPtr(p + 0x010)); // 02466A9707A8 0x10 Lo128                       ( 0001866CC760 ModelEnumType v128 v128 v128 Int32 )
            value.Hi128                                     = (v128)GetInt32(new IntPtr(p + 0x020)); // 02466A9707C8 0x20 Hi128                       ( 0001866CC760 ModelEnumType v128 v128 v128 Int32 )

            return value;
        }
    }
}
