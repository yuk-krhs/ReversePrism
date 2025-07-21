using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FriendSupportStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProfileFieldNumber                       int IL2CPP_TYPE_I4
    // 018 Profile                                  ModelClassType ProfileStatus ProfileStatus ProfileStatus Pointer
    // 000 SupportCharacterFieldNumber              int IL2CPP_TYPE_I4
    // 020 SupportCharacter                         ModelClassType SupportCharacterStatus SupportCharacterStatus SupportCharacterStatus Pointer
    // 000 FriendStateFieldNumber                   int IL2CPP_TYPE_I4
    // 028 FriendState                              ModelEnumType FriendState FriendState FriendState Int32
    // 000 FriendSupportCharacterIdFieldNumber      int IL2CPP_TYPE_I4
    // 030 FriendSupportCharacterId                 ModelPrimitiveType string string string String
    public partial class FriendSupportStatus : DataModel
    {
        public ProfileStatus?                           Profile                                 { get; set; }
        public SupportCharacterStatus?                  SupportCharacter                        { get; set; }
        public FriendState                              FriendState                             { get; set; }
        public string                                   FriendSupportCharacterId                { get; set; }

        public static FriendSupportStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FriendSupportStatus() { Pointer= p0 };

            value.Profile                                   = GetObject<ProfileStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProfileStatus.FromPointer); // 0x18 Profile                     ( ModelClassType ProfileStatus ProfileStatus ProfileStatus Pointer )
            value.SupportCharacter                          = GetObject<SupportCharacterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.SupportCharacterStatus.FromPointer); // 0x20 SupportCharacter            ( ModelClassType SupportCharacterStatus SupportCharacterStatus SupportCharacterStatus Pointer )
            value.FriendState                               = (FriendState)GetInt32(new IntPtr(p + 0x028)); // 0x28 FriendState                 ( ModelEnumType FriendState FriendState FriendState Int32 )
            value.FriendSupportCharacterId                  = GetString(new IntPtr(p + 0x030)); // 0x30 FriendSupportCharacterId    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
