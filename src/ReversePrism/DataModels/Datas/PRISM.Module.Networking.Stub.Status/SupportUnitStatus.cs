using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SupportUnitStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 InProduceSupportCharacterListFieldNumber int IL2CPP_TYPE_I4
    // 008 _repeated_inProduceSupportCharacterList_codec FieldCodec`1<InProduceSupportCharacterStatus> IL2CPP_TYPE_GENERICINST
    // 018 InProduceSupportCharacterList            ModelClassListType RepeatedField`1<InProduceSupportCharacterStatus> RepeatedField`1<InProduceSupportCharacterStatus> List<InProduceSupportCharacterStatus> Pointer
    // 000 FriendInProduceSupportCharacterFieldNumber int IL2CPP_TYPE_I4
    // 020 FriendInProduceSupportCharacter          ModelClassType InProduceSupportCharacterStatus InProduceSupportCharacterStatus InProduceSupportCharacterStatus Pointer
    public partial class SupportUnitStatus : DataModel
    {
        public List<InProduceSupportCharacterStatus>?   InProduceSupportCharacterList           { get; set; }
        public InProduceSupportCharacterStatus?         FriendInProduceSupportCharacter         { get; set; }

        public static SupportUnitStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportUnitStatus() { Pointer= p0 };

            value.InProduceSupportCharacterList             = GetObjectList<InProduceSupportCharacterStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.InProduceSupportCharacterStatus.FromPointer); // 0x18 InProduceSupportCharacterList ( ModelClassListType RepeatedField`1<InProduceSupportCharacterStatus> RepeatedField`1<InProduceSupportCharacterStatus> List<InProduceSupportCharacterStatus> Pointer )
            value.FriendInProduceSupportCharacter           = GetObject<InProduceSupportCharacterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.InProduceSupportCharacterStatus.FromPointer); // 0x20 FriendInProduceSupportCharacter ( ModelClassType InProduceSupportCharacterStatus InProduceSupportCharacterStatus InProduceSupportCharacterStatus Pointer )

            return value;
        }
    }
}
