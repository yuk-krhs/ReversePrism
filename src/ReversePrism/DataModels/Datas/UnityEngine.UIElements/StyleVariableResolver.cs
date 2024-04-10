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
    // 010 M_Matcher                                0001865CB7B0 ModelClassType StylePropertyValueMatcher StylePropertyValueMatcher StylePropertyValueMatcher Pointer
    // 018 M_ResolvedValues                         000185D0E4D8 ModelEnumListType List`1<StylePropertyValue> List`1<StylePropertyValue> List<StylePropertyValue> Pointer
    // 020 m_ResolvedVarStack                       Stack`1<string> IL2CPP_TYPE_GENERICINST
    // 028 M_Property                               0001865C9050 ModelClassType StyleProperty StyleProperty StyleProperty Pointer
    // 030 m_ContextStack                           Stack`1<ResolveContext> IL2CPP_TYPE_GENERICINST
    // 038 M_CurrentContext                         0001865A3A20 ModelEnumType ResolveContext ResolveContext ResolveContext Int32
    // 048 VariableContext                          00018667D370 ModelClassType StyleVariableContext StyleVariableContext StyleVariableContext Pointer
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

            value.M_Matcher                                 = GetObject<StylePropertyValueMatcher>(new IntPtr(p + 0x010), ReversePrism.DataModels.StylePropertyValueMatcher.FromPointer); // 0245A6805DA8 0x10 M_Matcher                   ( 0001865CB7B0 ModelClassType StylePropertyValueMatcher StylePropertyValueMatcher StylePropertyValueMatcher Pointer )
            value.M_ResolvedValues                          = GetEnumList<StylePropertyValue>(new IntPtr(p + 0x018)); // 0245A6805DC8 0x18 M_ResolvedValues            ( 000185D0E4D8 ModelEnumListType List`1<StylePropertyValue> List`1<StylePropertyValue> List<StylePropertyValue> Pointer )
            value.M_Property                                = GetObject<StyleProperty>(new IntPtr(p + 0x028), ReversePrism.DataModels.StyleProperty.FromPointer); // 0245A6805E08 0x28 M_Property                  ( 0001865C9050 ModelClassType StyleProperty StyleProperty StyleProperty Pointer )
            value.M_CurrentContext                          = (ResolveContext)GetInt32(new IntPtr(p + 0x038)); // 0245A6805E48 0x38 M_CurrentContext            ( 0001865A3A20 ModelEnumType ResolveContext ResolveContext ResolveContext Int32 )
            value.VariableContext                           = GetObject<StyleVariableContext>(new IntPtr(p + 0x048), ReversePrism.DataModels.StyleVariableContext.FromPointer); // 0245A6805E68 0x48 VariableContext             ( 00018667D370 ModelClassType StyleVariableContext StyleVariableContext StyleVariableContext Pointer )

            return value;
        }
    }
}
