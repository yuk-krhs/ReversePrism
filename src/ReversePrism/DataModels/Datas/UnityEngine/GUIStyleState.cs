using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Ptr                                    <int> IL2CPP_TYPE_I
    // 018 M_SourceStyle                            0001865DF720 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    public partial class GUIStyleState
    {
        public GUIStyle?                                M_SourceStyle                           { get; set; }

        public static GUIStyleState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GUIStyleState();

            value.M_SourceStyle                             = GetObject<GUIStyle>(new IntPtr(p + 0x018), ReversePrism.DataModels.GUIStyle.FromPointer); // 027006928660 0x18 M_SourceStyle               ( 0001865DF720 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )

            return value;
        }
    }
}
