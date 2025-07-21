using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Vt                                       ModelPrimitiveType short short short Int16
    // 012 WReserved1                               ModelPrimitiveType ushort ushort ushort UInt16
    // 014 WReserved2                               ModelPrimitiveType ushort ushort ushort UInt16
    // 016 WReserved3                               ModelPrimitiveType ushort ushort ushort UInt16
    // 018 LlVal                                    ModelPrimitiveType long long long Int64
    // 018 LVal                                     ModelPrimitiveType int int int Int32
    // 018 BVal                                     ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 IVal                                     ModelPrimitiveType short short short Int16
    // 018 FltVal                                   ModelPrimitiveType float float float Single
    // 018 DblVal                                   ModelPrimitiveType double double double Double
    // 018 BoolVal                                  ModelPrimitiveType short short short Int16
    // 018 bstrVal                                  <int> IL2CPP_TYPE_I
    // 018 CVal                                     ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 UiVal                                    ModelPrimitiveType ushort ushort ushort UInt16
    // 018 UlVal                                    ModelPrimitiveType uint uint uint UInt32
    // 018 UllVal                                   ModelPrimitiveType ulong ulong ulong UInt64
    // 018 IntVal                                   ModelPrimitiveType int int int Int32
    // 018 UintVal                                  ModelPrimitiveType uint uint uint UInt32
    // 018 pdispVal                                 <int> IL2CPP_TYPE_I
    // 018 BRecord                                  ModelEnumType BRECORD BRECORD BRECORD Int32
    public partial class Variant : DataModel
    {
        public short                                    Vt                                      { get; set; }
        public ushort                                   WReserved1                              { get; set; }
        public ushort                                   WReserved2                              { get; set; }
        public ushort                                   WReserved3                              { get; set; }
        public long                                     LlVal                                   { get; set; }
        public int                                      LVal                                    { get; set; }
        public sbyte                                    BVal                                    { get; set; }
        public short                                    IVal                                    { get; set; }
        public float                                    FltVal                                  { get; set; }
        public double                                   DblVal                                  { get; set; }
        public short                                    BoolVal                                 { get; set; }
        public sbyte                                    CVal                                    { get; set; }
        public ushort                                   UiVal                                   { get; set; }
        public uint                                     UlVal                                   { get; set; }
        public ulong                                    UllVal                                  { get; set; }
        public int                                      IntVal                                  { get; set; }
        public uint                                     UintVal                                 { get; set; }
        public BRECORD                                  BRecord                                 { get; set; }

        public static Variant? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Variant() { Pointer= p0 };

            value.Vt                                        = GetInt16(new IntPtr(p + 0x010)); // 0x10 Vt                          ( ModelPrimitiveType short short short Int16 )
            value.WReserved1                                = GetUInt16(new IntPtr(p + 0x012)); // 0x12 WReserved1                  ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.WReserved2                                = GetUInt16(new IntPtr(p + 0x014)); // 0x14 WReserved2                  ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.WReserved3                                = GetUInt16(new IntPtr(p + 0x016)); // 0x16 WReserved3                  ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.LlVal                                     = GetInt64(new IntPtr(p + 0x018)); // 0x18 LlVal                       ( ModelPrimitiveType long long long Int64 )
            value.LVal                                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 LVal                        ( ModelPrimitiveType int int int Int32 )
            value.BVal                                      = GetSByte(new IntPtr(p + 0x018)); // 0x18 BVal                        ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.IVal                                      = GetInt16(new IntPtr(p + 0x018)); // 0x18 IVal                        ( ModelPrimitiveType short short short Int16 )
            value.FltVal                                    = GetSingle(new IntPtr(p + 0x018)); // 0x18 FltVal                      ( ModelPrimitiveType float float float Single )
            value.DblVal                                    = GetDouble(new IntPtr(p + 0x018)); // 0x18 DblVal                      ( ModelPrimitiveType double double double Double )
            value.BoolVal                                   = GetInt16(new IntPtr(p + 0x018)); // 0x18 BoolVal                     ( ModelPrimitiveType short short short Int16 )
            value.CVal                                      = GetSByte(new IntPtr(p + 0x018)); // 0x18 CVal                        ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.UiVal                                     = GetUInt16(new IntPtr(p + 0x018)); // 0x18 UiVal                       ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UlVal                                     = GetUInt32(new IntPtr(p + 0x018)); // 0x18 UlVal                       ( ModelPrimitiveType uint uint uint UInt32 )
            value.UllVal                                    = GetUInt64(new IntPtr(p + 0x018)); // 0x18 UllVal                      ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.IntVal                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 IntVal                      ( ModelPrimitiveType int int int Int32 )
            value.UintVal                                   = GetUInt32(new IntPtr(p + 0x018)); // 0x18 UintVal                     ( ModelPrimitiveType uint uint uint UInt32 )
            value.BRecord                                   = (BRECORD)GetInt32(new IntPtr(p + 0x018)); // 0x18 BRecord                     ( ModelEnumType BRECORD BRECORD BRECORD Int32 )

            return value;
        }
    }
}
