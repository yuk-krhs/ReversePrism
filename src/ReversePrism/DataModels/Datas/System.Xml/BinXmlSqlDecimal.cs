using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_bLen                                   00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 M_bPrec                                  00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 M_bScale                                 00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 M_bSign                                  00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 M_data1                                  000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 018 M_data2                                  000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 01C M_data3                                  000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 020 M_data4                                  000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 000 NUMERIC_MAX_PRECISION                    sbyte IL2CPP_TYPE_U1
    // 001 MaxPrecision                             sbyte IL2CPP_TYPE_U1
    // 002 MaxScale                                 sbyte IL2CPP_TYPE_U1
    // 004 x_cNumeMax                               int IL2CPP_TYPE_I4
    // 008 x_lInt32Base                             long IL2CPP_TYPE_I8
    // 010 X_ulInt32Base                            00018669C990 ModelPrimitiveType ulong ulong ulong UInt64
    // 018 X_ulInt32BaseForMod                      00018669C990 ModelPrimitiveType ulong ulong ulong UInt64
    // 020 X_llMax                                  00018669CC60 ModelPrimitiveType ulong ulong ulong UInt64
    // 028 DUINT_BASE                               0001865C3A90 ModelPrimitiveType double double double Double
    // 030 DUINT_BASE2                              0001865C3A90 ModelPrimitiveType double double double Double
    // 038 DUINT_BASE3                              0001865C3A90 ModelPrimitiveType double double double Double
    // 040 X_rgulShiftBase                          000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 048 RgCLenFromPrec                           000185B7A290 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class BinXmlSqlDecimal
    {
        public sbyte                                    M_bLen                                  { get; set; }
        public sbyte                                    M_bPrec                                 { get; set; }
        public sbyte                                    M_bScale                                { get; set; }
        public sbyte                                    M_bSign                                 { get; set; }
        public uint                                     M_data1                                 { get; set; }
        public uint                                     M_data2                                 { get; set; }
        public uint                                     M_data3                                 { get; set; }
        public uint                                     M_data4                                 { get; set; }
        public ulong                                    X_ulInt32Base                           { get; set; }
        public ulong                                    X_ulInt32BaseForMod                     { get; set; }
        public ulong                                    X_llMax                                 { get; set; }
        public double                                   DUINT_BASE                              { get; set; }
        public double                                   DUINT_BASE2                             { get; set; }
        public double                                   DUINT_BASE3                             { get; set; }
        public List<uint>?                              X_rgulShiftBase                         { get; set; }
        public List<sbyte>?                             RgCLenFromPrec                          { get; set; }

        public static BinXmlSqlDecimal? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BinXmlSqlDecimal();

            value.M_bLen                                    = GetSByte(new IntPtr(p + 0x010)); // 0270D734B220 0x10 M_bLen                      ( 00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_bPrec                                   = GetSByte(new IntPtr(p + 0x011)); // 0270D734B240 0x11 M_bPrec                     ( 00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_bScale                                  = GetSByte(new IntPtr(p + 0x012)); // 0270D734B260 0x12 M_bScale                    ( 00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_bSign                                   = GetSByte(new IntPtr(p + 0x013)); // 0270D734B280 0x13 M_bSign                     ( 00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_data1                                   = GetUInt32(new IntPtr(p + 0x014)); // 0270D734B2A0 0x14 M_data1                     ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.M_data2                                   = GetUInt32(new IntPtr(p + 0x018)); // 0270D734B2C0 0x18 M_data2                     ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.M_data3                                   = GetUInt32(new IntPtr(p + 0x01C)); // 0270D734B2E0 0x1C M_data3                     ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.M_data4                                   = GetUInt32(new IntPtr(p + 0x020)); // 0270D734B300 0x20 M_data4                     ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.X_ulInt32Base                             = GetUInt64(new IntPtr(p + 0x010)); // 0270D734B3C0 0x10 X_ulInt32Base               ( 00018669C990 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.X_ulInt32BaseForMod                       = GetUInt64(new IntPtr(p + 0x018)); // 0270D734B3E0 0x18 X_ulInt32BaseForMod         ( 00018669C990 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.X_llMax                                   = GetUInt64(new IntPtr(p + 0x020)); // 0270D734B400 0x20 X_llMax                     ( 00018669CC60 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.DUINT_BASE                                = GetDouble(new IntPtr(p + 0x028)); // 0270D734B420 0x28 DUINT_BASE                  ( 0001865C3A90 ModelPrimitiveType double double double Double )
            value.DUINT_BASE2                               = GetDouble(new IntPtr(p + 0x030)); // 0270D734B440 0x30 DUINT_BASE2                 ( 0001865C3A90 ModelPrimitiveType double double double Double )
            value.DUINT_BASE3                               = GetDouble(new IntPtr(p + 0x038)); // 0270D734B460 0x38 DUINT_BASE3                 ( 0001865C3A90 ModelPrimitiveType double double double Double )
            value.X_rgulShiftBase                           = GetUInt32List(new IntPtr(p + 0x040)); // 0270D734B480 0x40 X_rgulShiftBase             ( 000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.RgCLenFromPrec                            = GetSByteList(new IntPtr(p + 0x048)); // 0270D734B4A0 0x48 RgCLenFromPrec              ( 000185B7A290 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
