using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 factory                                  IPopupViewFactory`1<IProfilePIdolSelectPopupView> IL2CPP_TYPE_GENERICINST
    // 018 SelectFavoritePIdolId                    0001865F4260 ModelPrimitiveType int int int Int32
    // 020 sortFilterSaveData                       SavableJsonObject`1<IdolListPISortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 028 UserSelfViewModel                        0001865C6380 ModelClassType ProfileUserSalfViewModel ProfileUserSalfViewModel ProfileUserSalfViewModel Pointer
    // 030 Canceller                                000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class ProfilePIdolSelectPopupSequencer : DataModel
    {
        public int                                      SelectFavoritePIdolId                   { get; set; }
        public ProfileUserSalfViewModel?                UserSelfViewModel                       { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }

        public static ProfilePIdolSelectPopupSequencer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfilePIdolSelectPopupSequencer() { Pointer= p0 };

            value.SelectFavoritePIdolId                     = GetInt32(new IntPtr(p + 0x018)); // 0246666FD048 0x18 SelectFavoritePIdolId       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.UserSelfViewModel                         = GetObject<ProfileUserSalfViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProfileUserSalfViewModel.FromPointer); // 0246666FD088 0x28 UserSelfViewModel           ( 0001865C6380 ModelClassType ProfileUserSalfViewModel ProfileUserSalfViewModel ProfileUserSalfViewModel Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x030)); // 0246666FD0A8 0x30 Canceller                   ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
