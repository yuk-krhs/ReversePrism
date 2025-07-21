using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kMouseLeftId                             int IL2CPP_TYPE_I4
    // 000 kMouseRightId                            int IL2CPP_TYPE_I4
    // 000 kMouseMiddleId                           int IL2CPP_TYPE_I4
    // 000 kFakeTouchesId                           int IL2CPP_TYPE_I4
    // 058 m_PointerData                            Dictionary`2<int, PointerEventData> IL2CPP_TYPE_GENERICINST
    // 060 M_MouseState                             ModelClassType MouseState MouseState MouseState Pointer
    public partial class PointerInputModule : DataModel
    {
        public MouseState?                              M_MouseState                            { get; set; }

        public static PointerInputModule? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PointerInputModule() { Pointer= p0 };

            value.M_MouseState                              = GetObject<MouseState>(new IntPtr(p + 0x060), ReversePrism.DataModels.MouseState.FromPointer); // 0x60 M_MouseState                ( ModelClassType MouseState MouseState MouseState Pointer )

            return value;
        }
    }
}
