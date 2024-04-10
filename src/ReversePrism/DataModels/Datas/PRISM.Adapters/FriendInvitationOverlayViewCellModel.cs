using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Mission                                  000186519EF0 ModelClassType IFriendInvitationMissionStatus IFriendInvitationMissionStatus IFriendInvitationMissionStatus Pointer
    public partial class FriendInvitationOverlayViewCellModel : DataModel
    {
        public IFriendInvitationMissionStatus?          Mission                                 { get; set; }

        public static FriendInvitationOverlayViewCellModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FriendInvitationOverlayViewCellModel() { Pointer= p0 };

            value.Mission                                   = GetObject<IFriendInvitationMissionStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFriendInvitationMissionStatus.FromPointer); // 0246663ABD40 0x10 Mission                     ( 000186519EF0 ModelClassType IFriendInvitationMissionStatus IFriendInvitationMissionStatus IFriendInvitationMissionStatus Pointer )

            return value;
        }
    }
}
