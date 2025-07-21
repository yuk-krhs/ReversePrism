using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Type                                   ModelEnumType TypeCode TypeCode TypeCode Int32
    // 014 M_BoolValue                              ModelPrimitiveType bool bool bool Bool
    // 014 m_CharValue                              char IL2CPP_TYPE_CHAR
    // 014 M_ByteValue                              ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 M_SByteValue                             ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 M_ShortValue                             ModelPrimitiveType short short short Int16
    // 014 M_UShortValue                            ModelPrimitiveType ushort ushort ushort UInt16
    // 014 M_IntValue                               ModelPrimitiveType int int int Int32
    // 014 M_UIntValue                              ModelPrimitiveType uint uint uint UInt32
    // 014 M_LongValue                              ModelPrimitiveType long long long Int64
    // 014 M_ULongValue                             ModelPrimitiveType ulong ulong ulong UInt64
    // 014 M_FloatValue                             ModelPrimitiveType float float float Single
    // 014 M_DoubleValue                            ModelPrimitiveType double double double Double
    public partial class PrimitiveValue : DataModel
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
            var value   = new PrimitiveValue() { Pointer= p0 };

            value.M_Type                                    = (TypeCode)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Type                      ( ModelEnumType TypeCode TypeCode TypeCode Int32 )
            value.M_BoolValue                               = GetBool(new IntPtr(p + 0x014)); // 0x14 M_BoolValue                 ( ModelPrimitiveType bool bool bool Bool )
            value.M_ByteValue                               = GetSByte(new IntPtr(p + 0x014)); // 0x14 M_ByteValue                 ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_SByteValue                              = GetSByte(new IntPtr(p + 0x014)); // 0x14 M_SByteValue                ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_ShortValue                              = GetInt16(new IntPtr(p + 0x014)); // 0x14 M_ShortValue                ( ModelPrimitiveType short short short Int16 )
            value.M_UShortValue                             = GetUInt16(new IntPtr(p + 0x014)); // 0x14 M_UShortValue               ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.M_IntValue                                = GetInt32(new IntPtr(p + 0x014)); // 0x14 M_IntValue                  ( ModelPrimitiveType int int int Int32 )
            value.M_UIntValue                               = GetUInt32(new IntPtr(p + 0x014)); // 0x14 M_UIntValue                 ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_LongValue                               = GetInt64(new IntPtr(p + 0x014)); // 0x14 M_LongValue                 ( ModelPrimitiveType long long long Int64 )
            value.M_ULongValue                              = GetUInt64(new IntPtr(p + 0x014)); // 0x14 M_ULongValue                ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.M_FloatValue                              = GetSingle(new IntPtr(p + 0x014)); // 0x14 M_FloatValue                ( ModelPrimitiveType float float float Single )
            value.M_DoubleValue                             = GetDouble(new IntPtr(p + 0x014)); // 0x14 M_DoubleValue               ( ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
