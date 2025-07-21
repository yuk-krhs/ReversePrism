using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 edgeEdgeContactQueue                     NativeQueue`1<EdgeEdgeContact> IL2CPP_TYPE_GENERICINST
    // 018 edgeEdgeContactList                      NativeList`1<EdgeEdgeContact> IL2CPP_TYPE_GENERICINST
    public partial class EdgeEdgeToListJob : DataModel
    {

        public static EdgeEdgeToListJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EdgeEdgeToListJob() { Pointer= p0 };


            return value;
        }
    }
}
