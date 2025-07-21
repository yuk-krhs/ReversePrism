using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FinishStoryReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UpdatedStoryListFieldNumber              int IL2CPP_TYPE_I4
    // 008 _repeated_updatedStoryList_codec         FieldCodec`1<StoryStatus> IL2CPP_TYPE_GENERICINST
    // 018 UpdatedStoryList                         ModelClassListType RepeatedField`1<StoryStatus> RepeatedField`1<StoryStatus> List<StoryStatus> Pointer
    // 000 NextStoryIdFieldNumber                   int IL2CPP_TYPE_I4
    // 020 NextStoryId                              ModelClassType StoryIDStatus StoryIDStatus StoryIDStatus Pointer
    // 000 ProductRewardListFieldNumber             int IL2CPP_TYPE_I4
    // 010 _repeated_productRewardList_codec        FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 028 ProductRewardList                        ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 030 HavingGroup                              ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    public partial class FinishStoryReply : DataModel
    {
        public List<StoryStatus>?                       UpdatedStoryList                        { get; set; }
        public StoryIDStatus?                           NextStoryId                             { get; set; }
        public List<ProductWithAmountStatus>?           ProductRewardList                       { get; set; }
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }

        public static FinishStoryReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishStoryReply() { Pointer= p0 };

            value.UpdatedStoryList                          = GetObjectList<StoryStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryStatus.FromPointer); // 0x18 UpdatedStoryList            ( ModelClassListType RepeatedField`1<StoryStatus> RepeatedField`1<StoryStatus> List<StoryStatus> Pointer )
            value.NextStoryId                               = GetObject<StoryIDStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoryIDStatus.FromPointer); // 0x20 NextStoryId                 ( ModelClassType StoryIDStatus StoryIDStatus StoryIDStatus Pointer )
            value.ProductRewardList                         = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x28 ProductRewardList           ( ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0x30 HavingGroup                 ( ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )

            return value;
        }
    }
}
