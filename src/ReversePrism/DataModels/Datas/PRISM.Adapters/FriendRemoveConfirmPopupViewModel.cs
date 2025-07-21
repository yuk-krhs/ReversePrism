using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UserViewModel                            ModelClassType ProfileFriendUserViewModel ProfileFriendUserViewModel ProfileFriendUserViewModel Pointer
    // 018 PIdolIcon                                ModelClassType PIdolIcon PIdolIcon PIdolIcon Pointer
    // 020 TitleText                                ModelPrimitiveType string string string String
    // 028 MessageText                              ModelPrimitiveType string string string String
    // 030 ButtonKey                                ValueTuple`2<string, int> IL2CPP_TYPE_GENERICINST
    public partial class FriendRemoveConfirmPopupViewModel : DataModel
    {
        public ProfileFriendUserViewModel?              UserViewModel                           { get; set; }
        public PIdolIcon?                               PIdolIcon                               { get; set; }
        public string                                   TitleText                               { get; set; }
        public string                                   MessageText                             { get; set; }

        public static FriendRemoveConfirmPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FriendRemoveConfirmPopupViewModel() { Pointer= p0 };

            value.UserViewModel                             = GetObject<ProfileFriendUserViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProfileFriendUserViewModel.FromPointer); // 0x10 UserViewModel               ( ModelClassType ProfileFriendUserViewModel ProfileFriendUserViewModel ProfileFriendUserViewModel Pointer )
            value.PIdolIcon                                 = GetObject<PIdolIcon>(new IntPtr(p + 0x018), ReversePrism.DataModels.PIdolIcon.FromPointer); // 0x18 PIdolIcon                   ( ModelClassType PIdolIcon PIdolIcon PIdolIcon Pointer )
            value.TitleText                                 = GetString(new IntPtr(p + 0x020)); // 0x20 TitleText                   ( ModelPrimitiveType string string string String )
            value.MessageText                               = GetString(new IntPtr(p + 0x028)); // 0x28 MessageText                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
