using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetGashaMemberReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SupportCharacterListFieldNumber          int IL2CPP_TYPE_I4
    // 008 _repeated_supportCharacterList_codec     FieldCodec`1<MaximumSupportCharacterStatus> IL2CPP_TYPE_GENERICINST
    // 018 SupportCharacterList                     000185CE5748 ModelClassListType RepeatedField`1<MaximumSupportCharacterStatus> RepeatedField`1<MaximumSupportCharacterStatus> List<MaximumSupportCharacterStatus> Pointer
    // 000 ProduceIdolListFieldNumber               int IL2CPP_TYPE_I4
    // 010 _repeated_produceIdolList_codec          FieldCodec`1<MaximumProduceIdolStatus> IL2CPP_TYPE_GENERICINST
    // 020 ProduceIdolList                          000185CE5508 ModelClassListType RepeatedField`1<MaximumProduceIdolStatus> RepeatedField`1<MaximumProduceIdolStatus> List<MaximumProduceIdolStatus> Pointer
    public partial class GetGashaMemberReply : DataModel
    {
        public List<MaximumSupportCharacterStatus>?     SupportCharacterList                    { get; set; }
        public List<MaximumProduceIdolStatus>?          ProduceIdolList                         { get; set; }

        public static GetGashaMemberReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetGashaMemberReply() { Pointer= p0 };

            value.SupportCharacterList                      = GetObjectList<MaximumSupportCharacterStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.MaximumSupportCharacterStatus.FromPointer); // 0246619A09A0 0x18 SupportCharacterList        ( 000185CE5748 ModelClassListType RepeatedField`1<MaximumSupportCharacterStatus> RepeatedField`1<MaximumSupportCharacterStatus> List<MaximumSupportCharacterStatus> Pointer )
            value.ProduceIdolList                           = GetObjectList<MaximumProduceIdolStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.MaximumProduceIdolStatus.FromPointer); // 0246619A0A00 0x20 ProduceIdolList             ( 000185CE5508 ModelClassListType RepeatedField`1<MaximumProduceIdolStatus> RepeatedField`1<MaximumProduceIdolStatus> List<MaximumProduceIdolStatus> Pointer )

            return value;
        }
    }
}
