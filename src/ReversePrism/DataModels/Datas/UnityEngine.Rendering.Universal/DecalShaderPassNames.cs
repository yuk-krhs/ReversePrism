using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DecalPreview                             string IL2CPP_TYPE_STRING
    // 000 DBufferProjector                         string IL2CPP_TYPE_STRING
    // 000 DecalProjectorForwardEmissive            string IL2CPP_TYPE_STRING
    // 000 DecalScreenSpaceProjector                string IL2CPP_TYPE_STRING
    // 000 DecalGBufferProjector                    string IL2CPP_TYPE_STRING
    // 000 DBufferMesh                              string IL2CPP_TYPE_STRING
    // 000 DecalMeshForwardEmissive                 string IL2CPP_TYPE_STRING
    // 000 DecalScreenSpaceMesh                     string IL2CPP_TYPE_STRING
    // 000 DecalGBufferMesh                         string IL2CPP_TYPE_STRING
    public partial class DecalShaderPassNames : DataModel
    {

        public static DecalShaderPassNames? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecalShaderPassNames() { Pointer= p0 };


            return value;
        }
    }
}
