using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelectFavoritePIdolId                    ModelPrimitiveType int int int Int32
    // 018 sortFilterSaveData                       SavableJsonObject`1<IdolListPISortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 020 UserSelfViewModel                        ModelClassType ProfileUserSalfViewModel ProfileUserSalfViewModel ProfileUserSalfViewModel Pointer
    // 028 Canceller                                ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
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

            value.SelectFavoritePIdolId                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 SelectFavoritePIdolId       ( ModelPrimitiveType int int int Int32 )
            value.UserSelfViewModel                         = GetObject<ProfileUserSalfViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfileUserSalfViewModel.FromPointer); // 0x20 UserSelfViewModel           ( ModelClassType ProfileUserSalfViewModel ProfileUserSalfViewModel ProfileUserSalfViewModel Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x028)); // 0x28 Canceller                   ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
