using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 localNormals                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 020 localTangents                            NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    public partial class Import_GenerateTangentJob : DataModel
    {

        public static Import_GenerateTangentJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Import_GenerateTangentJob() { Pointer= p0 };


            return value;
        }
    }
}
