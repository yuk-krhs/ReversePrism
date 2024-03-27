using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<StartTutorialReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceIdolListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_produceIdolList_codec          FieldCodec`1<ProduceIdolStatus> IL2CPP_TYPE_GENERICINST
    // 018 ProduceIdolList                          000185CEBD88 ModelClassListType RepeatedField`1<ProduceIdolStatus> RepeatedField`1<ProduceIdolStatus> List<ProduceIdolStatus> Pointer
    // 000 FesIdolListFieldNumber                   int IL2CPP_TYPE_I4
    // 010 _repeated_fesIdolList_codec              FieldCodec`1<FesIdolStatus> IL2CPP_TYPE_GENERICINST
    // 020 FesIdolList                              000185CD7D58 ModelClassListType RepeatedField`1<FesIdolStatus> RepeatedField`1<FesIdolStatus> List<FesIdolStatus> Pointer
    public partial class StartTutorialReply
    {
        public List<ProduceIdolStatus>?                 ProduceIdolList                         { get; set; }
        public List<FesIdolStatus>?                     FesIdolList                             { get; set; }

        public static StartTutorialReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartTutorialReply();

            value.ProduceIdolList                           = GetObjectList<ProduceIdolStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceIdolStatus.FromPointer); // 0270D2C592B0 0x18 ProduceIdolList             ( 000185CEBD88 ModelClassListType RepeatedField`1<ProduceIdolStatus> RepeatedField`1<ProduceIdolStatus> List<ProduceIdolStatus> Pointer )
            value.FesIdolList                               = GetObjectList<FesIdolStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.FesIdolStatus.FromPointer); // 0270D2C59310 0x20 FesIdolList                 ( 000185CD7D58 ModelClassListType RepeatedField`1<FesIdolStatus> RepeatedField`1<FesIdolStatus> List<FesIdolStatus> Pointer )

            return value;
        }
    }
}
