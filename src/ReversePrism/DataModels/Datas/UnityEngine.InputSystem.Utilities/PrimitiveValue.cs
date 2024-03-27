using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Type                                   000186694BC0 ModelEnumType TypeCode TypeCode TypeCode Int32
    // 014 M_BoolValue                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 m_CharValue                              char IL2CPP_TYPE_CHAR
    // 014 M_ByteValue                              00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 M_SByteValue                             00018665D2C0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 M_ShortValue                             0001865F1060 ModelPrimitiveType short short short Int16
    // 014 M_UShortValue                            000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16
    // 014 M_IntValue                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 M_UIntValue                              000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 014 M_LongValue                              0001865F7700 ModelPrimitiveType long long long Int64
    // 014 M_ULongValue                             00018669B890 ModelPrimitiveType ulong ulong ulong UInt64
    // 014 M_FloatValue                             0001866656B0 ModelPrimitiveType float float float Single
    // 014 M_DoubleValue                            0001865C2950 ModelPrimitiveType double double double Double
    public partial class PrimitiveValue
    {
        public TypeCode                                 M_Type                                  { get; set; }
        public bool                                     M_BoolValue                             { get; set; }
        public sbyte                                    M_ByteValue                             { get; set; }
        public sbyte                                    M_SByteValue                            { get; set; }
        public short                                    M_ShortValue                            { get; set; }
        public ushort                                   M_UShortValue                           { get; set; }
        public int                                      M_IntValue                              { get; set; }
        public uint                                     M_UIntValue                             { get; set; }
        public long                                     M_LongValue                             { get; set; }
        public ulong                                    M_ULongValue                            { get; set; }
        public float                                    M_FloatValue                            { get; set; }
        public double                                   M_DoubleValue                           { get; set; }

        public static PrimitiveValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrimitiveValue();

            value.M_Type                                    = (TypeCode)GetInt32(new IntPtr(p + 0x010)); // 027002E35F98 0x10 M_Type                      ( 000186694BC0 ModelEnumType TypeCode TypeCode TypeCode Int32 )
            value.M_BoolValue                               = GetBool(new IntPtr(p + 0x014)); // 027002E35FB8 0x14 M_BoolValue                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ByteValue                               = GetSByte(new IntPtr(p + 0x014)); // 027002E35FF8 0x14 M_ByteValue                 ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_SByteValue                              = GetSByte(new IntPtr(p + 0x014)); // 027002E36018 0x14 M_SByteValue                ( 00018665D2C0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_ShortValue                              = GetInt16(new IntPtr(p + 0x014)); // 027002E36038 0x14 M_ShortValue                ( 0001865F1060 ModelPrimitiveType short short short Int16 )
            value.M_UShortValue                             = GetUInt16(new IntPtr(p + 0x014)); // 027002E36058 0x14 M_UShortValue               ( 000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.M_IntValue                                = GetInt32(new IntPtr(p + 0x014)); // 027002E36078 0x14 M_IntValue                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_UIntValue                               = GetUInt32(new IntPtr(p + 0x014)); // 027002E36098 0x14 M_UIntValue                 ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.M_LongValue                               = GetInt64(new IntPtr(p + 0x014)); // 027002E360B8 0x14 M_LongValue                 ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.M_ULongValue                              = GetUInt64(new IntPtr(p + 0x014)); // 027002E360D8 0x14 M_ULongValue                ( 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.M_FloatValue                              = GetSingle(new IntPtr(p + 0x014)); // 027002E360F8 0x14 M_FloatValue                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_DoubleValue                             = GetDouble(new IntPtr(p + 0x014)); // 027002E36118 0x14 M_DoubleValue               ( 0001865C2950 ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
