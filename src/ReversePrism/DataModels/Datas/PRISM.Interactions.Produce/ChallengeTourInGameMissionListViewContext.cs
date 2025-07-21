using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 GetMissionProgress                       Func`2<int, int> IL2CPP_TYPE_GENERICINST
    public partial class ChallengeTourInGameMissionListViewContext : DataModel
    {

        public static ChallengeTourInGameMissionListViewContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourInGameMissionListViewContext() { Pointer= p0 };


            return value;
        }
    }
}
