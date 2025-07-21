using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReceiveEndDate                           ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 020 GroupType                                ModelEnumType MissionGroupType MissionGroupType MissionGroupType Int32
    // 024 HasReceiveMissionListReward              ModelPrimitiveType bool bool bool Bool
    public partial class MissionRewardReceiveStatusViewModel : DataModel
    {
        public DateTime                                 ReceiveEndDate                          { get; set; }
        public MissionGroupType                         GroupType                               { get; set; }
        public bool                                     HasReceiveMissionListReward             { get; set; }

        public static MissionRewardReceiveStatusViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionRewardReceiveStatusViewModel() { Pointer= p0 };

            value.ReceiveEndDate                            = GetDateTime(new IntPtr(p + 0x010)); // 0x10 ReceiveEndDate              ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.GroupType                                 = (MissionGroupType)GetInt32(new IntPtr(p + 0x020)); // 0x20 GroupType                   ( ModelEnumType MissionGroupType MissionGroupType MissionGroupType Int32 )
            value.HasReceiveMissionListReward               = GetBool(new IntPtr(p + 0x024)); // 0x24 HasReceiveMissionListReward ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
