using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EditorAiPatternList                      000185CD8278 ModelClassListType List`1<EditorAiPattern> List`1<EditorAiPattern> List<EditorAiPattern> Pointer
    // 018 PatternSetName                           000186671910 ModelPrimitiveType string string string String
    public partial class EditorAiPatternSet
    {
        public List<EditorAiPattern>?                   EditorAiPatternList                     { get; set; }
        public string                                   PatternSetName                          { get; set; }

        public static EditorAiPatternSet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EditorAiPatternSet();

            value.EditorAiPatternList                       = GetObjectList<EditorAiPattern>(new IntPtr(p + 0x010), ReversePrism.DataModels.EditorAiPattern.FromPointer); // 0270D5A9E020 0x10 EditorAiPatternList         ( 000185CD8278 ModelClassListType List`1<EditorAiPattern> List`1<EditorAiPattern> List<EditorAiPattern> Pointer )
            value.PatternSetName                            = GetString(new IntPtr(p + 0x018)); // 0270D5A9E040 0x18 PatternSetName              ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
