using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Byte_0                                   00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 Byte_1                                   00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 Byte_2                                   00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 Byte_3                                   00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 Byte_4                                   00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 015 Byte_5                                   00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 016 Byte_6                                   00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 017 Byte_7                                   00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 Byte_8                                   00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 019 Byte_9                                   00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01A Byte_10                                  00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01B Byte_11                                  00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01C Byte_12                                  00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01D Byte_13                                  00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01E Byte_14                                  00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01F Byte_15                                  00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 010 Sbyte_0                                  00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 Sbyte_1                                  00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 Sbyte_2                                  00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 Sbyte_3                                  00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 Sbyte_4                                  00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 015 Sbyte_5                                  00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 016 Sbyte_6                                  00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 017 Sbyte_7                                  00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 Sbyte_8                                  00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 019 Sbyte_9                                  00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01A Sbyte_10                                 00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01B Sbyte_11                                 00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01C Sbyte_12                                 00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01D Sbyte_13                                 00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01E Sbyte_14                                 00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01F Sbyte_15                                 00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 010 Uint16_0                                 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16
    // 012 Uint16_1                                 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16
    // 014 Uint16_2                                 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16
    // 016 Uint16_3                                 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16
    // 018 Uint16_4                                 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01A Uint16_5                                 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01C Uint16_6                                 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01E Uint16_7                                 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16
    // 010 Int16_0                                  0001865F12C0 ModelPrimitiveType short short short Int16
    // 012 Int16_1                                  0001865F12C0 ModelPrimitiveType short short short Int16
    // 014 Int16_2                                  0001865F12C0 ModelPrimitiveType short short short Int16
    // 016 Int16_3                                  0001865F12C0 ModelPrimitiveType short short short Int16
    // 018 Int16_4                                  0001865F12C0 ModelPrimitiveType short short short Int16
    // 01A Int16_5                                  0001865F12C0 ModelPrimitiveType short short short Int16
    // 01C Int16_6                                  0001865F12C0 ModelPrimitiveType short short short Int16
    // 01E Int16_7                                  0001865F12C0 ModelPrimitiveType short short short Int16
    // 010 Uint32_0                                 000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 014 Uint32_1                                 000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 018 Uint32_2                                 000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 01C Uint32_3                                 000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 010 Int32_0                                  0001865F2F90 ModelPrimitiveType int int int Int32
    // 014 Int32_1                                  0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 Int32_2                                  0001865F2F90 ModelPrimitiveType int int int Int32
    // 01C Int32_3                                  0001865F2F90 ModelPrimitiveType int int int Int32
    // 010 Uint64_0                                 00018669BB50 ModelPrimitiveType ulong ulong ulong UInt64
    // 018 Uint64_1                                 00018669BB50 ModelPrimitiveType ulong ulong ulong UInt64
    // 010 Int64_0                                  0001865F79C0 ModelPrimitiveType long long long Int64
    // 018 Int64_1                                  0001865F79C0 ModelPrimitiveType long long long Int64
    // 010 Single_0                                 000186665900 ModelPrimitiveType float float float Single
    // 014 Single_1                                 000186665900 ModelPrimitiveType float float float Single
    // 018 Single_2                                 000186665900 ModelPrimitiveType float float float Single
    // 01C Single_3                                 000186665900 ModelPrimitiveType float float float Single
    // 010 Double_0                                 0001865C2BA0 ModelPrimitiveType double double double Double
    // 018 Double_1                                 0001865C2BA0 ModelPrimitiveType double double double Double
    public partial class Register : DataModel
    {
        public sbyte                                    Byte_0                                  { get; set; }
        public sbyte                                    Byte_1                                  { get; set; }
        public sbyte                                    Byte_2                                  { get; set; }
        public sbyte                                    Byte_3                                  { get; set; }
        public sbyte                                    Byte_4                                  { get; set; }
        public sbyte                                    Byte_5                                  { get; set; }
        public sbyte                                    Byte_6                                  { get; set; }
        public sbyte                                    Byte_7                                  { get; set; }
        public sbyte                                    Byte_8                                  { get; set; }
        public sbyte                                    Byte_9                                  { get; set; }
        public sbyte                                    Byte_10                                 { get; set; }
        public sbyte                                    Byte_11                                 { get; set; }
        public sbyte                                    Byte_12                                 { get; set; }
        public sbyte                                    Byte_13                                 { get; set; }
        public sbyte                                    Byte_14                                 { get; set; }
        public sbyte                                    Byte_15                                 { get; set; }
        public sbyte                                    Sbyte_0                                 { get; set; }
        public sbyte                                    Sbyte_1                                 { get; set; }
        public sbyte                                    Sbyte_2                                 { get; set; }
        public sbyte                                    Sbyte_3                                 { get; set; }
        public sbyte                                    Sbyte_4                                 { get; set; }
        public sbyte                                    Sbyte_5                                 { get; set; }
        public sbyte                                    Sbyte_6                                 { get; set; }
        public sbyte                                    Sbyte_7                                 { get; set; }
        public sbyte                                    Sbyte_8                                 { get; set; }
        public sbyte                                    Sbyte_9                                 { get; set; }
        public sbyte                                    Sbyte_10                                { get; set; }
        public sbyte                                    Sbyte_11                                { get; set; }
        public sbyte                                    Sbyte_12                                { get; set; }
        public sbyte                                    Sbyte_13                                { get; set; }
        public sbyte                                    Sbyte_14                                { get; set; }
        public sbyte                                    Sbyte_15                                { get; set; }
        public ushort                                   Uint16_0                                { get; set; }
        public ushort                                   Uint16_1                                { get; set; }
        public ushort                                   Uint16_2                                { get; set; }
        public ushort                                   Uint16_3                                { get; set; }
        public ushort                                   Uint16_4                                { get; set; }
        public ushort                                   Uint16_5                                { get; set; }
        public ushort                                   Uint16_6                                { get; set; }
        public ushort                                   Uint16_7                                { get; set; }
        public short                                    Int16_0                                 { get; set; }
        public short                                    Int16_1                                 { get; set; }
        public short                                    Int16_2                                 { get; set; }
        public short                                    Int16_3                                 { get; set; }
        public short                                    Int16_4                                 { get; set; }
        public short                                    Int16_5                                 { get; set; }
        public short                                    Int16_6                                 { get; set; }
        public short                                    Int16_7                                 { get; set; }
        public uint                                     Uint32_0                                { get; set; }
        public uint                                     Uint32_1                                { get; set; }
        public uint                                     Uint32_2                                { get; set; }
        public uint                                     Uint32_3                                { get; set; }
        public int                                      Int32_0                                 { get; set; }
        public int                                      Int32_1                                 { get; set; }
        public int                                      Int32_2                                 { get; set; }
        public int                                      Int32_3                                 { get; set; }
        public ulong                                    Uint64_0                                { get; set; }
        public ulong                                    Uint64_1                                { get; set; }
        public long                                     Int64_0                                 { get; set; }
        public long                                     Int64_1                                 { get; set; }
        public float                                    Single_0                                { get; set; }
        public float                                    Single_1                                { get; set; }
        public float                                    Single_2                                { get; set; }
        public float                                    Single_3                                { get; set; }
        public double                                   Double_0                                { get; set; }
        public double                                   Double_1                                { get; set; }

        public static Register? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Register() { Pointer= p0 };

            value.Byte_0                                    = GetSByte(new IntPtr(p + 0x010)); // 0245A3CB81A0 0x10 Byte_0                      ( 00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_1                                    = GetSByte(new IntPtr(p + 0x011)); // 0245A3CB81C0 0x11 Byte_1                      ( 00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_2                                    = GetSByte(new IntPtr(p + 0x012)); // 0245A3CB81E0 0x12 Byte_2                      ( 00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_3                                    = GetSByte(new IntPtr(p + 0x013)); // 0245A3CB8200 0x13 Byte_3                      ( 00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_4                                    = GetSByte(new IntPtr(p + 0x014)); // 0245A3CB8220 0x14 Byte_4                      ( 00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_5                                    = GetSByte(new IntPtr(p + 0x015)); // 0245A3CB8240 0x15 Byte_5                      ( 00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_6                                    = GetSByte(new IntPtr(p + 0x016)); // 0245A3CB8260 0x16 Byte_6                      ( 00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_7                                    = GetSByte(new IntPtr(p + 0x017)); // 0245A3CB8280 0x17 Byte_7                      ( 00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_8                                    = GetSByte(new IntPtr(p + 0x018)); // 0245A3CB82A0 0x18 Byte_8                      ( 00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_9                                    = GetSByte(new IntPtr(p + 0x019)); // 0245A3CB82C0 0x19 Byte_9                      ( 00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_10                                   = GetSByte(new IntPtr(p + 0x01A)); // 0245A3CB82E0 0x1A Byte_10                     ( 00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_11                                   = GetSByte(new IntPtr(p + 0x01B)); // 0245A3CB8300 0x1B Byte_11                     ( 00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_12                                   = GetSByte(new IntPtr(p + 0x01C)); // 0245A3CB8320 0x1C Byte_12                     ( 00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_13                                   = GetSByte(new IntPtr(p + 0x01D)); // 0245A3CB8340 0x1D Byte_13                     ( 00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_14                                   = GetSByte(new IntPtr(p + 0x01E)); // 0245A3CB8360 0x1E Byte_14                     ( 00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_15                                   = GetSByte(new IntPtr(p + 0x01F)); // 0245A3CB8380 0x1F Byte_15                     ( 00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_0                                   = GetSByte(new IntPtr(p + 0x010)); // 0245A3CB83A0 0x10 Sbyte_0                     ( 00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_1                                   = GetSByte(new IntPtr(p + 0x011)); // 0245A3CB83C0 0x11 Sbyte_1                     ( 00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_2                                   = GetSByte(new IntPtr(p + 0x012)); // 0245A3CB83E0 0x12 Sbyte_2                     ( 00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_3                                   = GetSByte(new IntPtr(p + 0x013)); // 0245A3CB8400 0x13 Sbyte_3                     ( 00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_4                                   = GetSByte(new IntPtr(p + 0x014)); // 0245A3CB8420 0x14 Sbyte_4                     ( 00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_5                                   = GetSByte(new IntPtr(p + 0x015)); // 0245A3CB8440 0x15 Sbyte_5                     ( 00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_6                                   = GetSByte(new IntPtr(p + 0x016)); // 0245A3CB8460 0x16 Sbyte_6                     ( 00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_7                                   = GetSByte(new IntPtr(p + 0x017)); // 0245A3CB8480 0x17 Sbyte_7                     ( 00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_8                                   = GetSByte(new IntPtr(p + 0x018)); // 0245A3CB84A0 0x18 Sbyte_8                     ( 00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_9                                   = GetSByte(new IntPtr(p + 0x019)); // 0245A3CB84C0 0x19 Sbyte_9                     ( 00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_10                                  = GetSByte(new IntPtr(p + 0x01A)); // 0245A3CB84E0 0x1A Sbyte_10                    ( 00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_11                                  = GetSByte(new IntPtr(p + 0x01B)); // 0245A3CB8500 0x1B Sbyte_11                    ( 00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_12                                  = GetSByte(new IntPtr(p + 0x01C)); // 0245A3CB8520 0x1C Sbyte_12                    ( 00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_13                                  = GetSByte(new IntPtr(p + 0x01D)); // 0245A3CB8540 0x1D Sbyte_13                    ( 00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_14                                  = GetSByte(new IntPtr(p + 0x01E)); // 0245A3CB8560 0x1E Sbyte_14                    ( 00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_15                                  = GetSByte(new IntPtr(p + 0x01F)); // 0245A3CB8580 0x1F Sbyte_15                    ( 00018665D4D0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Uint16_0                                  = GetUInt16(new IntPtr(p + 0x010)); // 0245A3CB85A0 0x10 Uint16_0                    ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Uint16_1                                  = GetUInt16(new IntPtr(p + 0x012)); // 0245A3CB85C0 0x12 Uint16_1                    ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Uint16_2                                  = GetUInt16(new IntPtr(p + 0x014)); // 0245A3CB85E0 0x14 Uint16_2                    ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Uint16_3                                  = GetUInt16(new IntPtr(p + 0x016)); // 0245A3CB8600 0x16 Uint16_3                    ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Uint16_4                                  = GetUInt16(new IntPtr(p + 0x018)); // 0245A3CB8620 0x18 Uint16_4                    ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Uint16_5                                  = GetUInt16(new IntPtr(p + 0x01A)); // 0245A3CB8640 0x1A Uint16_5                    ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Uint16_6                                  = GetUInt16(new IntPtr(p + 0x01C)); // 0245A3CB8660 0x1C Uint16_6                    ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Uint16_7                                  = GetUInt16(new IntPtr(p + 0x01E)); // 0245A3CB8680 0x1E Uint16_7                    ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Int16_0                                   = GetInt16(new IntPtr(p + 0x010)); // 0245A3CB86A0 0x10 Int16_0                     ( 0001865F12C0 ModelPrimitiveType short short short Int16 )
            value.Int16_1                                   = GetInt16(new IntPtr(p + 0x012)); // 0245A3CB86C0 0x12 Int16_1                     ( 0001865F12C0 ModelPrimitiveType short short short Int16 )
            value.Int16_2                                   = GetInt16(new IntPtr(p + 0x014)); // 0245A3CB86E0 0x14 Int16_2                     ( 0001865F12C0 ModelPrimitiveType short short short Int16 )
            value.Int16_3                                   = GetInt16(new IntPtr(p + 0x016)); // 0245A3CB8700 0x16 Int16_3                     ( 0001865F12C0 ModelPrimitiveType short short short Int16 )
            value.Int16_4                                   = GetInt16(new IntPtr(p + 0x018)); // 0245A3CB8720 0x18 Int16_4                     ( 0001865F12C0 ModelPrimitiveType short short short Int16 )
            value.Int16_5                                   = GetInt16(new IntPtr(p + 0x01A)); // 0245A3CB8740 0x1A Int16_5                     ( 0001865F12C0 ModelPrimitiveType short short short Int16 )
            value.Int16_6                                   = GetInt16(new IntPtr(p + 0x01C)); // 0245A3CB8760 0x1C Int16_6                     ( 0001865F12C0 ModelPrimitiveType short short short Int16 )
            value.Int16_7                                   = GetInt16(new IntPtr(p + 0x01E)); // 0245A3CB8780 0x1E Int16_7                     ( 0001865F12C0 ModelPrimitiveType short short short Int16 )
            value.Uint32_0                                  = GetUInt32(new IntPtr(p + 0x010)); // 0245A3CB87A0 0x10 Uint32_0                    ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.Uint32_1                                  = GetUInt32(new IntPtr(p + 0x014)); // 0245A3CB87C0 0x14 Uint32_1                    ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.Uint32_2                                  = GetUInt32(new IntPtr(p + 0x018)); // 0245A3CB87E0 0x18 Uint32_2                    ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.Uint32_3                                  = GetUInt32(new IntPtr(p + 0x01C)); // 0245A3CB8800 0x1C Uint32_3                    ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.Int32_0                                   = GetInt32(new IntPtr(p + 0x010)); // 0245A3CB8820 0x10 Int32_0                     ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Int32_1                                   = GetInt32(new IntPtr(p + 0x014)); // 0245A3CB8840 0x14 Int32_1                     ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Int32_2                                   = GetInt32(new IntPtr(p + 0x018)); // 0245A3CB8860 0x18 Int32_2                     ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Int32_3                                   = GetInt32(new IntPtr(p + 0x01C)); // 0245A3CB8880 0x1C Int32_3                     ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Uint64_0                                  = GetUInt64(new IntPtr(p + 0x010)); // 0245A3CB88A0 0x10 Uint64_0                    ( 00018669BB50 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Uint64_1                                  = GetUInt64(new IntPtr(p + 0x018)); // 0245A3CB88C0 0x18 Uint64_1                    ( 00018669BB50 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Int64_0                                   = GetInt64(new IntPtr(p + 0x010)); // 0245A3CB88E0 0x10 Int64_0                     ( 0001865F79C0 ModelPrimitiveType long long long Int64 )
            value.Int64_1                                   = GetInt64(new IntPtr(p + 0x018)); // 0245A3CB8900 0x18 Int64_1                     ( 0001865F79C0 ModelPrimitiveType long long long Int64 )
            value.Single_0                                  = GetSingle(new IntPtr(p + 0x010)); // 0245A3CB8920 0x10 Single_0                    ( 000186665900 ModelPrimitiveType float float float Single )
            value.Single_1                                  = GetSingle(new IntPtr(p + 0x014)); // 0245A3CB8940 0x14 Single_1                    ( 000186665900 ModelPrimitiveType float float float Single )
            value.Single_2                                  = GetSingle(new IntPtr(p + 0x018)); // 0245A3CB8960 0x18 Single_2                    ( 000186665900 ModelPrimitiveType float float float Single )
            value.Single_3                                  = GetSingle(new IntPtr(p + 0x01C)); // 0245A3CB8980 0x1C Single_3                    ( 000186665900 ModelPrimitiveType float float float Single )
            value.Double_0                                  = GetDouble(new IntPtr(p + 0x010)); // 0245A3CB89A0 0x10 Double_0                    ( 0001865C2BA0 ModelPrimitiveType double double double Double )
            value.Double_1                                  = GetDouble(new IntPtr(p + 0x018)); // 0245A3CB89C0 0x18 Double_1                    ( 0001865C2BA0 ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
