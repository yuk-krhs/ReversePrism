using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FriendState                              0001865F4E60 ModelEnumType FriendState FriendState FriendState Int32
    // 018 onUpdateFriendState                      Subject`1<FriendState> IL2CPP_TYPE_GENERICINST
    // 020 Profile                                  0001865FF0D0 ModelClassType IProfileStatus IProfileStatus IProfileStatus Pointer
    // 028 SupportCharacter                         00018666A070 ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer
    // 030 FriendSupportId                          000186672F10 ModelPrimitiveType string string string String
    public partial class ProduceFriendSupportViewModel
    {
        public FriendState                              FriendState                             { get; set; }
        public IProfileStatus?                          Profile                                 { get; set; }
        public ISupportCharacterStatus?                 SupportCharacter                        { get; set; }
        public string                                   FriendSupportId                         { get; set; }

        public static ProduceFriendSupportViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceFriendSupportViewModel();

            value.FriendState                               = (FriendState)GetInt32(new IntPtr(p + 0x010)); // 0270D64D1D00 0x10 FriendState                 ( 0001865F4E60 ModelEnumType FriendState FriendState FriendState Int32 )
            value.Profile                                   = GetObject<IProfileStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProfileStatus.FromPointer); // 0270D64D1D40 0x20 Profile                     ( 0001865FF0D0 ModelClassType IProfileStatus IProfileStatus IProfileStatus Pointer )
            value.SupportCharacter                          = GetObject<ISupportCharacterStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0270D64D1D60 0x28 SupportCharacter            ( 00018666A070 ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer )
            value.FriendSupportId                           = GetString(new IntPtr(p + 0x030)); // 0270D64D1D80 0x30 FriendSupportId             ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
