using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MarkFavoriteSupportCharacterReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SupportCharacterFieldNumber              int IL2CPP_TYPE_I4
    // 018 SupportCharacter                         0001865ED2A0 ModelClassType SupportCharacterStatus SupportCharacterStatus SupportCharacterStatus Pointer
    public partial class MarkFavoriteSupportCharacterReply
    {
        public SupportCharacterStatus?                  SupportCharacter                        { get; set; }

        public static MarkFavoriteSupportCharacterReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MarkFavoriteSupportCharacterReply();

            value.SupportCharacter                          = GetObject<SupportCharacterStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.SupportCharacterStatus.FromPointer); // 0270D2AF99E0 0x18 SupportCharacter            ( 0001865ED2A0 ModelClassType SupportCharacterStatus SupportCharacterStatus SupportCharacterStatus Pointer )

            return value;
        }
    }
}
