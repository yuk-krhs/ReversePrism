using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rarity                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 014 Diamond                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 018 SkillSlot                                0001865F4260 ModelPrimitiveType int int int Int32
    // 01C LimitLv                                  0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstSupportCharacterLimitBreakBonus : DataModel
    {
        public int                                      Rarity                                  { get; set; }
        public int                                      Diamond                                 { get; set; }
        public int                                      SkillSlot                               { get; set; }
        public int                                      LimitLv                                 { get; set; }

        public static MstSupportCharacterLimitBreakBonus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstSupportCharacterLimitBreakBonus() { Pointer= p0 };

            value.Rarity                                    = GetInt32(new IntPtr(p + 0x010)); // 0245A46218E8 0x10 Rarity                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Diamond                                   = GetInt32(new IntPtr(p + 0x014)); // 0245A4621908 0x14 Diamond                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.SkillSlot                                 = GetInt32(new IntPtr(p + 0x018)); // 0245A4621928 0x18 SkillSlot                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.LimitLv                                   = GetInt32(new IntPtr(p + 0x01C)); // 0245A4621948 0x1C LimitLv                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
