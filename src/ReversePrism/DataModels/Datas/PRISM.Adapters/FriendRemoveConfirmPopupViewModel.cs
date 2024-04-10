using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UserViewModel                            0001865B9F20 ModelClassType ProfileFriendUserViewModel ProfileFriendUserViewModel ProfileFriendUserViewModel Pointer
    // 018 PIdolIcon                                00018670CB20 ModelClassType PIdolIcon PIdolIcon PIdolIcon Pointer
    // 020 TitleText                                0001866736C0 ModelPrimitiveType string string string String
    // 028 MessageText                              0001866736C0 ModelPrimitiveType string string string String
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

            value.UserViewModel                             = GetObject<ProfileFriendUserViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProfileFriendUserViewModel.FromPointer); // 0246663A1C68 0x10 UserViewModel               ( 0001865B9F20 ModelClassType ProfileFriendUserViewModel ProfileFriendUserViewModel ProfileFriendUserViewModel Pointer )
            value.PIdolIcon                                 = GetObject<PIdolIcon>(new IntPtr(p + 0x018), ReversePrism.DataModels.PIdolIcon.FromPointer); // 0246663A1C88 0x18 PIdolIcon                   ( 00018670CB20 ModelClassType PIdolIcon PIdolIcon PIdolIcon Pointer )
            value.TitleText                                 = GetString(new IntPtr(p + 0x020)); // 0246663A1CA8 0x20 TitleText                   ( 0001866736C0 ModelPrimitiveType string string string String )
            value.MessageText                               = GetString(new IntPtr(p + 0x028)); // 0246663A1CC8 0x28 MessageText                 ( 0001866736C0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
