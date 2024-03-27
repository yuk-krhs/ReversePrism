using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 onButtonClickedSubject                   Subject`1<SeasonMissionMissionListViewModel> IL2CPP_TYPE_GENERICINST
    public partial class SeasonMissionMissionListContext
    {

        public static SeasonMissionMissionListContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMissionMissionListContext();


            return value;
        }
    }
}
