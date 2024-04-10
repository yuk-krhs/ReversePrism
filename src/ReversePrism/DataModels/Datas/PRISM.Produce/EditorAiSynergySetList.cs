using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _EditorAiSynergySetList                  000185CD8948 ModelClassListType List`1<EditorAiSynergySet> List`1<EditorAiSynergySet> List<EditorAiSynergySet> Pointer
    public partial class EditorAiSynergySetList : DataModel
    {
        public List<EditorAiSynergySet>?                _EditorAiSynergySetList                 { get; set; }

        public static EditorAiSynergySetList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EditorAiSynergySetList() { Pointer= p0 };

            value._EditorAiSynergySetList                   = GetObjectList<EditorAiSynergySet>(new IntPtr(p + 0x010), ReversePrism.DataModels.EditorAiSynergySet.FromPointer); // 024665B0E830 0x10 _EditorAiSynergySetList     ( 000185CD8948 ModelClassListType List`1<EditorAiSynergySet> List`1<EditorAiSynergySet> List<EditorAiSynergySet> Pointer )

            return value;
        }
    }
}
