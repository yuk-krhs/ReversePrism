using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 edgeEdgeContactQueue                     NativeQueue`1<EdgeEdgeContact> IL2CPP_TYPE_GENERICINST
    // 018 pointTriangleContactQueue                NativeQueue`1<PointTriangleContact> IL2CPP_TYPE_GENERICINST
    public partial class ClearBufferJob : DataModel
    {

        public static ClearBufferJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClearBufferJob() { Pointer= p0 };


            return value;
        }
    }
}
