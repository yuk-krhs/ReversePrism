using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 pointTriangleContactQueue                NativeQueue`1<PointTriangleContact> IL2CPP_TYPE_GENERICINST
    // 018 pointTriangleContactList                 NativeList`1<PointTriangleContact> IL2CPP_TYPE_GENERICINST
    public partial class PointTriangleToListJob : DataModel
    {

        public static PointTriangleToListJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PointTriangleToListJob() { Pointer= p0 };


            return value;
        }
    }
}
