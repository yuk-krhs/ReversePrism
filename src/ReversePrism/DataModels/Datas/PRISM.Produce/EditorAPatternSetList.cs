using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EditorAiPatternSetList                   000185CD84B8 ModelClassListType List`1<EditorAiPatternSet> List`1<EditorAiPatternSet> List<EditorAiPatternSet> Pointer
    public partial class EditorAPatternSetList
    {
        public List<EditorAiPatternSet>?                EditorAiPatternSetList                  { get; set; }

        public static EditorAPatternSetList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EditorAPatternSetList();

            value.EditorAiPatternSetList                    = GetObjectList<EditorAiPatternSet>(new IntPtr(p + 0x010), ReversePrism.DataModels.EditorAiPatternSet.FromPointer); // 0270D5A9DBC8 0x10 EditorAiPatternSetList      ( 000185CD84B8 ModelClassListType List`1<EditorAiPatternSet> List`1<EditorAiPatternSet> List<EditorAiPatternSet> Pointer )

            return value;
        }
    }
}
