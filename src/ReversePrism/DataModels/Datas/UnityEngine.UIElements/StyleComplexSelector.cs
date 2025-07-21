using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AncestorHashes                           ModelEnumType Hashes Hashes Hashes Int32
    // 020 M_Specificity                            ModelPrimitiveType int int int Int32
    // 028 Rule                                     ModelClassType StyleRule StyleRule StyleRule Pointer
    // 030 M_isSimple                               ModelPrimitiveType bool bool bool Bool
    // 038 M_Selectors                              ModelClassListType StyleSelector[] StyleSelector[] List<StyleSelector> Pointer
    // 040 RuleIndex                                ModelPrimitiveType int int int Int32
    // 048 NextInTable                              ModelClassType StyleComplexSelector StyleComplexSelector StyleComplexSelector Pointer
    // 050 OrderInStyleSheet                        ModelPrimitiveType int int int Int32
    // 000 s_PseudoStates                           Dictionary`2<string, PseudoStateData> IL2CPP_TYPE_GENERICINST
    // 008 m_HashList                               List`1<StyleSelectorPart> IL2CPP_TYPE_GENERICINST
    public partial class StyleComplexSelector : DataModel
    {
        public Hashes                                   AncestorHashes                          { get; set; }
        public int                                      M_Specificity                           { get; set; }
        public StyleRule?                               Rule                                    { get; set; }
        public bool                                     M_isSimple                              { get; set; }
        public List<StyleSelector>?                     M_Selectors                             { get; set; }
        public int                                      RuleIndex                               { get; set; }
        public StyleComplexSelector?                    NextInTable                             { get; set; }
        public int                                      OrderInStyleSheet                       { get; set; }

        public static StyleComplexSelector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleComplexSelector() { Pointer= p0 };

            value.AncestorHashes                            = (Hashes)GetInt32(new IntPtr(p + 0x010)); // 0x10 AncestorHashes              ( ModelEnumType Hashes Hashes Hashes Int32 )
            value.M_Specificity                             = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_Specificity               ( ModelPrimitiveType int int int Int32 )
            value.Rule                                      = GetObject<StyleRule>(new IntPtr(p + 0x028), ReversePrism.DataModels.StyleRule.FromPointer); // 0x28 Rule                        ( ModelClassType StyleRule StyleRule StyleRule Pointer )
            value.M_isSimple                                = GetBool(new IntPtr(p + 0x030)); // 0x30 M_isSimple                  ( ModelPrimitiveType bool bool bool Bool )
            value.M_Selectors                               = GetObjectList<StyleSelector>(new IntPtr(p + 0x038), ReversePrism.DataModels.StyleSelector.FromPointer); // 0x38 M_Selectors                 ( ModelClassListType StyleSelector[] StyleSelector[] List<StyleSelector> Pointer )
            value.RuleIndex                                 = GetInt32(new IntPtr(p + 0x040)); // 0x40 RuleIndex                   ( ModelPrimitiveType int int int Int32 )
            value.NextInTable                               = GetObject<StyleComplexSelector>(new IntPtr(p + 0x048), ReversePrism.DataModels.StyleComplexSelector.FromPointer); // 0x48 NextInTable                 ( ModelClassType StyleComplexSelector StyleComplexSelector StyleComplexSelector Pointer )
            value.OrderInStyleSheet                         = GetInt32(new IntPtr(p + 0x050)); // 0x50 OrderInStyleSheet           ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
