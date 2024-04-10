using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SynergyName                              000186671910 ModelPrimitiveType string string string String
    // 018 UnitId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 SkillList                                000185CD8018 ModelClassListType List`1<EditorAiCombo> List`1<EditorAiCombo> List<EditorAiCombo> Pointer
    public partial class EditorAiSynergy : DataModel
    {
        public string                                   SynergyName                             { get; set; }
        public int                                      UnitId                                  { get; set; }
        public List<EditorAiCombo>?                     SkillList                               { get; set; }

        public static EditorAiSynergy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EditorAiSynergy() { Pointer= p0 };

            value.SynergyName                               = GetString(new IntPtr(p + 0x010)); // 024665B31220 0x10 SynergyName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x018)); // 024665B31240 0x18 UnitId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SkillList                                 = GetObjectList<EditorAiCombo>(new IntPtr(p + 0x020), ReversePrism.DataModels.EditorAiCombo.FromPointer); // 024665B31260 0x20 SkillList                   ( 000185CD8018 ModelClassListType List`1<EditorAiCombo> List`1<EditorAiCombo> List<EditorAiCombo> Pointer )

            return value;
        }
    }
}
