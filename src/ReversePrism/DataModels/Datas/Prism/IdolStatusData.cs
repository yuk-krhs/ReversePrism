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
    public partial class IdolStatusData
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
            var value   = new IdolStatusData();

            value.Rarity                                    = GetInt32(new IntPtr(p + 0x010)); // 027003B28150 0x10 Rarity                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Cost                                      = GetInt32(new IntPtr(p + 0x014)); // 027003B28170 0x14 Cost                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxHp                                     = GetInt32(new IntPtr(p + 0x018)); // 027003B28190 0x18 MaxHp                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Vocal                                     = GetInt32(new IntPtr(p + 0x01C)); // 027003B281B0 0x1C Vocal                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Dance                                     = GetInt32(new IntPtr(p + 0x020)); // 027003B281D0 0x20 Dance                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Visual                                    = GetInt32(new IntPtr(p + 0x024)); // 027003B281F0 0x24 Visual                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Mental                                    = GetInt32(new IntPtr(p + 0x028)); // 027003B28210 0x28 Mental                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
