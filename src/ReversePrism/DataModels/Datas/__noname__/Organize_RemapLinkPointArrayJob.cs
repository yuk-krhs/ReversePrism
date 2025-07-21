using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 joinIndices                              NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 020 vertexRemapIndices                       NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 030 oldVertexToVertexMap                     NativeParallelMultiHashMap`2<ushort, ushort> IL2CPP_TYPE_GENERICINST
    // 040 newVertexToVertexMap                     NativeParallelMultiHashMap`2<ushort, ushort> IL2CPP_TYPE_GENERICINST
    public partial class Organize_RemapLinkPointArrayJob : DataModel
    {

        public static Organize_RemapLinkPointArrayJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Organize_RemapLinkPointArrayJob() { Pointer= p0 };


            return value;
        }
    }
}
