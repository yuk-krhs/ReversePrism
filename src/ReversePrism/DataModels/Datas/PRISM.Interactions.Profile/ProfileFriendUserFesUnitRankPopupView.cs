using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ListView                                 ModelClassType ProfileFriendUserFesUnitRankListView ProfileFriendUserFesUnitRankListView ProfileFriendUserFesUnitRankListView Pointer
    // 028 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 ViewModel                                ModelClassType ProfileFriendUserViewModel ProfileFriendUserViewModel ProfileFriendUserViewModel Pointer
    // 038 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProfileFriendUserFesUnitRankPopupView : DataModel
    {
        public ProfileFriendUserFesUnitRankListView?    ListView                                { get; set; }
        public ProfileFriendUserViewModel?              ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProfileFriendUserFesUnitRankPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileFriendUserFesUnitRankPopupView() { Pointer= p0 };

            value.ListView                                  = GetObject<ProfileFriendUserFesUnitRankListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfileFriendUserFesUnitRankListView.FromPointer); // 0x20 ListView                    ( ModelClassType ProfileFriendUserFesUnitRankListView ProfileFriendUserFesUnitRankListView ProfileFriendUserFesUnitRankListView Pointer )
            value.ViewModel                                 = GetObject<ProfileFriendUserViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProfileFriendUserViewModel.FromPointer); // 0x30 ViewModel                   ( ModelClassType ProfileFriendUserViewModel ProfileFriendUserViewModel ProfileFriendUserViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x38 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
