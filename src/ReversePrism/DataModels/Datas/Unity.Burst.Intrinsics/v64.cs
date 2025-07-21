using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Byte0                                    ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 Byte1                                    ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 Byte2                                    ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 Byte3                                    ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 Byte4                                    ModelPrimitiveType sbyte sbyte sbyte SByte
    // 015 Byte5                                    ModelPrimitiveType sbyte sbyte sbyte SByte
    // 016 Byte6                                    ModelPrimitiveType sbyte sbyte sbyte SByte
    // 017 Byte7                                    ModelPrimitiveType sbyte sbyte sbyte SByte
    // 010 SByte0                                   ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 SByte1                                   ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 SByte2                                   ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 SByte3                                   ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 SByte4                                   ModelPrimitiveType sbyte sbyte sbyte SByte
    // 015 SByte5                                   ModelPrimitiveType sbyte sbyte sbyte SByte
    // 016 SByte6                                   ModelPrimitiveType sbyte sbyte sbyte SByte
    // 017 SByte7                                   ModelPrimitiveType sbyte sbyte sbyte SByte
    // 010 UShort0                                  ModelPrimitiveType ushort ushort ushort UInt16
    // 012 UShort1                                  ModelPrimitiveType ushort ushort ushort UInt16
    // 014 UShort2                                  ModelPrimitiveType ushort ushort ushort UInt16
    // 016 UShort3                                  ModelPrimitiveType ushort ushort ushort UInt16
    // 010 SShort0                                  ModelPrimitiveType short short short Int16
    // 012 SShort1                                  ModelPrimitiveType short short short Int16
    // 014 SShort2                                  ModelPrimitiveType short short short Int16
    // 016 SShort3                                  ModelPrimitiveType short short short Int16
    // 010 UInt0                                    ModelPrimitiveType uint uint uint UInt32
    // 014 UInt1                                    ModelPrimitiveType uint uint uint UInt32
    // 010 SInt0                                    ModelPrimitiveType int int int Int32
    // 014 SInt1                                    ModelPrimitiveType int int int Int32
    // 010 ULong0                                   ModelPrimitiveType ulong ulong ulong UInt64
    // 010 SLong0                                   ModelPrimitiveType long long long Int64
    // 010 Float0                                   ModelPrimitiveType float float float Single
    // 014 Float1                                   ModelPrimitiveType float float float Single
    // 010 Double0                                  ModelPrimitiveType double double double Double
    public partial class v64 : DataModel
    {
        public sbyte                                    Byte0                                   { get; set; }
        public sbyte                                    Byte1                                   { get; set; }
        public sbyte                                    Byte2                                   { get; set; }
        public sbyte                                    Byte3                                   { get; set; }
        public sbyte                                    Byte4                                   { get; set; }
        public sbyte                                    Byte5                                   { get; set; }
        public sbyte                                    Byte6                                   { get; set; }
        public sbyte                                    Byte7                                   { get; set; }
        public sbyte                                    SByte0                                  { get; set; }
        public sbyte                                    SByte1                                  { get; set; }
        public sbyte                                    SByte2                                  { get; set; }
        public sbyte                                    SByte3                                  { get; set; }
        public sbyte                                    SByte4                                  { get; set; }
        public sbyte                                    SByte5                                  { get; set; }
        public sbyte                                    SByte6                                  { get; set; }
        public sbyte                                    SByte7                                  { get; set; }
        public ushort                                   UShort0                                 { get; set; }
        public ushort                                   UShort1                                 { get; set; }
        public ushort                                   UShort2                                 { get; set; }
        public ushort                                   UShort3                                 { get; set; }
        public short                                    SShort0                                 { get; set; }
        public short                                    SShort1                                 { get; set; }
        public short                                    SShort2                                 { get; set; }
        public short                                    SShort3                                 { get; set; }
        public uint                                     UInt0                                   { get; set; }
        public uint                                     UInt1                                   { get; set; }
        public int                                      SInt0                                   { get; set; }
        public int                                      SInt1                                   { get; set; }
        public ulong                                    ULong0                                  { get; set; }
        public long                                     SLong0                                  { get; set; }
        public float                                    Float0                                  { get; set; }
        public float                                    Float1                                  { get; set; }
        public double                                   Double0                                 { get; set; }

        public static v64? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new v64() { Pointer= p0 };

            value.Byte0                                     = GetSByte(new IntPtr(p + 0x010)); // 0x10 Byte0                       ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte1                                     = GetSByte(new IntPtr(p + 0x011)); // 0x11 Byte1                       ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte2                                     = GetSByte(new IntPtr(p + 0x012)); // 0x12 Byte2                       ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte3                                     = GetSByte(new IntPtr(p + 0x013)); // 0x13 Byte3                       ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte4                                     = GetSByte(new IntPtr(p + 0x014)); // 0x14 Byte4                       ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte5                                     = GetSByte(new IntPtr(p + 0x015)); // 0x15 Byte5                       ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte6                                     = GetSByte(new IntPtr(p + 0x016)); // 0x16 Byte6                       ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte7                                     = GetSByte(new IntPtr(p + 0x017)); // 0x17 Byte7                       ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte0                                    = GetSByte(new IntPtr(p + 0x010)); // 0x10 SByte0                      ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte1                                    = GetSByte(new IntPtr(p + 0x011)); // 0x11 SByte1                      ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte2                                    = GetSByte(new IntPtr(p + 0x012)); // 0x12 SByte2                      ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte3                                    = GetSByte(new IntPtr(p + 0x013)); // 0x13 SByte3                      ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte4                                    = GetSByte(new IntPtr(p + 0x014)); // 0x14 SByte4                      ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte5                                    = GetSByte(new IntPtr(p + 0x015)); // 0x15 SByte5                      ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte6                                    = GetSByte(new IntPtr(p + 0x016)); // 0x16 SByte6                      ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.SByte7                                    = GetSByte(new IntPtr(p + 0x017)); // 0x17 SByte7                      ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.UShort0                                   = GetUInt16(new IntPtr(p + 0x010)); // 0x10 UShort0                     ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UShort1                                   = GetUInt16(new IntPtr(p + 0x012)); // 0x12 UShort1                     ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UShort2                                   = GetUInt16(new IntPtr(p + 0x014)); // 0x14 UShort2                     ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UShort3                                   = GetUInt16(new IntPtr(p + 0x016)); // 0x16 UShort3                     ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.SShort0                                   = GetInt16(new IntPtr(p + 0x010)); // 0x10 SShort0                     ( ModelPrimitiveType short short short Int16 )
            value.SShort1                                   = GetInt16(new IntPtr(p + 0x012)); // 0x12 SShort1                     ( ModelPrimitiveType short short short Int16 )
            value.SShort2                                   = GetInt16(new IntPtr(p + 0x014)); // 0x14 SShort2                     ( ModelPrimitiveType short short short Int16 )
            value.SShort3                                   = GetInt16(new IntPtr(p + 0x016)); // 0x16 SShort3                     ( ModelPrimitiveType short short short Int16 )
            value.UInt0                                     = GetUInt32(new IntPtr(p + 0x010)); // 0x10 UInt0                       ( ModelPrimitiveType uint uint uint UInt32 )
            value.UInt1                                     = GetUInt32(new IntPtr(p + 0x014)); // 0x14 UInt1                       ( ModelPrimitiveType uint uint uint UInt32 )
            value.SInt0                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 SInt0                       ( ModelPrimitiveType int int int Int32 )
            value.SInt1                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 SInt1                       ( ModelPrimitiveType int int int Int32 )
            value.ULong0                                    = GetUInt64(new IntPtr(p + 0x010)); // 0x10 ULong0                      ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.SLong0                                    = GetInt64(new IntPtr(p + 0x010)); // 0x10 SLong0                      ( ModelPrimitiveType long long long Int64 )
            value.Float0                                    = GetSingle(new IntPtr(p + 0x010)); // 0x10 Float0                      ( ModelPrimitiveType float float float Single )
            value.Float1                                    = GetSingle(new IntPtr(p + 0x014)); // 0x14 Float1                      ( ModelPrimitiveType float float float Single )
            value.Double0                                   = GetDouble(new IntPtr(p + 0x010)); // 0x10 Double0                     ( ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
