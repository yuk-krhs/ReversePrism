using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PatternName                              ModelPrimitiveType string string string String
    // 018 UnitId                                   ModelPrimitiveType int int int Int32
    // 020 ComboList                                ModelClassListType List`1<EditorAiCombo> List`1<EditorAiCombo> List<EditorAiCombo> Pointer
    public partial class EditorAiPattern : DataModel
    {
        public string                                   PatternName                             { get; set; }
        public int                                      UnitId                                  { get; set; }
        public List<EditorAiCombo>?                     ComboList                               { get; set; }

        public static EditorAiPattern? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EditorAiPattern() { Pointer= p0 };

            value.PatternName                               = GetString(new IntPtr(p + 0x010)); // 0x10 PatternName                 ( ModelPrimitiveType string string string String )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 UnitId                      ( ModelPrimitiveType int int int Int32 )
            value.ComboList                                 = GetObjectList<EditorAiCombo>(new IntPtr(p + 0x020), ReversePrism.DataModels.EditorAiCombo.FromPointer); // 0x20 ComboList                   ( ModelClassListType List`1<EditorAiCombo> List`1<EditorAiCombo> List<EditorAiCombo> Pointer )

            return value;
        }
    }
}
