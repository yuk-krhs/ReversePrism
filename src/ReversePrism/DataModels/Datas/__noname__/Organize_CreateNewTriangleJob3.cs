using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 newTriangleList                          NativeList`1<int3> IL2CPP_TYPE_GENERICINST
    // 018 triangleSet                              NativeParallelHashSet`1<int3> IL2CPP_TYPE_GENERICINST
    public partial class Organize_CreateNewTriangleJob3 : DataModel
    {

        public static Organize_CreateNewTriangleJob3? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Organize_CreateNewTriangleJob3() { Pointer= p0 };


            return value;
        }
    }
}
