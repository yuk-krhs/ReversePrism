using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EditorAiPatternList                      ModelClassListType List`1<EditorAiPattern> List`1<EditorAiPattern> List<EditorAiPattern> Pointer
    // 018 PatternSetName                           ModelPrimitiveType string string string String
    public partial class EditorAiPatternSet : DataModel
    {
        public List<EditorAiPattern>?                   EditorAiPatternList                     { get; set; }
        public string                                   PatternSetName                          { get; set; }

        public static EditorAiPatternSet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EditorAiPatternSet() { Pointer= p0 };

            value.EditorAiPatternList                       = GetObjectList<EditorAiPattern>(new IntPtr(p + 0x010), ReversePrism.DataModels.EditorAiPattern.FromPointer); // 0x10 EditorAiPatternList         ( ModelClassListType List`1<EditorAiPattern> List`1<EditorAiPattern> List<EditorAiPattern> Pointer )
            value.PatternSetName                            = GetString(new IntPtr(p + 0x018)); // 0x18 PatternSetName              ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
