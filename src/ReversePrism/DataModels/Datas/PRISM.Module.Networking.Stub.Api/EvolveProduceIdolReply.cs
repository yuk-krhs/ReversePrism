using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<EvolveProduceIdolReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceIdolFieldNumber                   int IL2CPP_TYPE_I4
    // 018 ProduceIdol                              000186550070 ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer
    // 000 IdolBaseRewardFieldNumber                int IL2CPP_TYPE_I4
    // 020 IdolBaseReward                           0001866ACBC0 ModelClassType IdolBaseRewardStatus IdolBaseRewardStatus IdolBaseRewardStatus Pointer
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 028 HavingGroup                              0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    public partial class EvolveProduceIdolReply
    {
        public ProduceIdolStatus?                       ProduceIdol                             { get; set; }
        public IdolBaseRewardStatus?                    IdolBaseReward                          { get; set; }
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }

        public static EvolveProduceIdolReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EvolveProduceIdolReply();

            value.ProduceIdol                               = GetObject<ProduceIdolStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceIdolStatus.FromPointer); // 0270D25F3978 0x18 ProduceIdol                 ( 000186550070 ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer )
            value.IdolBaseReward                            = GetObject<IdolBaseRewardStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolBaseRewardStatus.FromPointer); // 0270D25F39B8 0x20 IdolBaseReward              ( 0001866ACBC0 ModelClassType IdolBaseRewardStatus IdolBaseRewardStatus IdolBaseRewardStatus Pointer )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0270D25F39F8 0x28 HavingGroup                 ( 0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )

            return value;
        }
    }
}
