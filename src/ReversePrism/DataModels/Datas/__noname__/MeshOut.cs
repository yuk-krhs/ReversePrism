using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 randBuf                                  <int> IL2CPP_TYPE_I
    // 018 vertCya                                  <int> IL2CPP_TYPE_I
    // 020 idxCya                                   <int> IL2CPP_TYPE_I
    // 028 vertSil                                  <int> IL2CPP_TYPE_I
    // 030 idxSil                                   <int> IL2CPP_TYPE_I
    // 038 vertArm                                  <int> IL2CPP_TYPE_I
    // 040 idxArm                                   <int> IL2CPP_TYPE_I
    public partial class MeshOut
    {

        public static MeshOut? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MeshOut();


            return value;
        }
    }
}
