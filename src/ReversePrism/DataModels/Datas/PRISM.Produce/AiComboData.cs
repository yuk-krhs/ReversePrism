using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SkillType                                ModelEnumType SkillType SkillType SkillType Int32
    // 014 CardId                                   ModelPrimitiveType int int int Int32
    public partial class AiComboData : DataModel
    {
        public SkillType                                SkillType                               { get; set; }
        public int                                      CardId                                  { get; set; }

        public static AiComboData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AiComboData() { Pointer= p0 };

            value.SkillType                                 = (SkillType)GetInt32(new IntPtr(p + 0x010)); // 0x10 SkillType                   ( ModelEnumType SkillType SkillType SkillType Int32 )
            value.CardId                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 CardId                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
