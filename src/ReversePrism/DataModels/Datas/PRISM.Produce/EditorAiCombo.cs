using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SkillType                                ModelEnumType SkillType SkillType SkillType Int32
    // 014 SkillId                                  ModelPrimitiveType int int int Int32
    public partial class EditorAiCombo : DataModel
    {
        public SkillType                                SkillType                               { get; set; }
        public int                                      SkillId                                 { get; set; }

        public static EditorAiCombo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EditorAiCombo() { Pointer= p0 };

            value.SkillType                                 = (SkillType)GetInt32(new IntPtr(p + 0x010)); // 0x10 SkillType                   ( ModelEnumType SkillType SkillType SkillType Int32 )
            value.SkillId                                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 SkillId                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
