using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SkillType                                0001866947F0 ModelEnumType SkillType SkillType SkillType Int32
    // 014 SkillId                                  0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class EditorAiCombo
    {
        public SkillType                                SkillType                               { get; set; }
        public int                                      SkillId                                 { get; set; }

        public static EditorAiCombo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EditorAiCombo();

            value.SkillType                                 = (SkillType)GetInt32(new IntPtr(p + 0x010)); // 0270D5AB9C10 0x10 SkillType                   ( 0001866947F0 ModelEnumType SkillType SkillType SkillType Int32 )
            value.SkillId                                   = GetInt32(new IntPtr(p + 0x014)); // 0270D5AB9C30 0x14 SkillId                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
