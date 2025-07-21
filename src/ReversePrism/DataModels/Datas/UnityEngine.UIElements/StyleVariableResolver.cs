using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kMaxResolves                             int IL2CPP_TYPE_I4
    // 000 s_SyntaxParser                           StyleSyntaxParser IL2CPP_TYPE_CLASS
    // 010 M_Matcher                                ModelClassType StylePropertyValueMatcher StylePropertyValueMatcher StylePropertyValueMatcher Pointer
    // 018 M_ResolvedValues                         ModelEnumListType List`1<StylePropertyValue> List`1<StylePropertyValue> List<StylePropertyValue> Pointer
    // 020 m_ResolvedVarStack                       Stack`1<string> IL2CPP_TYPE_GENERICINST
    // 028 M_Property                               ModelClassType StyleProperty StyleProperty StyleProperty Pointer
    // 030 m_ContextStack                           Stack`1<ResolveContext> IL2CPP_TYPE_GENERICINST
    // 038 M_CurrentContext                         ModelEnumType ResolveContext ResolveContext ResolveContext Int32
    // 048 VariableContext                          ModelClassType StyleVariableContext StyleVariableContext StyleVariableContext Pointer
    public partial class StyleVariableResolver : DataModel
    {
        public StylePropertyValueMatcher?               M_Matcher                               { get; set; }
        public List<StylePropertyValue>?                M_ResolvedValues                        { get; set; }
        public StyleProperty?                           M_Property                              { get; set; }
        public ResolveContext                           M_CurrentContext                        { get; set; }
        public StyleVariableContext?                    VariableContext                         { get; set; }

        public static StyleVariableResolver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleVariableResolver() { Pointer= p0 };

            value.M_Matcher                                 = GetObject<StylePropertyValueMatcher>(new IntPtr(p + 0x010), ReversePrism.DataModels.StylePropertyValueMatcher.FromPointer); // 0x10 M_Matcher                   ( ModelClassType StylePropertyValueMatcher StylePropertyValueMatcher StylePropertyValueMatcher Pointer )
            value.M_ResolvedValues                          = GetEnumList<StylePropertyValue>(new IntPtr(p + 0x018)); // 0x18 M_ResolvedValues            ( ModelEnumListType List`1<StylePropertyValue> List`1<StylePropertyValue> List<StylePropertyValue> Pointer )
            value.M_Property                                = GetObject<StyleProperty>(new IntPtr(p + 0x028), ReversePrism.DataModels.StyleProperty.FromPointer); // 0x28 M_Property                  ( ModelClassType StyleProperty StyleProperty StyleProperty Pointer )
            value.M_CurrentContext                          = (ResolveContext)GetInt32(new IntPtr(p + 0x038)); // 0x38 M_CurrentContext            ( ModelEnumType ResolveContext ResolveContext ResolveContext Int32 )
            value.VariableContext                           = GetObject<StyleVariableContext>(new IntPtr(p + 0x048), ReversePrism.DataModels.StyleVariableContext.FromPointer); // 0x48 VariableContext             ( ModelClassType StyleVariableContext StyleVariableContext StyleVariableContext Pointer )

            return value;
        }
    }
}
