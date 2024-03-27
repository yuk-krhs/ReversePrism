using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 M_Content                                0001865DC5D0 ModelClassType GUIContent GUIContent GUIContent Pointer
    // 050 M_ForcedMinHeight                        000186666CB0 ModelPrimitiveType float float float Single
    // 054 M_ForcedMaxHeight                        000186666CB0 ModelPrimitiveType float float float Single
    public partial class GUIWordWrapSizer
    {
        public GUIContent?                              M_Content                               { get; set; }
        public float                                    M_ForcedMinHeight                       { get; set; }
        public float                                    M_ForcedMaxHeight                       { get; set; }

        public static GUIWordWrapSizer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GUIWordWrapSizer();

            value.M_Content                                 = GetObject<GUIContent>(new IntPtr(p + 0x048), ReversePrism.DataModels.GUIContent.FromPointer); // 027006928988 0x48 M_Content                   ( 0001865DC5D0 ModelClassType GUIContent GUIContent GUIContent Pointer )
            value.M_ForcedMinHeight                         = GetSingle(new IntPtr(p + 0x050)); // 0270069289A8 0x50 M_ForcedMinHeight           ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.M_ForcedMaxHeight                         = GetSingle(new IntPtr(p + 0x054)); // 0270069289C8 0x54 M_ForcedMaxHeight           ( 000186666CB0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
