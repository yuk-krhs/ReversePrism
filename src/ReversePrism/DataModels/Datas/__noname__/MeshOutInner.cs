using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 randBuf                                  NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 020 vertCya                                  NativeArray`1<VertexData> IL2CPP_TYPE_GENERICINST
    // 030 idxCya                                   NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 040 vertSil                                  NativeArray`1<VertexData> IL2CPP_TYPE_GENERICINST
    // 050 idxSil                                   NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 060 vertArm                                  NativeArray`1<VertexData> IL2CPP_TYPE_GENERICINST
    // 070 idxArm                                   NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    public partial class MeshOutInner
    {

        public static MeshOutInner? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MeshOutInner();


            return value;
        }
    }
}
