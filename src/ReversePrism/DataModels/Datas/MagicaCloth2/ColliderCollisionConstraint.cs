using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 tempFrictionArray                        NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 020 tempNormalArray                          NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ColliderCollisionConstraint : DataModel
    {

        public static ColliderCollisionConstraint? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColliderCollisionConstraint() { Pointer= p0 };


            return value;
        }
    }
}
