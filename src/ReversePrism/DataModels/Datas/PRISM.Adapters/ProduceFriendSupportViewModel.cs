using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FriendState                              ModelEnumType FriendState FriendState FriendState Int32
    // 018 onUpdateFriendState                      Subject`1<FriendState> IL2CPP_TYPE_GENERICINST
    // 020 Profile                                  ModelClassType IProfileStatus IProfileStatus IProfileStatus Pointer
    // 028 SupportCharacter                         ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer
    // 030 FriendSupportId                          ModelPrimitiveType string string string String
    public partial class ProduceFriendSupportViewModel : DataModel
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
            var value   = new ProduceFriendSupportViewModel() { Pointer= p0 };

            value.FriendState                               = (FriendState)GetInt32(new IntPtr(p + 0x010)); // 0x10 FriendState                 ( ModelEnumType FriendState FriendState FriendState Int32 )
            value.Profile                                   = GetObject<IProfileStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProfileStatus.FromPointer); // 0x20 Profile                     ( ModelClassType IProfileStatus IProfileStatus IProfileStatus Pointer )
            value.SupportCharacter                          = GetObject<ISupportCharacterStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0x28 SupportCharacter            ( ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer )
            value.FriendSupportId                           = GetString(new IntPtr(p + 0x030)); // 0x30 FriendSupportId             ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
