using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Status                                   0001865FE2D0 ModelClassType IProfileSeasonStatus IProfileSeasonStatus IProfileSeasonStatus Pointer
    // 018 StartDateTimeText                        000186671910 ModelPrimitiveType string string string String
    // 020 EndDateTimeText                          000186671910 ModelPrimitiveType string string string String
    // 028 Master                                   00018662AAB0 ModelClassType MstSeasonMission MstSeasonMission MstSeasonMission Pointer
    public partial class ProfileSeasonArchiveViewModel
    {
        public IProfileSeasonStatus?                    Status                                  { get; set; }
        public string                                   StartDateTimeText                       { get; set; }
        public string                                   EndDateTimeText                         { get; set; }
        public MstSeasonMission?                        Master                                  { get; set; }

        public static ProfileSeasonArchiveViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileSeasonArchiveViewModel();

            value.Status                                    = GetObject<IProfileSeasonStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProfileSeasonStatus.FromPointer); // 0270D666BA88 0x10 Status                      ( 0001865FE2D0 ModelClassType IProfileSeasonStatus IProfileSeasonStatus IProfileSeasonStatus Pointer )
            value.StartDateTimeText                         = GetString(new IntPtr(p + 0x018)); // 0270D666BAA8 0x18 StartDateTimeText           ( 000186671910 ModelPrimitiveType string string string String )
            value.EndDateTimeText                           = GetString(new IntPtr(p + 0x020)); // 0270D666BAC8 0x20 EndDateTimeText             ( 000186671910 ModelPrimitiveType string string string String )
            value.Master                                    = GetObject<MstSeasonMission>(new IntPtr(p + 0x028), ReversePrism.DataModels.MstSeasonMission.FromPointer); // 0270D666BAE8 0x28 Master                      ( 00018662AAB0 ModelClassType MstSeasonMission MstSeasonMission MstSeasonMission Pointer )

            return value;
        }
    }
}
