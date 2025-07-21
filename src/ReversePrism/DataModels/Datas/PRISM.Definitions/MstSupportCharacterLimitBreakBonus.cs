using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rarity                                   ModelPrimitiveType int int int Int32
    // 014 Diamond                                  ModelPrimitiveType int int int Int32
    // 018 SkillSlot                                ModelPrimitiveType int int int Int32
    // 01C LimitLv                                  ModelPrimitiveType int int int Int32
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

            value.Rarity                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 Rarity                      ( ModelPrimitiveType int int int Int32 )
            value.Diamond                                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 Diamond                     ( ModelPrimitiveType int int int Int32 )
            value.SkillSlot                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 SkillSlot                   ( ModelPrimitiveType int int int Int32 )
            value.LimitLv                                   = GetInt32(new IntPtr(p + 0x01C)); // 0x1C LimitLv                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
