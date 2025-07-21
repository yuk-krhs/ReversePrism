using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 hitList                                  NativeList`1<VirtualMeshRaycastHit> IL2CPP_TYPE_GENERICINST
    public partial class Work_IntersetcSortJob : DataModel
    {

        public static Work_IntersetcSortJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Work_IntersetcSortJob() { Pointer= p0 };


            return value;
        }
    }
}
