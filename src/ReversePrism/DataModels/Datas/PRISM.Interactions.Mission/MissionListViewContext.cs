using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 <OnClickMission>k__BackingField          Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 048 <OnClickGaugePointDetail>k__BackingField Subject`1<ValueTuple`2<int, int>> IL2CPP_TYPE_GENERICINST
    public partial class MissionListViewContext : DataModel
    {

        public static MissionListViewContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionListViewContext() { Pointer= p0 };


            return value;
        }
    }
}
