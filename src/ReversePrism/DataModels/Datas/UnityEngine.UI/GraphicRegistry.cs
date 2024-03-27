using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Instance                               GraphicRegistry IL2CPP_TYPE_CLASS
    // 010 m_Graphics                               Dictionary`2<Canvas, IndexedSet`1<Graphic>> IL2CPP_TYPE_GENERICINST
    // 018 m_RaycastableGraphics                    Dictionary`2<Canvas, IndexedSet`1<Graphic>> IL2CPP_TYPE_GENERICINST
    // 008 s_EmptyList                              List`1<Graphic> IL2CPP_TYPE_GENERICINST
    public partial class GraphicRegistry
    {

        public static GraphicRegistry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GraphicRegistry();


            return value;
        }
    }
}
