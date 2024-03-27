using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_StyleSheetStack                        000185D0EC28 ModelClassListType List`1<StyleSheet> List`1<StyleSheet> List<StyleSheet> Pointer
    // 018 VariableContext                          00018667D850 ModelClassType StyleVariableContext StyleVariableContext StyleVariableContext Pointer
    // 020 CurrentElement                           0001866B3270 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 028 processResult                            Action`2<VisualElement, MatchResultInfo> IL2CPP_TYPE_GENERICINST
    // 030 AncestorFilter                           0001866AB830 ModelClassType AncestorFilter AncestorFilter AncestorFilter Pointer
    public partial class StyleMatchingContext
    {
        public List<StyleSheet>?                        M_StyleSheetStack                       { get; set; }
        public StyleVariableContext?                    VariableContext                         { get; set; }
        public VisualElement?                           CurrentElement                          { get; set; }
        public AncestorFilter?                          AncestorFilter                          { get; set; }

        public static StyleMatchingContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleMatchingContext();

            value.M_StyleSheetStack                         = GetObjectList<StyleSheet>(new IntPtr(p + 0x010), ReversePrism.DataModels.StyleSheet.FromPointer); // 02700685DFC0 0x10 M_StyleSheetStack           ( 000185D0EC28 ModelClassListType List`1<StyleSheet> List`1<StyleSheet> List<StyleSheet> Pointer )
            value.VariableContext                           = GetObject<StyleVariableContext>(new IntPtr(p + 0x018), ReversePrism.DataModels.StyleVariableContext.FromPointer); // 02700685DFE0 0x18 VariableContext             ( 00018667D850 ModelClassType StyleVariableContext StyleVariableContext StyleVariableContext Pointer )
            value.CurrentElement                            = GetObject<VisualElement>(new IntPtr(p + 0x020), ReversePrism.DataModels.VisualElement.FromPointer); // 02700685E000 0x20 CurrentElement              ( 0001866B3270 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.AncestorFilter                            = GetObject<AncestorFilter>(new IntPtr(p + 0x030), ReversePrism.DataModels.AncestorFilter.FromPointer); // 02700685E040 0x30 AncestorFilter              ( 0001866AB830 ModelClassType AncestorFilter AncestorFilter AncestorFilter Pointer )

            return value;
        }
    }
}
