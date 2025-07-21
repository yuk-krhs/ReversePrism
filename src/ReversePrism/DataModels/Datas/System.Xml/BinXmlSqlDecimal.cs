using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_bLen                                   ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 M_bPrec                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 M_bScale                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 M_bSign                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 M_data1                                  ModelPrimitiveType uint uint uint UInt32
    // 018 M_data2                                  ModelPrimitiveType uint uint uint UInt32
    // 01C M_data3                                  ModelPrimitiveType uint uint uint UInt32
    // 020 M_data4                                  ModelPrimitiveType uint uint uint UInt32
    // 000 NUMERIC_MAX_PRECISION                    sbyte IL2CPP_TYPE_U1
    // 001 MaxPrecision                             sbyte IL2CPP_TYPE_U1
    // 002 MaxScale                                 sbyte IL2CPP_TYPE_U1
    // 004 x_cNumeMax                               int IL2CPP_TYPE_I4
    // 008 x_lInt32Base                             long IL2CPP_TYPE_I8
    // 010 X_ulInt32Base                            ModelPrimitiveType ulong ulong ulong UInt64
    // 018 X_ulInt32BaseForMod                      ModelPrimitiveType ulong ulong ulong UInt64
    // 020 X_llMax                                  ModelPrimitiveType ulong ulong ulong UInt64
    // 028 DUINT_BASE                               ModelPrimitiveType double double double Double
    // 030 DUINT_BASE2                              ModelPrimitiveType double double double Double
    // 038 DUINT_BASE3                              ModelPrimitiveType double double double Double
    // 040 X_rgulShiftBase                          ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 048 RgCLenFromPrec                           ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class BinXmlSqlDecimal : DataModel
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
            var value   = new BinXmlSqlDecimal() { Pointer= p0 };

            value.M_bLen                                    = GetSByte(new IntPtr(p + 0x010)); // 0x10 M_bLen                      ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_bPrec                                   = GetSByte(new IntPtr(p + 0x011)); // 0x11 M_bPrec                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_bScale                                  = GetSByte(new IntPtr(p + 0x012)); // 0x12 M_bScale                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_bSign                                   = GetSByte(new IntPtr(p + 0x013)); // 0x13 M_bSign                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_data1                                   = GetUInt32(new IntPtr(p + 0x014)); // 0x14 M_data1                     ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_data2                                   = GetUInt32(new IntPtr(p + 0x018)); // 0x18 M_data2                     ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_data3                                   = GetUInt32(new IntPtr(p + 0x01C)); // 0x1C M_data3                     ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_data4                                   = GetUInt32(new IntPtr(p + 0x020)); // 0x20 M_data4                     ( ModelPrimitiveType uint uint uint UInt32 )
            value.X_ulInt32Base                             = GetUInt64(new IntPtr(p + 0x010)); // 0x10 X_ulInt32Base               ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.X_ulInt32BaseForMod                       = GetUInt64(new IntPtr(p + 0x018)); // 0x18 X_ulInt32BaseForMod         ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.X_llMax                                   = GetUInt64(new IntPtr(p + 0x020)); // 0x20 X_llMax                     ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.DUINT_BASE                                = GetDouble(new IntPtr(p + 0x028)); // 0x28 DUINT_BASE                  ( ModelPrimitiveType double double double Double )
            value.DUINT_BASE2                               = GetDouble(new IntPtr(p + 0x030)); // 0x30 DUINT_BASE2                 ( ModelPrimitiveType double double double Double )
            value.DUINT_BASE3                               = GetDouble(new IntPtr(p + 0x038)); // 0x38 DUINT_BASE3                 ( ModelPrimitiveType double double double Double )
            value.X_rgulShiftBase                           = GetUInt32List(new IntPtr(p + 0x040)); // 0x40 X_rgulShiftBase             ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.RgCLenFromPrec                            = GetSByteList(new IntPtr(p + 0x048)); // 0x48 RgCLenFromPrec              ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
