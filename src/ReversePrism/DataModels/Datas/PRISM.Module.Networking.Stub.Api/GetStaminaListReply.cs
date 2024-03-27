using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetStaminaListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StaminaListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_staminaList_codec              FieldCodec`1<StaminaStatus> IL2CPP_TYPE_GENERICINST
    // 018 StaminaList                              000185CF2678 ModelClassListType RepeatedField`1<StaminaStatus> RepeatedField`1<StaminaStatus> List<StaminaStatus> Pointer
    public partial class GetStaminaListReply
    {
        public List<StaminaStatus>?                     StaminaList                             { get; set; }

        public static GetStaminaListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetStaminaListReply();

            value.StaminaList                               = GetObjectList<StaminaStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.StaminaStatus.FromPointer); // 0270D29606B0 0x18 StaminaList                 ( 000185CF2678 ModelClassListType RepeatedField`1<StaminaStatus> RepeatedField`1<StaminaStatus> List<StaminaStatus> Pointer )

            return value;
        }
    }
}
