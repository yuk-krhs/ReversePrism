using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ProcessVarContext                      ModelClassType StyleVariableContext StyleVariableContext StyleVariableContext Pointer
    // 018 m_UpdateList                             HashSet`1<VisualElement> IL2CPP_TYPE_GENERICINST
    // 020 m_ParentList                             HashSet`1<VisualElement> IL2CPP_TYPE_GENERICINST
    // 028 M_TempMatchResults                       ModelEnumListType List`1<SelectorMatchRecord> List`1<SelectorMatchRecord> List<SelectorMatchRecord> Pointer
    // 030 CurrentPixelsPerPoint                    ModelPrimitiveType float float float Single
    // 038 M_StyleMatchingContext                   ModelClassType StyleMatchingContext StyleMatchingContext StyleMatchingContext Pointer
    // 040 M_StylePropertyReader                    ModelClassType StylePropertyReader StylePropertyReader StylePropertyReader Pointer
    // 048 M_AnimatedProperties                     ModelEnumListType List`1<StylePropertyId> List`1<StylePropertyId> List<StylePropertyId> Pointer
    public partial class VisualTreeStyleUpdaterTraversal : DataModel
    {
        public StyleVariableContext?                    M_ProcessVarContext                     { get; set; }
        public List<SelectorMatchRecord>?               M_TempMatchResults                      { get; set; }
        public float                                    CurrentPixelsPerPoint                   { get; set; }
        public StyleMatchingContext?                    M_StyleMatchingContext                  { get; set; }
        public StylePropertyReader?                     M_StylePropertyReader                   { get; set; }
        public List<StylePropertyId>?                   M_AnimatedProperties                    { get; set; }

        public static VisualTreeStyleUpdaterTraversal? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VisualTreeStyleUpdaterTraversal() { Pointer= p0 };

            value.M_ProcessVarContext                       = GetObject<StyleVariableContext>(new IntPtr(p + 0x010), ReversePrism.DataModels.StyleVariableContext.FromPointer); // 0x10 M_ProcessVarContext         ( ModelClassType StyleVariableContext StyleVariableContext StyleVariableContext Pointer )
            value.M_TempMatchResults                        = GetEnumList<SelectorMatchRecord>(new IntPtr(p + 0x028)); // 0x28 M_TempMatchResults          ( ModelEnumListType List`1<SelectorMatchRecord> List`1<SelectorMatchRecord> List<SelectorMatchRecord> Pointer )
            value.CurrentPixelsPerPoint                     = GetSingle(new IntPtr(p + 0x030)); // 0x30 CurrentPixelsPerPoint       ( ModelPrimitiveType float float float Single )
            value.M_StyleMatchingContext                    = GetObject<StyleMatchingContext>(new IntPtr(p + 0x038), ReversePrism.DataModels.StyleMatchingContext.FromPointer); // 0x38 M_StyleMatchingContext      ( ModelClassType StyleMatchingContext StyleMatchingContext StyleMatchingContext Pointer )
            value.M_StylePropertyReader                     = GetObject<StylePropertyReader>(new IntPtr(p + 0x040), ReversePrism.DataModels.StylePropertyReader.FromPointer); // 0x40 M_StylePropertyReader       ( ModelClassType StylePropertyReader StylePropertyReader StylePropertyReader Pointer )
            value.M_AnimatedProperties                      = GetEnumList<StylePropertyId>(new IntPtr(p + 0x048)); // 0x48 M_AnimatedProperties        ( ModelEnumListType List`1<StylePropertyId> List`1<StylePropertyId> List<StylePropertyId> Pointer )

            return value;
        }
    }
}
