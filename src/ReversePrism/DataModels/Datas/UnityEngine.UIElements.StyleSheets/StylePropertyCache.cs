using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_PropertySyntaxCache                    Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    // 008 s_NonTerminalValues                      Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    public partial class StylePropertyCache
    {

        public static StylePropertyCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StylePropertyCache();


            return value;
        }
    }
}
