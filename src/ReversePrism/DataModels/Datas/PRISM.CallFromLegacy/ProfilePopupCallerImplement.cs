using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FriendUserCaller                         0001865B75C0 ModelClassType ProfileFriendUserProfilePopupCaller ProfileFriendUserProfilePopupCaller ProfileFriendUserProfilePopupCaller Pointer
    // 028 profileOverlayFactory                    OverlayViewFactory`1<IProfileUserSelfOverlayView> IL2CPP_TYPE_GENERICINST
    public partial class ProfilePopupCallerImplement : DataModel
    {
        public ProfileFriendUserProfilePopupCaller?     FriendUserCaller                        { get; set; }

        public static ProfilePopupCallerImplement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfilePopupCallerImplement() { Pointer= p0 };

            value.FriendUserCaller                          = GetObject<ProfileFriendUserProfilePopupCaller>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfileFriendUserProfilePopupCaller.FromPointer); // 02466BA6ADA8 0x20 FriendUserCaller            ( 0001865B75C0 ModelClassType ProfileFriendUserProfilePopupCaller ProfileFriendUserProfilePopupCaller ProfileFriendUserProfilePopupCaller Pointer )

            return value;
        }
    }
}
