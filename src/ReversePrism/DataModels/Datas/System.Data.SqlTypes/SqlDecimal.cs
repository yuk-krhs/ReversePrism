using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BStatus                                  00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 BLen                                     00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 BPrec                                    00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 BScale                                   00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 Data1                                    000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 018 Data2                                    000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 01C Data3                                    000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 020 Data4                                    000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 000 s_NUMERIC_MAX_PRECISION                  sbyte IL2CPP_TYPE_U1
    // 001 MaxPrecision                             sbyte IL2CPP_TYPE_U1
    // 002 MaxScale                                 sbyte IL2CPP_TYPE_U1
    // 003 s_bNullMask                              sbyte IL2CPP_TYPE_U1
    // 004 s_bIsNull                                sbyte IL2CPP_TYPE_U1
    // 005 s_bNotNull                               sbyte IL2CPP_TYPE_U1
    // 006 s_bReverseNullMask                       sbyte IL2CPP_TYPE_U1
    // 007 s_bSignMask                              sbyte IL2CPP_TYPE_U1
    // 008 s_bPositive                              sbyte IL2CPP_TYPE_U1
    // 009 s_bNegative                              sbyte IL2CPP_TYPE_U1
    // 00A s_bReverseSignMask                       sbyte IL2CPP_TYPE_U1
    // 00C s_uiZero                                 uint IL2CPP_TYPE_U4
    // 010 S_cNumeMax                               0001865F4BC0 ModelPrimitiveType int int int Int32
    // 018 S_lInt32Base                             0001865F89E0 ModelPrimitiveType long long long Int64
    // 020 S_ulInt32Base                            00018669C990 ModelPrimitiveType ulong ulong ulong UInt64
    // 028 S_ulInt32BaseForMod                      00018669C990 ModelPrimitiveType ulong ulong ulong UInt64
    // 030 S_llMax                                  00018669CC60 ModelPrimitiveType ulong ulong ulong UInt64
    // 038 S_ulBase10                               00018669A140 ModelPrimitiveType uint uint uint UInt32
    // 040 S_DUINT_BASE                             0001865C3A90 ModelPrimitiveType double double double Double
    // 048 S_DUINT_BASE2                            0001865C3A90 ModelPrimitiveType double double double Double
    // 050 S_DUINT_BASE3                            0001865C3A90 ModelPrimitiveType double double double Double
    // 058 S_DMAX_NUME                              0001865C3A90 ModelPrimitiveType double double double Double
    // 060 S_DBL_DIG                                00018669A140 ModelPrimitiveType uint uint uint UInt32
    // 064 S_cNumeDivScaleMin                       00018659D8C0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 068 S_rgulShiftBase                          000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 070 S_decimalHelpersLo                       000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 078 S_decimalHelpersMid                      000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 080 S_decimalHelpersHi                       000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 088 S_decimalHelpersHiHi                     000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 090 S_rgCLenFromPrec                         000185B7A290 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 098 S_ulT1                                   00018669A140 ModelPrimitiveType uint uint uint UInt32
    // 09C S_ulT2                                   00018669A140 ModelPrimitiveType uint uint uint UInt32
    // 0A0 S_ulT3                                   00018669A140 ModelPrimitiveType uint uint uint UInt32
    // 0A4 S_ulT4                                   00018669A140 ModelPrimitiveType uint uint uint UInt32
    // 0A8 S_ulT5                                   00018669A140 ModelPrimitiveType uint uint uint UInt32
    // 0AC S_ulT6                                   00018669A140 ModelPrimitiveType uint uint uint UInt32
    // 0B0 S_ulT7                                   00018669A140 ModelPrimitiveType uint uint uint UInt32
    // 0B4 S_ulT8                                   00018669A140 ModelPrimitiveType uint uint uint UInt32
    // 0B8 S_ulT9                                   00018669A140 ModelPrimitiveType uint uint uint UInt32
    // 0C0 S_dwlT10                                 00018669C990 ModelPrimitiveType ulong ulong ulong UInt64
    // 0C8 S_dwlT11                                 00018669C990 ModelPrimitiveType ulong ulong ulong UInt64
    // 0D0 S_dwlT12                                 00018669C990 ModelPrimitiveType ulong ulong ulong UInt64
    // 0D8 S_dwlT13                                 00018669C990 ModelPrimitiveType ulong ulong ulong UInt64
    // 0E0 S_dwlT14                                 00018669C990 ModelPrimitiveType ulong ulong ulong UInt64
    // 0E8 S_dwlT15                                 00018669C990 ModelPrimitiveType ulong ulong ulong UInt64
    // 0F0 S_dwlT16                                 00018669C990 ModelPrimitiveType ulong ulong ulong UInt64
    // 0F8 S_dwlT17                                 00018669C990 ModelPrimitiveType ulong ulong ulong UInt64
    // 100 S_dwlT18                                 00018669C990 ModelPrimitiveType ulong ulong ulong UInt64
    // 108 S_dwlT19                                 00018669C990 ModelPrimitiveType ulong ulong ulong UInt64
    // 110 Null                                     0001865573F0 ModelEnumType SqlDecimal SqlDecimal SqlDecimal Int32
    // 124 MinValue                                 0001865573F0 ModelEnumType SqlDecimal SqlDecimal SqlDecimal Int32
    // 138 MaxValue                                 0001865573F0 ModelEnumType SqlDecimal SqlDecimal SqlDecimal Int32
    public partial class SqlDecimal
    {
        public sbyte                                    BStatus                                 { get; set; }
        public sbyte                                    BLen                                    { get; set; }
        public sbyte                                    BPrec                                   { get; set; }
        public sbyte                                    BScale                                  { get; set; }
        public uint                                     Data1                                   { get; set; }
        public uint                                     Data2                                   { get; set; }
        public uint                                     Data3                                   { get; set; }
        public uint                                     Data4                                   { get; set; }
        public int                                      S_cNumeMax                              { get; set; }
        public long                                     S_lInt32Base                            { get; set; }
        public ulong                                    S_ulInt32Base                           { get; set; }
        public ulong                                    S_ulInt32BaseForMod                     { get; set; }
        public ulong                                    S_llMax                                 { get; set; }
        public uint                                     S_ulBase10                              { get; set; }
        public double                                   S_DUINT_BASE                            { get; set; }
        public double                                   S_DUINT_BASE2                           { get; set; }
        public double                                   S_DUINT_BASE3                           { get; set; }
        public double                                   S_DMAX_NUME                             { get; set; }
        public uint                                     S_DBL_DIG                               { get; set; }
        public sbyte                                    S_cNumeDivScaleMin                      { get; set; }
        public List<uint>?                              S_rgulShiftBase                         { get; set; }
        public List<uint>?                              S_decimalHelpersLo                      { get; set; }
        public List<uint>?                              S_decimalHelpersMid                     { get; set; }
        public List<uint>?                              S_decimalHelpersHi                      { get; set; }
        public List<uint>?                              S_decimalHelpersHiHi                    { get; set; }
        public List<sbyte>?                             S_rgCLenFromPrec                        { get; set; }
        public uint                                     S_ulT1                                  { get; set; }
        public uint                                     S_ulT2                                  { get; set; }
        public uint                                     S_ulT3                                  { get; set; }
        public uint                                     S_ulT4                                  { get; set; }
        public uint                                     S_ulT5                                  { get; set; }
        public uint                                     S_ulT6                                  { get; set; }
        public uint                                     S_ulT7                                  { get; set; }
        public uint                                     S_ulT8                                  { get; set; }
        public uint                                     S_ulT9                                  { get; set; }
        public ulong                                    S_dwlT10                                { get; set; }
        public ulong                                    S_dwlT11                                { get; set; }
        public ulong                                    S_dwlT12                                { get; set; }
        public ulong                                    S_dwlT13                                { get; set; }
        public ulong                                    S_dwlT14                                { get; set; }
        public ulong                                    S_dwlT15                                { get; set; }
        public ulong                                    S_dwlT16                                { get; set; }
        public ulong                                    S_dwlT17                                { get; set; }
        public ulong                                    S_dwlT18                                { get; set; }
        public ulong                                    S_dwlT19                                { get; set; }
        public SqlDecimal                               Null                                    { get; set; }
        public SqlDecimal                               MinValue                                { get; set; }
        public SqlDecimal                               MaxValue                                { get; set; }

        public static SqlDecimal? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlDecimal();

            value.BStatus                                   = GetSByte(new IntPtr(p + 0x010)); // 0270D8985C08 0x10 BStatus                     ( 00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.BLen                                      = GetSByte(new IntPtr(p + 0x011)); // 0270D8985C28 0x11 BLen                        ( 00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.BPrec                                     = GetSByte(new IntPtr(p + 0x012)); // 0270D8985C48 0x12 BPrec                       ( 00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.BScale                                    = GetSByte(new IntPtr(p + 0x013)); // 0270D8985C68 0x13 BScale                      ( 00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Data1                                     = GetUInt32(new IntPtr(p + 0x014)); // 0270D8985C88 0x14 Data1                       ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.Data2                                     = GetUInt32(new IntPtr(p + 0x018)); // 0270D8985CA8 0x18 Data2                       ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.Data3                                     = GetUInt32(new IntPtr(p + 0x01C)); // 0270D8985CC8 0x1C Data3                       ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.Data4                                     = GetUInt32(new IntPtr(p + 0x020)); // 0270D8985CE8 0x20 Data4                       ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.S_cNumeMax                                = GetInt32(new IntPtr(p + 0x010)); // 0270D8985E88 0x10 S_cNumeMax                  ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.S_lInt32Base                              = GetInt64(new IntPtr(p + 0x018)); // 0270D8985EA8 0x18 S_lInt32Base                ( 0001865F89E0 ModelPrimitiveType long long long Int64 )
            value.S_ulInt32Base                             = GetUInt64(new IntPtr(p + 0x020)); // 0270D8985EC8 0x20 S_ulInt32Base               ( 00018669C990 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.S_ulInt32BaseForMod                       = GetUInt64(new IntPtr(p + 0x028)); // 0270D8985EE8 0x28 S_ulInt32BaseForMod         ( 00018669C990 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.S_llMax                                   = GetUInt64(new IntPtr(p + 0x030)); // 0270D8985F08 0x30 S_llMax                     ( 00018669CC60 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.S_ulBase10                                = GetUInt32(new IntPtr(p + 0x038)); // 0270D8985F28 0x38 S_ulBase10                  ( 00018669A140 ModelPrimitiveType uint uint uint UInt32 )
            value.S_DUINT_BASE                              = GetDouble(new IntPtr(p + 0x040)); // 0270D8985F48 0x40 S_DUINT_BASE                ( 0001865C3A90 ModelPrimitiveType double double double Double )
            value.S_DUINT_BASE2                             = GetDouble(new IntPtr(p + 0x048)); // 0270D8985F68 0x48 S_DUINT_BASE2               ( 0001865C3A90 ModelPrimitiveType double double double Double )
            value.S_DUINT_BASE3                             = GetDouble(new IntPtr(p + 0x050)); // 0270D8985F88 0x50 S_DUINT_BASE3               ( 0001865C3A90 ModelPrimitiveType double double double Double )
            value.S_DMAX_NUME                               = GetDouble(new IntPtr(p + 0x058)); // 0270D8985FA8 0x58 S_DMAX_NUME                 ( 0001865C3A90 ModelPrimitiveType double double double Double )
            value.S_DBL_DIG                                 = GetUInt32(new IntPtr(p + 0x060)); // 0270D8985FC8 0x60 S_DBL_DIG                   ( 00018669A140 ModelPrimitiveType uint uint uint UInt32 )
            value.S_cNumeDivScaleMin                        = GetSByte(new IntPtr(p + 0x064)); // 0270D8985FE8 0x64 S_cNumeDivScaleMin          ( 00018659D8C0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.S_rgulShiftBase                           = GetUInt32List(new IntPtr(p + 0x068)); // 0270D8986008 0x68 S_rgulShiftBase             ( 000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.S_decimalHelpersLo                        = GetUInt32List(new IntPtr(p + 0x070)); // 0270D8986028 0x70 S_decimalHelpersLo          ( 000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.S_decimalHelpersMid                       = GetUInt32List(new IntPtr(p + 0x078)); // 0270D8986048 0x78 S_decimalHelpersMid         ( 000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.S_decimalHelpersHi                        = GetUInt32List(new IntPtr(p + 0x080)); // 0270D8986068 0x80 S_decimalHelpersHi          ( 000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.S_decimalHelpersHiHi                      = GetUInt32List(new IntPtr(p + 0x088)); // 0270D8986088 0x88 S_decimalHelpersHiHi        ( 000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.S_rgCLenFromPrec                          = GetSByteList(new IntPtr(p + 0x090)); // 0270D89860A8 0x90 S_rgCLenFromPrec            ( 000185B7A290 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.S_ulT1                                    = GetUInt32(new IntPtr(p + 0x098)); // 0270D89860C8 0x98 S_ulT1                      ( 00018669A140 ModelPrimitiveType uint uint uint UInt32 )
            value.S_ulT2                                    = GetUInt32(new IntPtr(p + 0x09C)); // 0270D89860E8 0x9C S_ulT2                      ( 00018669A140 ModelPrimitiveType uint uint uint UInt32 )
            value.S_ulT3                                    = GetUInt32(new IntPtr(p + 0x0A0)); // 0270D8986108 0xA0 S_ulT3                      ( 00018669A140 ModelPrimitiveType uint uint uint UInt32 )
            value.S_ulT4                                    = GetUInt32(new IntPtr(p + 0x0A4)); // 0270D8986128 0xA4 S_ulT4                      ( 00018669A140 ModelPrimitiveType uint uint uint UInt32 )
            value.S_ulT5                                    = GetUInt32(new IntPtr(p + 0x0A8)); // 0270D8986148 0xA8 S_ulT5                      ( 00018669A140 ModelPrimitiveType uint uint uint UInt32 )
            value.S_ulT6                                    = GetUInt32(new IntPtr(p + 0x0AC)); // 0270D8986168 0xAC S_ulT6                      ( 00018669A140 ModelPrimitiveType uint uint uint UInt32 )
            value.S_ulT7                                    = GetUInt32(new IntPtr(p + 0x0B0)); // 0270D8986188 0xB0 S_ulT7                      ( 00018669A140 ModelPrimitiveType uint uint uint UInt32 )
            value.S_ulT8                                    = GetUInt32(new IntPtr(p + 0x0B4)); // 0270D89861A8 0xB4 S_ulT8                      ( 00018669A140 ModelPrimitiveType uint uint uint UInt32 )
            value.S_ulT9                                    = GetUInt32(new IntPtr(p + 0x0B8)); // 0270D89861C8 0xB8 S_ulT9                      ( 00018669A140 ModelPrimitiveType uint uint uint UInt32 )
            value.S_dwlT10                                  = GetUInt64(new IntPtr(p + 0x0C0)); // 0270D89861E8 0xC0 S_dwlT10                    ( 00018669C990 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.S_dwlT11                                  = GetUInt64(new IntPtr(p + 0x0C8)); // 0270D8986208 0xC8 S_dwlT11                    ( 00018669C990 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.S_dwlT12                                  = GetUInt64(new IntPtr(p + 0x0D0)); // 0270D8986228 0xD0 S_dwlT12                    ( 00018669C990 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.S_dwlT13                                  = GetUInt64(new IntPtr(p + 0x0D8)); // 0270D8986248 0xD8 S_dwlT13                    ( 00018669C990 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.S_dwlT14                                  = GetUInt64(new IntPtr(p + 0x0E0)); // 0270D8986268 0xE0 S_dwlT14                    ( 00018669C990 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.S_dwlT15                                  = GetUInt64(new IntPtr(p + 0x0E8)); // 0270D8986288 0xE8 S_dwlT15                    ( 00018669C990 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.S_dwlT16                                  = GetUInt64(new IntPtr(p + 0x0F0)); // 0270D89862A8 0xF0 S_dwlT16                    ( 00018669C990 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.S_dwlT17                                  = GetUInt64(new IntPtr(p + 0x0F8)); // 0270D89862C8 0xF8 S_dwlT17                    ( 00018669C990 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.S_dwlT18                                  = GetUInt64(new IntPtr(p + 0x100)); // 0270D89862E8 0x100 S_dwlT18                    ( 00018669C990 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.S_dwlT19                                  = GetUInt64(new IntPtr(p + 0x108)); // 0270D8986308 0x108 S_dwlT19                    ( 00018669C990 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Null                                      = (SqlDecimal)GetInt32(new IntPtr(p + 0x110)); // 0270D8986328 0x110 Null                        ( 0001865573F0 ModelEnumType SqlDecimal SqlDecimal SqlDecimal Int32 )
            value.MinValue                                  = (SqlDecimal)GetInt32(new IntPtr(p + 0x124)); // 0270D8986348 0x124 MinValue                    ( 0001865573F0 ModelEnumType SqlDecimal SqlDecimal SqlDecimal Int32 )
            value.MaxValue                                  = (SqlDecimal)GetInt32(new IntPtr(p + 0x138)); // 0270D8986368 0x138 MaxValue                    ( 0001865573F0 ModelEnumType SqlDecimal SqlDecimal SqlDecimal Int32 )

            return value;
        }
    }
}
