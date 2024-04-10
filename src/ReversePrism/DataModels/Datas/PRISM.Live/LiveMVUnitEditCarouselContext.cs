using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 <RequestExchangeMemberPositionAsync>k__BackingField Func`4<LiveMVUnit, int, int, UniTask`1<bool>> IL2CPP_TYPE_GENERICINST
    public partial class LiveMVUnitEditCarouselContext : DataModel
    {

        public static LiveMVUnitEditCarouselContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVUnitEditCarouselContext() { Pointer= p0 };


            return value;
        }
    }
}
