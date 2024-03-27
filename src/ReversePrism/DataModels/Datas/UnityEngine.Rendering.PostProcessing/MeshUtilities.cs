using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Primitives                             Dictionary`2<PrimitiveType, Mesh> IL2CPP_TYPE_GENERICINST
    // 008 s_ColliderPrimitives                     Dictionary`2<Type, PrimitiveType> IL2CPP_TYPE_GENERICINST
    public partial class MeshUtilities
    {

        public static MeshUtilities? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MeshUtilities();


            return value;
        }
    }
}
