using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SkillType                                000186694580 ModelEnumType SkillType SkillType SkillType Int32
    // 014 CardId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class AiComboData
    {
        public SkillType                                SkillType                               { get; set; }
        public int                                      CardId                                  { get; set; }

        public static AiComboData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AiComboData();

            value.SkillType                                 = (SkillType)GetInt32(new IntPtr(p + 0x010)); // 0270D5A6E928 0x10 SkillType                   ( 000186694580 ModelEnumType SkillType SkillType SkillType Int32 )
            value.CardId                                    = GetInt32(new IntPtr(p + 0x014)); // 0270D5A6E948 0x14 CardId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
