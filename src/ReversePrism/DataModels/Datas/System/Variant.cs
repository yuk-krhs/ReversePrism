using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Vt                                       0001865F1520 ModelPrimitiveType short short short Int16
    // 012 WReserved1                               000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 014 WReserved2                               000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 016 WReserved3                               000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 018 LlVal                                    0001865F7E40 ModelPrimitiveType long long long Int64
    // 018 LVal                                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 BVal                                     00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 IVal                                     0001865F1520 ModelPrimitiveType short short short Int16
    // 018 FltVal                                   000186666050 ModelPrimitiveType float float float Single
    // 018 DblVal                                   0001865C2E50 ModelPrimitiveType double double double Double
    // 018 BoolVal                                  0001865F1520 ModelPrimitiveType short short short Int16
    // 018 bstrVal                                  <int> IL2CPP_TYPE_I
    // 018 CVal                                     00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 UiVal                                    000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 018 UlVal                                    0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 UllVal                                   00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64
    // 018 IntVal                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 UintVal                                  0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 pdispVal                                 <int> IL2CPP_TYPE_I
    // 018 BRecord                                  000186732E90 ModelEnumType BRECORD BRECORD BRECORD Int32
    public partial class Variant
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
            var value   = new Variant();

            value.Vt                                        = GetInt16(new IntPtr(p + 0x010)); // 0270D6AAFD50 0x10 Vt                          ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.WReserved1                                = GetUInt16(new IntPtr(p + 0x012)); // 0270D6AAFD70 0x12 WReserved1                  ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.WReserved2                                = GetUInt16(new IntPtr(p + 0x014)); // 0270D6AAFD90 0x14 WReserved2                  ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.WReserved3                                = GetUInt16(new IntPtr(p + 0x016)); // 0270D6AAFDB0 0x16 WReserved3                  ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.LlVal                                     = GetInt64(new IntPtr(p + 0x018)); // 0270D6AAFDD0 0x18 LlVal                       ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.LVal                                      = GetInt32(new IntPtr(p + 0x018)); // 0270D6AAFDF0 0x18 LVal                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.BVal                                      = GetSByte(new IntPtr(p + 0x018)); // 0270D6AAFE10 0x18 BVal                        ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.IVal                                      = GetInt16(new IntPtr(p + 0x018)); // 0270D6AAFE30 0x18 IVal                        ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.FltVal                                    = GetSingle(new IntPtr(p + 0x018)); // 0270D6AAFE50 0x18 FltVal                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.DblVal                                    = GetDouble(new IntPtr(p + 0x018)); // 0270D6AAFE70 0x18 DblVal                      ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.BoolVal                                   = GetInt16(new IntPtr(p + 0x018)); // 0270D6AAFE90 0x18 BoolVal                     ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.CVal                                      = GetSByte(new IntPtr(p + 0x018)); // 0270D6AAFED0 0x18 CVal                        ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.UiVal                                     = GetUInt16(new IntPtr(p + 0x018)); // 0270D6AAFEF0 0x18 UiVal                       ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UlVal                                     = GetUInt32(new IntPtr(p + 0x018)); // 0270D6AAFF10 0x18 UlVal                       ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.UllVal                                    = GetUInt64(new IntPtr(p + 0x018)); // 0270D6AAFF30 0x18 UllVal                      ( 00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.IntVal                                    = GetInt32(new IntPtr(p + 0x018)); // 0270D6AAFF50 0x18 IntVal                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.UintVal                                   = GetUInt32(new IntPtr(p + 0x018)); // 0270D6AAFF70 0x18 UintVal                     ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.BRecord                                   = (BRECORD)GetInt32(new IntPtr(p + 0x018)); // 0270D6AAFFB0 0x18 BRecord                     ( 000186732E90 ModelEnumType BRECORD BRECORD BRECORD Int32 )

            return value;
        }
    }
}
