using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 cf                                       NativeArray`1<ColliderFlag> IL2CPP_TYPE_GENERICINST
    // 020 cp                                       NativeArray`1<ColliderParam> IL2CPP_TYPE_GENERICINST
    // 030 bcp                                      NativeArray`1<BoneColliderParam> IL2CPP_TYPE_GENERICINST
    // 040 ssd                                      NativeArray`1<SwayStringData> IL2CPP_TYPE_GENERICINST
    public partial class CalcJob : DataModel
    {

        public static CalcJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CalcJob() { Pointer= p0 };


            return value;
        }
    }
}
