using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kBaseScoreForNonGeneratedLayouts         float IL2CPP_TYPE_R4
    // 010 layoutTypes                              Dictionary`2<InternedString, Type> IL2CPP_TYPE_GENERICINST
    // 018 layoutStrings                            Dictionary`2<InternedString, string> IL2CPP_TYPE_GENERICINST
    // 020 layoutBuilders                           Dictionary`2<InternedString, Func`1<InputControlLayout>> IL2CPP_TYPE_GENERICINST
    // 028 baseLayoutTable                          Dictionary`2<InternedString, InternedString> IL2CPP_TYPE_GENERICINST
    // 030 layoutOverrides                          Dictionary`2<InternedString, InternedString[]> IL2CPP_TYPE_GENERICINST
    // 038 layoutOverrideNames                      HashSet`1<InternedString> IL2CPP_TYPE_GENERICINST
    // 040 precompiledLayouts                       Dictionary`2<InternedString, PrecompiledLayout> IL2CPP_TYPE_GENERICINST
    // 048 LayoutMatchers                           ModelEnumListType List`1<LayoutMatcher> List`1<LayoutMatcher> List<LayoutMatcher> Pointer
    public partial class Collection : DataModel
    {
        public List<LayoutMatcher>?                     LayoutMatchers                          { get; set; }

        public static Collection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Collection() { Pointer= p0 };

            value.LayoutMatchers                            = GetEnumList<LayoutMatcher>(new IntPtr(p + 0x048)); // 0x48 LayoutMatchers              ( ModelEnumListType List`1<LayoutMatcher> List`1<LayoutMatcher> List<LayoutMatcher> Pointer )

            return value;
        }
    }
}
