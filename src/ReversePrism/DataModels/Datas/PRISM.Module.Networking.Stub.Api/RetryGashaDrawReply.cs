using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<RetryGashaDrawReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 DrawProductListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_drawProductList_codec          FieldCodec`1<GashaRewardProductStatus> IL2CPP_TYPE_GENERICINST
    // 018 DrawProductList                          ModelClassListType RepeatedField`1<GashaRewardProductStatus> RepeatedField`1<GashaRewardProductStatus> List<GashaRewardProductStatus> Pointer
    // 000 EffectFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Effect                                   ModelClassType GashaEffectStatus GashaEffectStatus GashaEffectStatus Pointer
    public partial class RetryGashaDrawReply : DataModel
    {
        public List<GashaRewardProductStatus>?          DrawProductList                         { get; set; }
        public GashaEffectStatus?                       Effect                                  { get; set; }

        public static RetryGashaDrawReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RetryGashaDrawReply() { Pointer= p0 };

            value.DrawProductList                           = GetObjectList<GashaRewardProductStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.GashaRewardProductStatus.FromPointer); // 0x18 DrawProductList             ( ModelClassListType RepeatedField`1<GashaRewardProductStatus> RepeatedField`1<GashaRewardProductStatus> List<GashaRewardProductStatus> Pointer )
            value.Effect                                    = GetObject<GashaEffectStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaEffectStatus.FromPointer); // 0x20 Effect                      ( ModelClassType GashaEffectStatus GashaEffectStatus GashaEffectStatus Pointer )

            return value;
        }
    }
}
