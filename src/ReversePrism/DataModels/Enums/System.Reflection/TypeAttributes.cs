using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum TypeAttributes
    {
        VisibilityMask,
        NotPublic,
        Public,
        NestedPublic,
        NestedPrivate,
        NestedFamily,
        NestedAssembly,
        NestedFamANDAssem,
        NestedFamORAssem,
        LayoutMask,
        AutoLayout,
        SequentialLayout,
        ExplicitLayout,
        ClassSemanticsMask,
        Class,
        Interface,
        Abstract,
        Sealed,
        SpecialName,
        Import,
        Serializable,
        WindowsRuntime,
        StringFormatMask,
        AnsiClass,
        UnicodeClass,
        AutoClass,
        CustomFormatClass,
        CustomFormatMask,
        BeforeFieldInit,
        RTSpecialName,
        HasSecurity,
        ReservedMask,
    }
}
