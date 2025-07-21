using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 EditorAiPatternSetList                   ModelClassType EditorAPatternSetList EditorAPatternSetList EditorAPatternSetList Pointer
    // 020 EditorAiConfig                           ModelClassType EditorAiConfig EditorAiConfig EditorAiConfig Pointer
    // 028 EditorAiSynergySetList                   ModelClassType EditorAiSynergySetList EditorAiSynergySetList EditorAiSynergySetList Pointer
    public partial class AiPatternDataScriptableObject : DataModel
    {
        public EditorAPatternSetList?                   EditorAiPatternSetList                  { get; set; }
        public EditorAiConfig?                          EditorAiConfig                          { get; set; }
        public EditorAiSynergySetList?                  EditorAiSynergySetList                  { get; set; }

        public static AiPatternDataScriptableObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AiPatternDataScriptableObject() { Pointer= p0 };

            value.EditorAiPatternSetList                    = GetObject<EditorAPatternSetList>(new IntPtr(p + 0x018), ReversePrism.DataModels.EditorAPatternSetList.FromPointer); // 0x18 EditorAiPatternSetList      ( ModelClassType EditorAPatternSetList EditorAPatternSetList EditorAPatternSetList Pointer )
            value.EditorAiConfig                            = GetObject<EditorAiConfig>(new IntPtr(p + 0x020), ReversePrism.DataModels.EditorAiConfig.FromPointer); // 0x20 EditorAiConfig              ( ModelClassType EditorAiConfig EditorAiConfig EditorAiConfig Pointer )
            value.EditorAiSynergySetList                    = GetObject<EditorAiSynergySetList>(new IntPtr(p + 0x028), ReversePrism.DataModels.EditorAiSynergySetList.FromPointer); // 0x28 EditorAiSynergySetList      ( ModelClassType EditorAiSynergySetList EditorAiSynergySetList EditorAiSynergySetList Pointer )

            return value;
        }
    }
}
