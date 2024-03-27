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
    // 018 IsEvent                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 MstEventIdFieldNumber                    int IL2CPP_TYPE_I4
    // 01C MstEventId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 EventPointBaseFieldNumber                int IL2CPP_TYPE_I4
    // 020 EventPointBase                           0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 MedalBaseFieldNumber                     int IL2CPP_TYPE_I4
    // 028 MedalBase                                0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 EventBonusFieldNumber                    int IL2CPP_TYPE_I4
    // 030 EventBonus                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 BeforeTotalEventPointFieldNumber         int IL2CPP_TYPE_I4
    // 038 BeforeTotalEventPoint                    0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 AfterTotalEventPointFieldNumber          int IL2CPP_TYPE_I4
    // 040 AfterTotalEventPoint                     0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 BeforeTotalMedalFieldNumber              int IL2CPP_TYPE_I4
    // 048 BeforeTotalMedal                         0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 AfterTotalMedalFieldNumber               int IL2CPP_TYPE_I4
    // 050 AfterTotalMedal                          0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 NextEventStoryFieldNumber                int IL2CPP_TYPE_I4
    // 058 NextEventStory                           000186760490 ModelClassType EventPointRewardStatus EventPointRewardStatus EventPointRewardStatus Pointer
    // 000 UnlockedEventStoryListFieldNumber        int IL2CPP_TYPE_I4
    // 008 _repeated_unlockedEventStoryList_codec   FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 060 UnlockedEventStoryList                   000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    public partial class LiveEventResultStatus
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

        public static LiveEventResultStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventResultStatus();

            value.IsEvent                                   = GetBool(new IntPtr(p + 0x018)); // 0270D134CA58 0x18 IsEvent                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MstEventId                                = GetInt32(new IntPtr(p + 0x01C)); // 0270D134CA98 0x1C MstEventId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EventPointBase                            = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D134CAD8 0x20 EventPointBase              ( 0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.MedalBase                                 = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D134CB18 0x28 MedalBase                   ( 0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.EventBonus                                = GetInt32(new IntPtr(p + 0x030)); // 0270D134CB58 0x30 EventBonus                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BeforeTotalEventPoint                     = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D134CB98 0x38 BeforeTotalEventPoint       ( 0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.AfterTotalEventPoint                      = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D134CBD8 0x40 AfterTotalEventPoint        ( 0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.BeforeTotalMedal                          = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D134CC18 0x48 BeforeTotalMedal            ( 0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.AfterTotalMedal                           = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D134CC58 0x50 AfterTotalMedal             ( 0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.NextEventStory                            = GetObject<EventPointRewardStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.EventPointRewardStatus.FromPointer); // 0270D134CC98 0x58 NextEventStory              ( 000186760490 ModelClassType EventPointRewardStatus EventPointRewardStatus EventPointRewardStatus Pointer )
            value.UnlockedEventStoryList                    = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D134CCF8 0x60 UnlockedEventStoryList      ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )

            return value;
        }
    }
}
