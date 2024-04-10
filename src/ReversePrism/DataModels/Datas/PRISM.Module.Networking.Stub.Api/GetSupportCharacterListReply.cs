using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetSupportCharacterListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SupportCharacterListFieldNumber          int IL2CPP_TYPE_I4
    // 008 _repeated_supportCharacterList_codec     FieldCodec`1<SupportCharacterStatus> IL2CPP_TYPE_GENERICINST
    // 018 SupportCharacterList                     000185CF42A8 ModelClassListType RepeatedField`1<SupportCharacterStatus> RepeatedField`1<SupportCharacterStatus> List<SupportCharacterStatus> Pointer
    public partial class GetSupportCharacterListReply : DataModel
    {
        public List<SupportCharacterStatus>?            SupportCharacterList                    { get; set; }

        public static GetSupportCharacterListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetSupportCharacterListReply() { Pointer= p0 };

            value.SupportCharacterList                      = GetObjectList<SupportCharacterStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.SupportCharacterStatus.FromPointer); // 024662A605E0 0x18 SupportCharacterList        ( 000185CF42A8 ModelClassListType RepeatedField`1<SupportCharacterStatus> RepeatedField`1<SupportCharacterStatus> List<SupportCharacterStatus> Pointer )

            return value;
        }
    }
}
