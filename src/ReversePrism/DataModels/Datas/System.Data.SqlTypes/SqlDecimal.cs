using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BStatus                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 BLen                                     ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 BPrec                                    ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 BScale                                   ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 Data1                                    ModelPrimitiveType uint uint uint UInt32
    // 018 Data2                                    ModelPrimitiveType uint uint uint UInt32
    // 01C Data3                                    ModelPrimitiveType uint uint uint UInt32
    // 020 Data4                                    ModelPrimitiveType uint uint uint UInt32
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
    // 010 S_cNumeMax                               ModelPrimitiveType int int int Int32
    // 018 S_lInt32Base                             ModelPrimitiveType long long long Int64
    // 020 S_ulInt32Base                            ModelPrimitiveType ulong ulong ulong UInt64
    // 028 S_ulInt32BaseForMod                      ModelPrimitiveType ulong ulong ulong UInt64
    // 030 S_llMax                                  ModelPrimitiveType ulong ulong ulong UInt64
    // 038 S_ulBase10                               ModelPrimitiveType uint uint uint UInt32
    // 040 S_DUINT_BASE                             ModelPrimitiveType double double double Double
    // 048 S_DUINT_BASE2                            ModelPrimitiveType double double double Double
    // 050 S_DUINT_BASE3                            ModelPrimitiveType double double double Double
    // 058 S_DMAX_NUME                              ModelPrimitiveType double double double Double
    // 060 S_DBL_DIG                                ModelPrimitiveType uint uint uint UInt32
    // 064 S_cNumeDivScaleMin                       ModelPrimitiveType sbyte sbyte sbyte SByte
    // 068 S_rgulShiftBase                          ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 070 S_decimalHelpersLo                       ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 078 S_decimalHelpersMid                      ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 080 S_decimalHelpersHi                       ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 088 S_decimalHelpersHiHi                     ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 090 S_rgCLenFromPrec                         ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 098 S_ulT1                                   ModelPrimitiveType uint uint uint UInt32
    // 09C S_ulT2                                   ModelPrimitiveType uint uint uint UInt32
    // 0A0 S_ulT3                                   ModelPrimitiveType uint uint uint UInt32
    // 0A4 S_ulT4                                   ModelPrimitiveType uint uint uint UInt32
    // 0A8 S_ulT5                                   ModelPrimitiveType uint uint uint UInt32
    // 0AC S_ulT6                                   ModelPrimitiveType uint uint uint UInt32
    // 0B0 S_ulT7                                   ModelPrimitiveType uint uint uint UInt32
    // 0B4 S_ulT8                                   ModelPrimitiveType uint uint uint UInt32
    // 0B8 S_ulT9                                   ModelPrimitiveType uint uint uint UInt32
    // 0C0 S_dwlT10                                 ModelPrimitiveType ulong ulong ulong UInt64
    // 0C8 S_dwlT11                                 ModelPrimitiveType ulong ulong ulong UInt64
    // 0D0 S_dwlT12                                 ModelPrimitiveType ulong ulong ulong UInt64
    // 0D8 S_dwlT13                                 ModelPrimitiveType ulong ulong ulong UInt64
    // 0E0 S_dwlT14                                 ModelPrimitiveType ulong ulong ulong UInt64
    // 0E8 S_dwlT15                                 ModelPrimitiveType ulong ulong ulong UInt64
    // 0F0 S_dwlT16                                 ModelPrimitiveType ulong ulong ulong UInt64
    // 0F8 S_dwlT17                                 ModelPrimitiveType ulong ulong ulong UInt64
    // 100 S_dwlT18                                 ModelPrimitiveType ulong ulong ulong UInt64
    // 108 S_dwlT19                                 ModelPrimitiveType ulong ulong ulong UInt64
    // 110 Null                                     ModelEnumType SqlDecimal SqlDecimal SqlDecimal Int32
    // 124 MinValue                                 ModelEnumType SqlDecimal SqlDecimal SqlDecimal Int32
    // 138 MaxValue                                 ModelEnumType SqlDecimal SqlDecimal SqlDecimal Int32
    public partial class SqlDecimal : DataModel
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
            var value   = new SqlDecimal() { Pointer= p0 };

            value.BStatus                                   = GetSByte(new IntPtr(p + 0x010)); // 0x10 BStatus                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.BLen                                      = GetSByte(new IntPtr(p + 0x011)); // 0x11 BLen                        ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.BPrec                                     = GetSByte(new IntPtr(p + 0x012)); // 0x12 BPrec                       ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.BScale                                    = GetSByte(new IntPtr(p + 0x013)); // 0x13 BScale                      ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Data1                                     = GetUInt32(new IntPtr(p + 0x014)); // 0x14 Data1                       ( ModelPrimitiveType uint uint uint UInt32 )
            value.Data2                                     = GetUInt32(new IntPtr(p + 0x018)); // 0x18 Data2                       ( ModelPrimitiveType uint uint uint UInt32 )
            value.Data3                                     = GetUInt32(new IntPtr(p + 0x01C)); // 0x1C Data3                       ( ModelPrimitiveType uint uint uint UInt32 )
            value.Data4                                     = GetUInt32(new IntPtr(p + 0x020)); // 0x20 Data4                       ( ModelPrimitiveType uint uint uint UInt32 )
            value.S_cNumeMax                                = GetInt32(new IntPtr(p + 0x010)); // 0x10 S_cNumeMax                  ( ModelPrimitiveType int int int Int32 )
            value.S_lInt32Base                              = GetInt64(new IntPtr(p + 0x018)); // 0x18 S_lInt32Base                ( ModelPrimitiveType long long long Int64 )
            value.S_ulInt32Base                             = GetUInt64(new IntPtr(p + 0x020)); // 0x20 S_ulInt32Base               ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.S_ulInt32BaseForMod                       = GetUInt64(new IntPtr(p + 0x028)); // 0x28 S_ulInt32BaseForMod         ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.S_llMax                                   = GetUInt64(new IntPtr(p + 0x030)); // 0x30 S_llMax                     ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.S_ulBase10                                = GetUInt32(new IntPtr(p + 0x038)); // 0x38 S_ulBase10                  ( ModelPrimitiveType uint uint uint UInt32 )
            value.S_DUINT_BASE                              = GetDouble(new IntPtr(p + 0x040)); // 0x40 S_DUINT_BASE                ( ModelPrimitiveType double double double Double )
            value.S_DUINT_BASE2                             = GetDouble(new IntPtr(p + 0x048)); // 0x48 S_DUINT_BASE2               ( ModelPrimitiveType double double double Double )
            value.S_DUINT_BASE3                             = GetDouble(new IntPtr(p + 0x050)); // 0x50 S_DUINT_BASE3               ( ModelPrimitiveType double double double Double )
            value.S_DMAX_NUME                               = GetDouble(new IntPtr(p + 0x058)); // 0x58 S_DMAX_NUME                 ( ModelPrimitiveType double double double Double )
            value.S_DBL_DIG                                 = GetUInt32(new IntPtr(p + 0x060)); // 0x60 S_DBL_DIG                   ( ModelPrimitiveType uint uint uint UInt32 )
            value.S_cNumeDivScaleMin                        = GetSByte(new IntPtr(p + 0x064)); // 0x64 S_cNumeDivScaleMin          ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.S_rgulShiftBase                           = GetUInt32List(new IntPtr(p + 0x068)); // 0x68 S_rgulShiftBase             ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.S_decimalHelpersLo                        = GetUInt32List(new IntPtr(p + 0x070)); // 0x70 S_decimalHelpersLo          ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.S_decimalHelpersMid                       = GetUInt32List(new IntPtr(p + 0x078)); // 0x78 S_decimalHelpersMid         ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.S_decimalHelpersHi                        = GetUInt32List(new IntPtr(p + 0x080)); // 0x80 S_decimalHelpersHi          ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.S_decimalHelpersHiHi                      = GetUInt32List(new IntPtr(p + 0x088)); // 0x88 S_decimalHelpersHiHi        ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.S_rgCLenFromPrec                          = GetSByteList(new IntPtr(p + 0x090)); // 0x90 S_rgCLenFromPrec            ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.S_ulT1                                    = GetUInt32(new IntPtr(p + 0x098)); // 0x98 S_ulT1                      ( ModelPrimitiveType uint uint uint UInt32 )
            value.S_ulT2                                    = GetUInt32(new IntPtr(p + 0x09C)); // 0x9C S_ulT2                      ( ModelPrimitiveType uint uint uint UInt32 )
            value.S_ulT3                                    = GetUInt32(new IntPtr(p + 0x0A0)); // 0xA0 S_ulT3                      ( ModelPrimitiveType uint uint uint UInt32 )
            value.S_ulT4                                    = GetUInt32(new IntPtr(p + 0x0A4)); // 0xA4 S_ulT4                      ( ModelPrimitiveType uint uint uint UInt32 )
            value.S_ulT5                                    = GetUInt32(new IntPtr(p + 0x0A8)); // 0xA8 S_ulT5                      ( ModelPrimitiveType uint uint uint UInt32 )
            value.S_ulT6                                    = GetUInt32(new IntPtr(p + 0x0AC)); // 0xAC S_ulT6                      ( ModelPrimitiveType uint uint uint UInt32 )
            value.S_ulT7                                    = GetUInt32(new IntPtr(p + 0x0B0)); // 0xB0 S_ulT7                      ( ModelPrimitiveType uint uint uint UInt32 )
            value.S_ulT8                                    = GetUInt32(new IntPtr(p + 0x0B4)); // 0xB4 S_ulT8                      ( ModelPrimitiveType uint uint uint UInt32 )
            value.S_ulT9                                    = GetUInt32(new IntPtr(p + 0x0B8)); // 0xB8 S_ulT9                      ( ModelPrimitiveType uint uint uint UInt32 )
            value.S_dwlT10                                  = GetUInt64(new IntPtr(p + 0x0C0)); // 0xC0 S_dwlT10                    ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.S_dwlT11                                  = GetUInt64(new IntPtr(p + 0x0C8)); // 0xC8 S_dwlT11                    ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.S_dwlT12                                  = GetUInt64(new IntPtr(p + 0x0D0)); // 0xD0 S_dwlT12                    ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.S_dwlT13                                  = GetUInt64(new IntPtr(p + 0x0D8)); // 0xD8 S_dwlT13                    ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.S_dwlT14                                  = GetUInt64(new IntPtr(p + 0x0E0)); // 0xE0 S_dwlT14                    ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.S_dwlT15                                  = GetUInt64(new IntPtr(p + 0x0E8)); // 0xE8 S_dwlT15                    ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.S_dwlT16                                  = GetUInt64(new IntPtr(p + 0x0F0)); // 0xF0 S_dwlT16                    ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.S_dwlT17                                  = GetUInt64(new IntPtr(p + 0x0F8)); // 0xF8 S_dwlT17                    ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.S_dwlT18                                  = GetUInt64(new IntPtr(p + 0x100)); // 0x100 S_dwlT18                    ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.S_dwlT19                                  = GetUInt64(new IntPtr(p + 0x108)); // 0x108 S_dwlT19                    ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Null                                      = (SqlDecimal)GetInt32(new IntPtr(p + 0x110)); // 0x110 Null                        ( ModelEnumType SqlDecimal SqlDecimal SqlDecimal Int32 )
            value.MinValue                                  = (SqlDecimal)GetInt32(new IntPtr(p + 0x124)); // 0x124 MinValue                    ( ModelEnumType SqlDecimal SqlDecimal SqlDecimal Int32 )
            value.MaxValue                                  = (SqlDecimal)GetInt32(new IntPtr(p + 0x138)); // 0x138 MaxValue                    ( ModelEnumType SqlDecimal SqlDecimal SqlDecimal Int32 )

            return value;
        }
    }
}
