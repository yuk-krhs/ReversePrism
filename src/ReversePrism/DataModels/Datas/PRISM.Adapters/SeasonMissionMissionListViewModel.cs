using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SeasonMission                            ModelClassType ISeasonMissionMissionStatus ISeasonMissionMissionStatus ISeasonMissionMissionStatus Pointer
    public partial class SeasonMissionMissionListViewModel : DataModel
    {
        public ISeasonMissionMissionStatus?             SeasonMission                           { get; set; }

        public static SeasonMissionMissionListViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMissionMissionListViewModel() { Pointer= p0 };

            value.SeasonMission                             = GetObject<ISeasonMissionMissionStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.ISeasonMissionMissionStatus.FromPointer); // 0x10 SeasonMission               ( ModelClassType ISeasonMissionMissionStatus ISeasonMissionMissionStatus ISeasonMissionMissionStatus Pointer )

            return value;
        }
    }
}
