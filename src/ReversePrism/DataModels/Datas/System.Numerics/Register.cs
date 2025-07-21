using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Byte_0                                   ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 Byte_1                                   ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 Byte_2                                   ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 Byte_3                                   ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 Byte_4                                   ModelPrimitiveType sbyte sbyte sbyte SByte
    // 015 Byte_5                                   ModelPrimitiveType sbyte sbyte sbyte SByte
    // 016 Byte_6                                   ModelPrimitiveType sbyte sbyte sbyte SByte
    // 017 Byte_7                                   ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 Byte_8                                   ModelPrimitiveType sbyte sbyte sbyte SByte
    // 019 Byte_9                                   ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01A Byte_10                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01B Byte_11                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01C Byte_12                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01D Byte_13                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01E Byte_14                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01F Byte_15                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 010 Sbyte_0                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 Sbyte_1                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 Sbyte_2                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 Sbyte_3                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 Sbyte_4                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 015 Sbyte_5                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 016 Sbyte_6                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 017 Sbyte_7                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 Sbyte_8                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 019 Sbyte_9                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01A Sbyte_10                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01B Sbyte_11                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01C Sbyte_12                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01D Sbyte_13                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01E Sbyte_14                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01F Sbyte_15                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 010 Uint16_0                                 ModelPrimitiveType ushort ushort ushort UInt16
    // 012 Uint16_1                                 ModelPrimitiveType ushort ushort ushort UInt16
    // 014 Uint16_2                                 ModelPrimitiveType ushort ushort ushort UInt16
    // 016 Uint16_3                                 ModelPrimitiveType ushort ushort ushort UInt16
    // 018 Uint16_4                                 ModelPrimitiveType ushort ushort ushort UInt16
    // 01A Uint16_5                                 ModelPrimitiveType ushort ushort ushort UInt16
    // 01C Uint16_6                                 ModelPrimitiveType ushort ushort ushort UInt16
    // 01E Uint16_7                                 ModelPrimitiveType ushort ushort ushort UInt16
    // 010 Int16_0                                  ModelPrimitiveType short short short Int16
    // 012 Int16_1                                  ModelPrimitiveType short short short Int16
    // 014 Int16_2                                  ModelPrimitiveType short short short Int16
    // 016 Int16_3                                  ModelPrimitiveType short short short Int16
    // 018 Int16_4                                  ModelPrimitiveType short short short Int16
    // 01A Int16_5                                  ModelPrimitiveType short short short Int16
    // 01C Int16_6                                  ModelPrimitiveType short short short Int16
    // 01E Int16_7                                  ModelPrimitiveType short short short Int16
    // 010 Uint32_0                                 ModelPrimitiveType uint uint uint UInt32
    // 014 Uint32_1                                 ModelPrimitiveType uint uint uint UInt32
    // 018 Uint32_2                                 ModelPrimitiveType uint uint uint UInt32
    // 01C Uint32_3                                 ModelPrimitiveType uint uint uint UInt32
    // 010 Int32_0                                  ModelPrimitiveType int int int Int32
    // 014 Int32_1                                  ModelPrimitiveType int int int Int32
    // 018 Int32_2                                  ModelPrimitiveType int int int Int32
    // 01C Int32_3                                  ModelPrimitiveType int int int Int32
    // 010 Uint64_0                                 ModelPrimitiveType ulong ulong ulong UInt64
    // 018 Uint64_1                                 ModelPrimitiveType ulong ulong ulong UInt64
    // 010 Int64_0                                  ModelPrimitiveType long long long Int64
    // 018 Int64_1                                  ModelPrimitiveType long long long Int64
    // 010 Single_0                                 ModelPrimitiveType float float float Single
    // 014 Single_1                                 ModelPrimitiveType float float float Single
    // 018 Single_2                                 ModelPrimitiveType float float float Single
    // 01C Single_3                                 ModelPrimitiveType float float float Single
    // 010 Double_0                                 ModelPrimitiveType double double double Double
    // 018 Double_1                                 ModelPrimitiveType double double double Double
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

            value.Byte_0                                    = GetSByte(new IntPtr(p + 0x010)); // 0x10 Byte_0                      ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_1                                    = GetSByte(new IntPtr(p + 0x011)); // 0x11 Byte_1                      ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_2                                    = GetSByte(new IntPtr(p + 0x012)); // 0x12 Byte_2                      ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_3                                    = GetSByte(new IntPtr(p + 0x013)); // 0x13 Byte_3                      ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_4                                    = GetSByte(new IntPtr(p + 0x014)); // 0x14 Byte_4                      ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_5                                    = GetSByte(new IntPtr(p + 0x015)); // 0x15 Byte_5                      ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_6                                    = GetSByte(new IntPtr(p + 0x016)); // 0x16 Byte_6                      ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_7                                    = GetSByte(new IntPtr(p + 0x017)); // 0x17 Byte_7                      ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_8                                    = GetSByte(new IntPtr(p + 0x018)); // 0x18 Byte_8                      ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_9                                    = GetSByte(new IntPtr(p + 0x019)); // 0x19 Byte_9                      ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_10                                   = GetSByte(new IntPtr(p + 0x01A)); // 0x1A Byte_10                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_11                                   = GetSByte(new IntPtr(p + 0x01B)); // 0x1B Byte_11                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_12                                   = GetSByte(new IntPtr(p + 0x01C)); // 0x1C Byte_12                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_13                                   = GetSByte(new IntPtr(p + 0x01D)); // 0x1D Byte_13                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_14                                   = GetSByte(new IntPtr(p + 0x01E)); // 0x1E Byte_14                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte_15                                   = GetSByte(new IntPtr(p + 0x01F)); // 0x1F Byte_15                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_0                                   = GetSByte(new IntPtr(p + 0x010)); // 0x10 Sbyte_0                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_1                                   = GetSByte(new IntPtr(p + 0x011)); // 0x11 Sbyte_1                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_2                                   = GetSByte(new IntPtr(p + 0x012)); // 0x12 Sbyte_2                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_3                                   = GetSByte(new IntPtr(p + 0x013)); // 0x13 Sbyte_3                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_4                                   = GetSByte(new IntPtr(p + 0x014)); // 0x14 Sbyte_4                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_5                                   = GetSByte(new IntPtr(p + 0x015)); // 0x15 Sbyte_5                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_6                                   = GetSByte(new IntPtr(p + 0x016)); // 0x16 Sbyte_6                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_7                                   = GetSByte(new IntPtr(p + 0x017)); // 0x17 Sbyte_7                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_8                                   = GetSByte(new IntPtr(p + 0x018)); // 0x18 Sbyte_8                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_9                                   = GetSByte(new IntPtr(p + 0x019)); // 0x19 Sbyte_9                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_10                                  = GetSByte(new IntPtr(p + 0x01A)); // 0x1A Sbyte_10                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_11                                  = GetSByte(new IntPtr(p + 0x01B)); // 0x1B Sbyte_11                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_12                                  = GetSByte(new IntPtr(p + 0x01C)); // 0x1C Sbyte_12                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_13                                  = GetSByte(new IntPtr(p + 0x01D)); // 0x1D Sbyte_13                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_14                                  = GetSByte(new IntPtr(p + 0x01E)); // 0x1E Sbyte_14                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Sbyte_15                                  = GetSByte(new IntPtr(p + 0x01F)); // 0x1F Sbyte_15                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Uint16_0                                  = GetUInt16(new IntPtr(p + 0x010)); // 0x10 Uint16_0                    ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Uint16_1                                  = GetUInt16(new IntPtr(p + 0x012)); // 0x12 Uint16_1                    ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Uint16_2                                  = GetUInt16(new IntPtr(p + 0x014)); // 0x14 Uint16_2                    ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Uint16_3                                  = GetUInt16(new IntPtr(p + 0x016)); // 0x16 Uint16_3                    ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Uint16_4                                  = GetUInt16(new IntPtr(p + 0x018)); // 0x18 Uint16_4                    ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Uint16_5                                  = GetUInt16(new IntPtr(p + 0x01A)); // 0x1A Uint16_5                    ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Uint16_6                                  = GetUInt16(new IntPtr(p + 0x01C)); // 0x1C Uint16_6                    ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Uint16_7                                  = GetUInt16(new IntPtr(p + 0x01E)); // 0x1E Uint16_7                    ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Int16_0                                   = GetInt16(new IntPtr(p + 0x010)); // 0x10 Int16_0                     ( ModelPrimitiveType short short short Int16 )
            value.Int16_1                                   = GetInt16(new IntPtr(p + 0x012)); // 0x12 Int16_1                     ( ModelPrimitiveType short short short Int16 )
            value.Int16_2                                   = GetInt16(new IntPtr(p + 0x014)); // 0x14 Int16_2                     ( ModelPrimitiveType short short short Int16 )
            value.Int16_3                                   = GetInt16(new IntPtr(p + 0x016)); // 0x16 Int16_3                     ( ModelPrimitiveType short short short Int16 )
            value.Int16_4                                   = GetInt16(new IntPtr(p + 0x018)); // 0x18 Int16_4                     ( ModelPrimitiveType short short short Int16 )
            value.Int16_5                                   = GetInt16(new IntPtr(p + 0x01A)); // 0x1A Int16_5                     ( ModelPrimitiveType short short short Int16 )
            value.Int16_6                                   = GetInt16(new IntPtr(p + 0x01C)); // 0x1C Int16_6                     ( ModelPrimitiveType short short short Int16 )
            value.Int16_7                                   = GetInt16(new IntPtr(p + 0x01E)); // 0x1E Int16_7                     ( ModelPrimitiveType short short short Int16 )
            value.Uint32_0                                  = GetUInt32(new IntPtr(p + 0x010)); // 0x10 Uint32_0                    ( ModelPrimitiveType uint uint uint UInt32 )
            value.Uint32_1                                  = GetUInt32(new IntPtr(p + 0x014)); // 0x14 Uint32_1                    ( ModelPrimitiveType uint uint uint UInt32 )
            value.Uint32_2                                  = GetUInt32(new IntPtr(p + 0x018)); // 0x18 Uint32_2                    ( ModelPrimitiveType uint uint uint UInt32 )
            value.Uint32_3                                  = GetUInt32(new IntPtr(p + 0x01C)); // 0x1C Uint32_3                    ( ModelPrimitiveType uint uint uint UInt32 )
            value.Int32_0                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 Int32_0                     ( ModelPrimitiveType int int int Int32 )
            value.Int32_1                                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 Int32_1                     ( ModelPrimitiveType int int int Int32 )
            value.Int32_2                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 Int32_2                     ( ModelPrimitiveType int int int Int32 )
            value.Int32_3                                   = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Int32_3                     ( ModelPrimitiveType int int int Int32 )
            value.Uint64_0                                  = GetUInt64(new IntPtr(p + 0x010)); // 0x10 Uint64_0                    ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Uint64_1                                  = GetUInt64(new IntPtr(p + 0x018)); // 0x18 Uint64_1                    ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Int64_0                                   = GetInt64(new IntPtr(p + 0x010)); // 0x10 Int64_0                     ( ModelPrimitiveType long long long Int64 )
            value.Int64_1                                   = GetInt64(new IntPtr(p + 0x018)); // 0x18 Int64_1                     ( ModelPrimitiveType long long long Int64 )
            value.Single_0                                  = GetSingle(new IntPtr(p + 0x010)); // 0x10 Single_0                    ( ModelPrimitiveType float float float Single )
            value.Single_1                                  = GetSingle(new IntPtr(p + 0x014)); // 0x14 Single_1                    ( ModelPrimitiveType float float float Single )
            value.Single_2                                  = GetSingle(new IntPtr(p + 0x018)); // 0x18 Single_2                    ( ModelPrimitiveType float float float Single )
            value.Single_3                                  = GetSingle(new IntPtr(p + 0x01C)); // 0x1C Single_3                    ( ModelPrimitiveType float float float Single )
            value.Double_0                                  = GetDouble(new IntPtr(p + 0x010)); // 0x10 Double_0                    ( ModelPrimitiveType double double double Double )
            value.Double_1                                  = GetDouble(new IntPtr(p + 0x018)); // 0x18 Double_1                    ( ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
