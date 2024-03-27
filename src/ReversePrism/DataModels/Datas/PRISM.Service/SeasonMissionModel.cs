using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SeasonMissionReply                       000186700550 ModelClassType SeasonMission SeasonMission SeasonMission Pointer
    // 018 SeasonMissionTabIndex                    0001867426B0 ModelEnumType SeaasonMissionTab SeaasonMissionTab SeaasonMissionTab Int32
    public partial class SeasonMissionModel
    {
        public SeasonMission?                           SeasonMissionReply                      { get; set; }
        public SeaasonMissionTab                        SeasonMissionTabIndex                   { get; set; }

        public static SeasonMissionModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMissionModel();

            value.SeasonMissionReply                        = GetObject<SeasonMission>(new IntPtr(p + 0x010), ReversePrism.DataModels.SeasonMission.FromPointer); // 0270D66DDCD0 0x10 SeasonMissionReply          ( 000186700550 ModelClassType SeasonMission SeasonMission SeasonMission Pointer )
            value.SeasonMissionTabIndex                     = (SeaasonMissionTab)GetInt32(new IntPtr(p + 0x018)); // 0270D66DDCF0 0x18 SeasonMissionTabIndex       ( 0001867426B0 ModelEnumType SeaasonMissionTab SeaasonMissionTab SeaasonMissionTab Int32 )

            return value;
        }
    }
}
