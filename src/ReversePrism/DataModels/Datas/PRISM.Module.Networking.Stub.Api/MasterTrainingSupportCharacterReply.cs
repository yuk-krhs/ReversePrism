using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MasterTrainingSupportCharacterReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SupportCharacterFieldNumber              int IL2CPP_TYPE_I4
    // 018 SupportCharacter                         ModelClassType SupportCharacterStatus SupportCharacterStatus SupportCharacterStatus Pointer
    // 000 IdolBaseRewardFieldNumber                int IL2CPP_TYPE_I4
    // 020 IdolBaseReward                           ModelClassType IdolBaseRewardStatus IdolBaseRewardStatus IdolBaseRewardStatus Pointer
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 028 HavingGroup                              ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    public partial class MasterTrainingSupportCharacterReply : DataModel
    {
        public SupportCharacterStatus?                  SupportCharacter                        { get; set; }
        public IdolBaseRewardStatus?                    IdolBaseReward                          { get; set; }
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }

        public static MasterTrainingSupportCharacterReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MasterTrainingSupportCharacterReply() { Pointer= p0 };

            value.SupportCharacter                          = GetObject<SupportCharacterStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.SupportCharacterStatus.FromPointer); // 0x18 SupportCharacter            ( ModelClassType SupportCharacterStatus SupportCharacterStatus SupportCharacterStatus Pointer )
            value.IdolBaseReward                            = GetObject<IdolBaseRewardStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolBaseRewardStatus.FromPointer); // 0x20 IdolBaseReward              ( ModelClassType IdolBaseRewardStatus IdolBaseRewardStatus IdolBaseRewardStatus Pointer )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0x28 HavingGroup                 ( ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )

            return value;
        }
    }
}
