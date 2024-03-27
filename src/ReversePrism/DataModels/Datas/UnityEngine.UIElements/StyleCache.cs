using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_ComputedStyleCache                     Dictionary`2<long, ComputedStyle> IL2CPP_TYPE_GENERICINST
    // 008 s_StyleVariableContextCache              Dictionary`2<int, StyleVariableContext> IL2CPP_TYPE_GENERICINST
    // 010 s_ComputedTransitionsCache               Dictionary`2<int, ComputedTransitionProperty[]> IL2CPP_TYPE_GENERICINST
    public partial class StyleCache
    {

        public static StyleCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleCache();


            return value;
        }
    }
}
