using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_NormalReconstructionMatrixID           int IL2CPP_TYPE_I4
    // 008 s_NormalReconstructionMatrix             Matrix4x4[] IL2CPP_TYPE_SZARRAY
    public partial class NormalReconstruction : DataModel
    {

        public static NormalReconstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NormalReconstruction() { Pointer= p0 };


            return value;
        }
    }
}
