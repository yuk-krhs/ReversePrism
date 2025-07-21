using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 attributes                               NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 020 transformFlags                           NativeArray`1<ExBitFlag8> IL2CPP_TYPE_GENERICINST
    public partial class Proxy_BoneClothApplayTransformFlagJob : DataModel
    {

        public static Proxy_BoneClothApplayTransformFlagJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Proxy_BoneClothApplayTransformFlagJob() { Pointer= p0 };


            return value;
        }
    }
}
