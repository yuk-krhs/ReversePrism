using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 cmd                                      NativeArray`1<CreateMeshData> IL2CPP_TYPE_GENERICINST
    // 020 csd                                      NativeArray`1<CyaSilData> IL2CPP_TYPE_GENERICINST
    // 030 mvcd                                     NativeArray`1<MeshVertexData> IL2CPP_TYPE_GENERICINST
    // 040 micd                                     NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 050 mvsd0                                    NativeArray`1<MeshVertexData> IL2CPP_TYPE_GENERICINST
    // 060 misd0                                    NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 070 mvsd1                                    NativeArray`1<MeshVertexData> IL2CPP_TYPE_GENERICINST
    // 080 misd1                                    NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 090 mvsd2                                    NativeArray`1<MeshVertexData> IL2CPP_TYPE_GENERICINST
    // 0A0 misd2                                    NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 0B0 mvad                                     NativeArray`1<MeshVertexData> IL2CPP_TYPE_GENERICINST
    // 0C0 miad                                     NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 0D0 msh                                      NativeArray`1<MeshOut> IL2CPP_TYPE_GENERICINST
    public partial class CreateMeshJob
    {

        public static CreateMeshJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CreateMeshJob();


            return value;
        }
    }
}
