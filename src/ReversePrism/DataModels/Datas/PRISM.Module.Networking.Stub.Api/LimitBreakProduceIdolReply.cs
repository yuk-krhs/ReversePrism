using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LimitBreakProduceIdolReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceIdolFieldNumber                   int IL2CPP_TYPE_I4
    // 018 ProduceIdol                              ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer
    // 000 CostumeListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_costumeList_codec              FieldCodec`1<CostumeStatus> IL2CPP_TYPE_GENERICINST
    // 020 CostumeList                              ModelClassListType RepeatedField`1<CostumeStatus> RepeatedField`1<CostumeStatus> List<CostumeStatus> Pointer
    // 000 HairstyleListFieldNumber                 int IL2CPP_TYPE_I4
    // 010 _repeated_hairstyleList_codec            FieldCodec`1<HairstyleStatus> IL2CPP_TYPE_GENERICINST
    // 028 HairstyleList                            ModelClassListType RepeatedField`1<HairstyleStatus> RepeatedField`1<HairstyleStatus> List<HairstyleStatus> Pointer
    // 000 AccessoryListFieldNumber                 int IL2CPP_TYPE_I4
    // 018 _repeated_accessoryList_codec            FieldCodec`1<AccessoryStatus> IL2CPP_TYPE_GENERICINST
    // 030 AccessoryList                            ModelClassListType RepeatedField`1<AccessoryStatus> RepeatedField`1<AccessoryStatus> List<AccessoryStatus> Pointer
    // 000 IdolBaseRewardFieldNumber                int IL2CPP_TYPE_I4
    // 038 IdolBaseReward                           ModelClassType IdolBaseRewardStatus IdolBaseRewardStatus IdolBaseRewardStatus Pointer
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 040 HavingGroup                              ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    public partial class LimitBreakProduceIdolReply : DataModel
    {
        public ProduceIdolStatus?                       ProduceIdol                             { get; set; }
        public List<CostumeStatus>?                     CostumeList                             { get; set; }
        public List<HairstyleStatus>?                   HairstyleList                           { get; set; }
        public List<AccessoryStatus>?                   AccessoryList                           { get; set; }
        public IdolBaseRewardStatus?                    IdolBaseReward                          { get; set; }
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }

        public static LimitBreakProduceIdolReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LimitBreakProduceIdolReply() { Pointer= p0 };

            value.ProduceIdol                               = GetObject<ProduceIdolStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceIdolStatus.FromPointer); // 0x18 ProduceIdol                 ( ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer )
            value.CostumeList                               = GetObjectList<CostumeStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.CostumeStatus.FromPointer); // 0x20 CostumeList                 ( ModelClassListType RepeatedField`1<CostumeStatus> RepeatedField`1<CostumeStatus> List<CostumeStatus> Pointer )
            value.HairstyleList                             = GetObjectList<HairstyleStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.HairstyleStatus.FromPointer); // 0x28 HairstyleList               ( ModelClassListType RepeatedField`1<HairstyleStatus> RepeatedField`1<HairstyleStatus> List<HairstyleStatus> Pointer )
            value.AccessoryList                             = GetObjectList<AccessoryStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.AccessoryStatus.FromPointer); // 0x30 AccessoryList               ( ModelClassListType RepeatedField`1<AccessoryStatus> RepeatedField`1<AccessoryStatus> List<AccessoryStatus> Pointer )
            value.IdolBaseReward                            = GetObject<IdolBaseRewardStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IdolBaseRewardStatus.FromPointer); // 0x38 IdolBaseReward              ( ModelClassType IdolBaseRewardStatus IdolBaseRewardStatus IdolBaseRewardStatus Pointer )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0x40 HavingGroup                 ( ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )

            return value;
        }
    }
}
