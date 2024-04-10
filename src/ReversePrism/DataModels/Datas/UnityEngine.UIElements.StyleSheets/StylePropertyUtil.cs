using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_NameToId                               Dictionary`2<string, StylePropertyId> IL2CPP_TYPE_GENERICINST
    // 008 s_IdToName                               Dictionary`2<StylePropertyId, string> IL2CPP_TYPE_GENERICINST
    // 010 s_AnimatableProperties                   HashSet`1<StylePropertyId> IL2CPP_TYPE_GENERICINST
    // 018 s_AnimatableWithUsageHintProperties      Dictionary`2<StylePropertyId, UsageHints> IL2CPP_TYPE_GENERICINST
    public partial class StylePropertyUtil : DataModel
    {

        public static StylePropertyUtil? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StylePropertyUtil() { Pointer= p0 };


            return value;
        }
    }
}
