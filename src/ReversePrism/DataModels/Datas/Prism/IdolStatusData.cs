using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rarity                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Cost                                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 MaxHp                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C Vocal                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 Dance                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 Visual                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 Mental                                   0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class IdolStatusData : DataModel
    {
        public int                                      Rarity                                  { get; set; }
        public int                                      Cost                                    { get; set; }
        public int                                      MaxHp                                   { get; set; }
        public int                                      Vocal                                   { get; set; }
        public int                                      Dance                                   { get; set; }
        public int                                      Visual                                  { get; set; }
        public int                                      Mental                                  { get; set; }

        public static IdolStatusData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolStatusData() { Pointer= p0 };

            value.Rarity                                    = GetInt32(new IntPtr(p + 0x010)); // 024660BF3218 0x10 Rarity                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Cost                                      = GetInt32(new IntPtr(p + 0x014)); // 024660BF3238 0x14 Cost                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxHp                                     = GetInt32(new IntPtr(p + 0x018)); // 024660BF3258 0x18 MaxHp                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Vocal                                     = GetInt32(new IntPtr(p + 0x01C)); // 024660BF3278 0x1C Vocal                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Dance                                     = GetInt32(new IntPtr(p + 0x020)); // 024660BF3298 0x20 Dance                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Visual                                    = GetInt32(new IntPtr(p + 0x024)); // 024660BF32B8 0x24 Visual                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Mental                                    = GetInt32(new IntPtr(p + 0x028)); // 024660BF32D8 0x28 Mental                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
