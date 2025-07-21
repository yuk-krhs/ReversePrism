using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LiveEventResultStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IsEventFieldNumber                       int IL2CPP_TYPE_I4
    // 018 IsEvent                                  ModelPrimitiveType bool bool bool Bool
    // 000 MstEventIdFieldNumber                    int IL2CPP_TYPE_I4
    // 01C MstEventId                               ModelPrimitiveType int int int Int32
    // 000 EventPointBaseFieldNumber                int IL2CPP_TYPE_I4
    // 020 EventPointBase                           ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 MedalBaseFieldNumber                     int IL2CPP_TYPE_I4
    // 028 MedalBase                                ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 EventBonusFieldNumber                    int IL2CPP_TYPE_I4
    // 030 EventBonus                               ModelPrimitiveType int int int Int32
    // 000 BeforeTotalEventPointFieldNumber         int IL2CPP_TYPE_I4
    // 038 BeforeTotalEventPoint                    ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 AfterTotalEventPointFieldNumber          int IL2CPP_TYPE_I4
    // 040 AfterTotalEventPoint                     ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 BeforeTotalMedalFieldNumber              int IL2CPP_TYPE_I4
    // 048 BeforeTotalMedal                         ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 AfterTotalMedalFieldNumber               int IL2CPP_TYPE_I4
    // 050 AfterTotalMedal                          ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 NextEventStoryFieldNumber                int IL2CPP_TYPE_I4
    // 058 NextEventStory                           ModelClassType EventPointRewardStatus EventPointRewardStatus EventPointRewardStatus Pointer
    // 000 UnlockedEventStoryListFieldNumber        int IL2CPP_TYPE_I4
    // 008 _repeated_unlockedEventStoryList_codec   FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 060 UnlockedEventStoryList                   ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 IdolResultListFieldNumber                int IL2CPP_TYPE_I4
    // 010 _repeated_idolResultList_codec           FieldCodec`1<LiveEventIdolResultStatus> IL2CPP_TYPE_GENERICINST
    // 068 IdolResultList                           ModelClassListType RepeatedField`1<LiveEventIdolResultStatus> RepeatedField`1<LiveEventIdolResultStatus> List<LiveEventIdolResultStatus> Pointer
    public partial class LiveEventResultStatus : DataModel
    {
        public bool                                     IsEvent                                 { get; set; }
        public int                                      MstEventId                              { get; set; }
        public ProductWithAmountStatus?                 EventPointBase                          { get; set; }
        public ProductWithAmountStatus?                 MedalBase                               { get; set; }
        public int                                      EventBonus                              { get; set; }
        public ProductWithAmountStatus?                 BeforeTotalEventPoint                   { get; set; }
        public ProductWithAmountStatus?                 AfterTotalEventPoint                    { get; set; }
        public ProductWithAmountStatus?                 BeforeTotalMedal                        { get; set; }
        public ProductWithAmountStatus?                 AfterTotalMedal                         { get; set; }
        public EventPointRewardStatus?                  NextEventStory                          { get; set; }
        public List<ProductWithAmountStatus>?           UnlockedEventStoryList                  { get; set; }
        public List<LiveEventIdolResultStatus>?         IdolResultList                          { get; set; }

        public static LiveEventResultStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventResultStatus() { Pointer= p0 };

            value.IsEvent                                   = GetBool(new IntPtr(p + 0x018)); // 0x18 IsEvent                     ( ModelPrimitiveType bool bool bool Bool )
            value.MstEventId                                = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstEventId                  ( ModelPrimitiveType int int int Int32 )
            value.EventPointBase                            = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x20 EventPointBase              ( ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.MedalBase                                 = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x28 MedalBase                   ( ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.EventBonus                                = GetInt32(new IntPtr(p + 0x030)); // 0x30 EventBonus                  ( ModelPrimitiveType int int int Int32 )
            value.BeforeTotalEventPoint                     = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x38 BeforeTotalEventPoint       ( ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.AfterTotalEventPoint                      = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x40 AfterTotalEventPoint        ( ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.BeforeTotalMedal                          = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x48 BeforeTotalMedal            ( ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.AfterTotalMedal                           = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x50 AfterTotalMedal             ( ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.NextEventStory                            = GetObject<EventPointRewardStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.EventPointRewardStatus.FromPointer); // 0x58 NextEventStory              ( ModelClassType EventPointRewardStatus EventPointRewardStatus EventPointRewardStatus Pointer )
            value.UnlockedEventStoryList                    = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x60 UnlockedEventStoryList      ( ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.IdolResultList                            = GetObjectList<LiveEventIdolResultStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.LiveEventIdolResultStatus.FromPointer); // 0x68 IdolResultList              ( ModelClassListType RepeatedField`1<LiveEventIdolResultStatus> RepeatedField`1<LiveEventIdolResultStatus> List<LiveEventIdolResultStatus> Pointer )

            return value;
        }
    }
}
