using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_usedNames                              HashSet`1<string> IL2CPP_TYPE_GENERICINST
    // 008 s_FoldoutType                            Type IL2CPP_TYPE_CLASS
    // 010 S_InspectorElementUssClassName           0001866738F0 ModelPrimitiveType string string string String
    public partial class VisualElementUtils
    {
        public string                                   S_InspectorElementUssClassName          { get; set; }

        public static VisualElementUtils? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VisualElementUtils();

            value.S_InspectorElementUssClassName            = GetString(new IntPtr(p + 0x010)); // 02700685CAB0 0x10 S_InspectorElementUssClassName ( 0001866738F0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
