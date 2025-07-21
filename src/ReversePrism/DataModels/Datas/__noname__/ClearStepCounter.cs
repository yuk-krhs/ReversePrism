using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 processingStepParticle                   NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 020 processingStepTriangleBending            NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 030 processingStepEdgeCollision              NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 040 processingStepCollider                   NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 050 processingStepBaseLine                   NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 060 processingStepMotionParticle             NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 070 processingSelfParticle                   NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 080 processingSelfPointTriangle              NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 090 processingSelfEdgeEdge                   NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 0A0 processingSelfTrianglePoint              NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ClearStepCounter : DataModel
    {

        public static ClearStepCounter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClearStepCounter() { Pointer= p0 };


            return value;
        }
    }
}
