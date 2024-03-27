using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EditorSynergyList                        000185CD86C8 ModelClassListType List`1<EditorAiSynergy> List`1<EditorAiSynergy> List<EditorAiSynergy> Pointer
    // 018 SynergySetName                           000186671910 ModelPrimitiveType string string string String
    public partial class EditorAiSynergySet
    {
        public List<EditorAiSynergy>?                   EditorSynergyList                       { get; set; }
        public string                                   SynergySetName                          { get; set; }

        public static EditorAiSynergySet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EditorAiSynergySet();

            value.EditorSynergyList                         = GetObjectList<EditorAiSynergy>(new IntPtr(p + 0x010), ReversePrism.DataModels.EditorAiSynergy.FromPointer); // 0270D5AAA560 0x10 EditorSynergyList           ( 000185CD86C8 ModelClassListType List`1<EditorAiSynergy> List`1<EditorAiSynergy> List<EditorAiSynergy> Pointer )
            value.SynergySetName                            = GetString(new IntPtr(p + 0x018)); // 0270D5AAA580 0x18 SynergySetName              ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
