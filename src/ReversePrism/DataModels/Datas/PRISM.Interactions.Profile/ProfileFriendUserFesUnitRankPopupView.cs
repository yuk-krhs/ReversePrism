using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ListView                                 0001865B5320 ModelClassType ProfileFriendUserFesUnitRankListView ProfileFriendUserFesUnitRankListView ProfileFriendUserFesUnitRankListView Pointer
    // 028 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 ViewModel                                0001865B9A40 ModelClassType ProfileFriendUserViewModel ProfileFriendUserViewModel ProfileFriendUserViewModel Pointer
    // 038 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProfileFriendUserFesUnitRankPopupView
    {
        public ProfileFriendUserFesUnitRankListView?    ListView                                { get; set; }
        public ProfileFriendUserViewModel?              ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProfileFriendUserFesUnitRankPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileFriendUserFesUnitRankPopupView();

            value.ListView                                  = GetObject<ProfileFriendUserFesUnitRankListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfileFriendUserFesUnitRankListView.FromPointer); // 0270DB734968 0x20 ListView                    ( 0001865B5320 ModelClassType ProfileFriendUserFesUnitRankListView ProfileFriendUserFesUnitRankListView ProfileFriendUserFesUnitRankListView Pointer )
            value.ViewModel                                 = GetObject<ProfileFriendUserViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProfileFriendUserViewModel.FromPointer); // 0270DB7349A8 0x30 ViewModel                   ( 0001865B9A40 ModelClassType ProfileFriendUserViewModel ProfileFriendUserViewModel ProfileFriendUserViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB7349C8 0x38 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
