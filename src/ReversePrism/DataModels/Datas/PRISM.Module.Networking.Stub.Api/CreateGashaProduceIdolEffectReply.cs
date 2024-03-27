using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<CreateGashaProduceIdolEffectReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 DrawProductListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_drawProductList_codec          FieldCodec`1<GashaRewardProductStatus> IL2CPP_TYPE_GENERICINST
    // 018 DrawProductList                          000185CDD198 ModelClassListType RepeatedField`1<GashaRewardProductStatus> RepeatedField`1<GashaRewardProductStatus> List<GashaRewardProductStatus> Pointer
    // 000 ProduceIdolEffectFieldNumber             int IL2CPP_TYPE_I4
    // 020 ProduceIdolEffect                        00018661CBC0 ModelClassType GashaStageEffectStatus GashaStageEffectStatus GashaStageEffectStatus Pointer
    public partial class CreateGashaProduceIdolEffectReply
    {
        public List<GashaRewardProductStatus>?          DrawProductList                         { get; set; }
        public GashaStageEffectStatus?                  ProduceIdolEffect                       { get; set; }

        public static CreateGashaProduceIdolEffectReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CreateGashaProduceIdolEffectReply();

            value.DrawProductList                           = GetObjectList<GashaRewardProductStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.GashaRewardProductStatus.FromPointer); // 0270D1A07DE8 0x18 DrawProductList             ( 000185CDD198 ModelClassListType RepeatedField`1<GashaRewardProductStatus> RepeatedField`1<GashaRewardProductStatus> List<GashaRewardProductStatus> Pointer )
            value.ProduceIdolEffect                         = GetObject<GashaStageEffectStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaStageEffectStatus.FromPointer); // 0270D1A07E28 0x20 ProduceIdolEffect           ( 00018661CBC0 ModelClassType GashaStageEffectStatus GashaStageEffectStatus GashaStageEffectStatus Pointer )

            return value;
        }
    }
}
