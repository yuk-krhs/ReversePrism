using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Self                                   <int> IL2CPP_TYPE_I
    public partial class MeshTransformList : DataModel
    {

        public static MeshTransformList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MeshTransformList() { Pointer= p0 };


            return value;
        }
    }
}
