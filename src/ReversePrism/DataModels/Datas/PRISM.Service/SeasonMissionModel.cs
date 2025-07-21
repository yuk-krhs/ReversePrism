using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SeasonMissionReply                       ModelClassType SeasonMission SeasonMission SeasonMission Pointer
    // 018 SeasonMissionTabIndex                    ModelEnumType SeaasonMissionTab SeaasonMissionTab SeaasonMissionTab Int32
    public partial class SeasonMissionModel : DataModel
    {
        public SeasonMission?                           SeasonMissionReply                      { get; set; }
        public SeaasonMissionTab                        SeasonMissionTabIndex                   { get; set; }

        public static SeasonMissionModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMissionModel() { Pointer= p0 };

            value.SeasonMissionReply                        = GetObject<SeasonMission>(new IntPtr(p + 0x010), ReversePrism.DataModels.SeasonMission.FromPointer); // 0x10 SeasonMissionReply          ( ModelClassType SeasonMission SeasonMission SeasonMission Pointer )
            value.SeasonMissionTabIndex                     = (SeaasonMissionTab)GetInt32(new IntPtr(p + 0x018)); // 0x18 SeasonMissionTabIndex       ( ModelEnumType SeaasonMissionTab SeaasonMissionTab SeaasonMissionTab Int32 )

            return value;
        }
    }
}
