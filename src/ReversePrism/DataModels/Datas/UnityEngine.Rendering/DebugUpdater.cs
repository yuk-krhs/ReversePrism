using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Instance                               DebugUpdater IL2CPP_TYPE_CLASS
    // 020 M_Orientation                            ModelEnumType ScreenOrientation ScreenOrientation ScreenOrientation Int32
    // 024 M_RuntimeUiWasVisibleLastFrame           ModelPrimitiveType bool bool bool Bool
    public partial class DebugUpdater : DataModel
    {
        public ScreenOrientation                        M_Orientation                           { get; set; }
        public bool                                     M_RuntimeUiWasVisibleLastFrame          { get; set; }

        public static DebugUpdater? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUpdater() { Pointer= p0 };

            value.M_Orientation                             = (ScreenOrientation)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_Orientation               ( ModelEnumType ScreenOrientation ScreenOrientation ScreenOrientation Int32 )
            value.M_RuntimeUiWasVisibleLastFrame            = GetBool(new IntPtr(p + 0x024)); // 0x24 M_RuntimeUiWasVisibleLastFrame ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
