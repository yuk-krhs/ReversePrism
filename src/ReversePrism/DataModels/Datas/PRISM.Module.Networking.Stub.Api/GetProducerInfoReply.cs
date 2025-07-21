using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FirstWorkedDay                           ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<GetProducerInfoReply> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TotalHighScoreRatingFieldNumber          int IL2CPP_TYPE_I4
    // 028 TotalHighScoreRating                     ModelClassType TotalHighScoreRatingStatus TotalHighScoreRatingStatus TotalHighScoreRatingStatus Pointer
    // 000 TotalTechnicalRatingFieldNumber          int IL2CPP_TYPE_I4
    // 030 TotalTechnicalRating                     ModelClassType TotalTechnicalRatingStatus TotalTechnicalRatingStatus TotalTechnicalRatingStatus Pointer
    // 000 LiveFinishListFieldNumber                int IL2CPP_TYPE_I4
    // 008 _repeated_liveFinishList_codec           FieldCodec`1<UserProfileLiveStatus> IL2CPP_TYPE_GENERICINST
    // 038 LiveFinishList                           ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer
    // 000 LiveFullComboListFieldNumber             int IL2CPP_TYPE_I4
    // 010 _repeated_liveFullComboList_codec        FieldCodec`1<UserProfileLiveStatus> IL2CPP_TYPE_GENERICINST
    // 040 LiveFullComboList                        ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer
    // 000 LiveAllGreatListFieldNumber              int IL2CPP_TYPE_I4
    // 018 _repeated_liveAllGreatList_codec         FieldCodec`1<UserProfileLiveStatus> IL2CPP_TYPE_GENERICINST
    // 048 LiveAllGreatList                         ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer
    // 000 LiveAllPerfectListFieldNumber            int IL2CPP_TYPE_I4
    // 020 _repeated_liveAllPerfectList_codec       FieldCodec`1<UserProfileLiveStatus> IL2CPP_TYPE_GENERICINST
    // 050 LiveAllPerfectList                       ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer
    // 000 BestProduceParameterRankFieldNumber      int IL2CPP_TYPE_I4
    // 058 BestProduceParameterRank                 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 000 ProduceScenarioFinishListFieldNumber     int IL2CPP_TYPE_I4
    // 028 _repeated_produceScenarioFinishList_codec FieldCodec`1<UserProfileProduceStatus> IL2CPP_TYPE_GENERICINST
    // 060 ProduceScenarioFinishList                ModelClassListType RepeatedField`1<UserProfileProduceStatus> RepeatedField`1<UserProfileProduceStatus> List<UserProfileProduceStatus> Pointer
    // 000 WorkedNumberFieldNumber                  int IL2CPP_TYPE_I4
    // 068 WorkedNumber                             ModelPrimitiveType int int int Int32
    // 000 FirstWorkedDayFieldNumber                int IL2CPP_TYPE_I4
    // 070 _FirstWorkedDay                          ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 ProducedIdolNumberFieldNumber            int IL2CPP_TYPE_I4
    // 078 ProducedIdolNumber                       ModelPrimitiveType int int int Int32
    // 000 EvolveNumberFieldNumber                  int IL2CPP_TYPE_I4
    // 07C EvolveNumber                             ModelPrimitiveType int int int Int32
    // 000 LimitBreakNumberFieldNumber              int IL2CPP_TYPE_I4
    // 080 LimitBreakNumber                         ModelPrimitiveType int int int Int32
    // 000 CostumeNumberFieldNumber                 int IL2CPP_TYPE_I4
    // 084 CostumeNumber                            ModelPrimitiveType int int int Int32
    // 000 SupportCharacterNumberFieldNumber        int IL2CPP_TYPE_I4
    // 088 SupportCharacterNumber                   ModelPrimitiveType int int int Int32
    // 000 MasterTrainingNumberFieldNumber          int IL2CPP_TYPE_I4
    // 08C MasterTrainingNumber                     ModelPrimitiveType int int int Int32
    // 000 TotalFanNumberFieldNumber                int IL2CPP_TYPE_I4
    // 090 TotalFanNumber                           ModelPrimitiveType long long long Int64
    // 000 StoryReadNumberListFieldNumber           int IL2CPP_TYPE_I4
    // 030 _repeated_storyReadNumberList_codec      FieldCodec`1<UserProfileStoryStatus> IL2CPP_TYPE_GENERICINST
    // 098 StoryReadNumberList                      ModelClassListType RepeatedField`1<UserProfileStoryStatus> RepeatedField`1<UserProfileStoryStatus> List<UserProfileStoryStatus> Pointer
    // 000 TotalLiveFinishListFieldNumber           int IL2CPP_TYPE_I4
    // 038 _repeated_totalLiveFinishList_codec      FieldCodec`1<UserProfileLiveStatus> IL2CPP_TYPE_GENERICINST
    // 0A0 TotalLiveFinishList                      ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer
    // 000 TotalLiveFullComboListFieldNumber        int IL2CPP_TYPE_I4
    // 040 _repeated_totalLiveFullComboList_codec   FieldCodec`1<UserProfileLiveStatus> IL2CPP_TYPE_GENERICINST
    // 0A8 TotalLiveFullComboList                   ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer
    // 000 TotalLiveAllGreatListFieldNumber         int IL2CPP_TYPE_I4
    // 048 _repeated_totalLiveAllGreatList_codec    FieldCodec`1<UserProfileLiveStatus> IL2CPP_TYPE_GENERICINST
    // 0B0 TotalLiveAllGreatList                    ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer
    // 000 TotalLiveAllPerfectListFieldNumber       int IL2CPP_TYPE_I4
    // 050 _repeated_totalLiveAllPerfectList_codec  FieldCodec`1<UserProfileLiveStatus> IL2CPP_TYPE_GENERICINST
    // 0B8 TotalLiveAllPerfectList                  ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer
    // 000 TotalProduceFinishListFieldNumber        int IL2CPP_TYPE_I4
    // 058 _repeated_totalProduceFinishList_codec   FieldCodec`1<UserProfileProduceStatus> IL2CPP_TYPE_GENERICINST
    // 0C0 TotalProduceFinishList                   ModelClassListType RepeatedField`1<UserProfileProduceStatus> RepeatedField`1<UserProfileProduceStatus> List<UserProfileProduceStatus> Pointer
    // 000 ParameterRankListFieldNumber             int IL2CPP_TYPE_I4
    // 060 _repeated_parameterRankList_codec        FieldCodec`1<UserProfileProduceTotalParameterRankStatus> IL2CPP_TYPE_GENERICINST
    // 0C8 ParameterRankList                        ModelClassListType RepeatedField`1<UserProfileProduceTotalParameterRankStatus> RepeatedField`1<UserProfileProduceTotalParameterRankStatus> List<UserProfileProduceTotalParameterRankStatus> Pointer
    // 000 ProduceCardNumFieldNumber                int IL2CPP_TYPE_I4
    // 0D0 ProduceCardNum                           ModelPrimitiveType int int int Int32
    // 000 ProduceCardOpenedNumFieldNumber          int IL2CPP_TYPE_I4
    // 0D4 ProduceCardOpenedNum                     ModelPrimitiveType int int int Int32
    // 000 ParameterRankDetailListFieldNumber       int IL2CPP_TYPE_I4
    // 068 _repeated_parameterRankDetailList_codec  FieldCodec`1<UserProfileFesUnitRankStatus> IL2CPP_TYPE_GENERICINST
    // 0D8 ParameterRankDetailList                  ModelClassListType RepeatedField`1<UserProfileFesUnitRankStatus> RepeatedField`1<UserProfileFesUnitRankStatus> List<UserProfileFesUnitRankStatus> Pointer
    // 000 ProduceCardDetailListFieldNumber         int IL2CPP_TYPE_I4
    // 070 _repeated_produceCardDetailList_codec    FieldCodec`1<UserProfileProduceCardSummaryStatus> IL2CPP_TYPE_GENERICINST
    // 0E0 ProduceCardDetailList                    ModelClassListType RepeatedField`1<UserProfileProduceCardSummaryStatus> RepeatedField`1<UserProfileProduceCardSummaryStatus> List<UserProfileProduceCardSummaryStatus> Pointer
    // 000 LiveAllShinyListFieldNumber              int IL2CPP_TYPE_I4
    // 078 _repeated_liveAllShinyList_codec         FieldCodec`1<UserProfileLiveStatus> IL2CPP_TYPE_GENERICINST
    // 0E8 LiveAllShinyList                         ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer
    // 000 TotalLiveAllShinyListFieldNumber         int IL2CPP_TYPE_I4
    // 080 _repeated_totalLiveAllShinyList_codec    FieldCodec`1<UserProfileLiveStatus> IL2CPP_TYPE_GENERICINST
    // 0F0 TotalLiveAllShinyList                    ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer
    public partial class GetProducerInfoReply : DataModel
    {
        public DateTime                                 FirstWorkedDay                          { get; set; }
        public TotalHighScoreRatingStatus?              TotalHighScoreRating                    { get; set; }
        public TotalTechnicalRatingStatus?              TotalTechnicalRating                    { get; set; }
        public List<UserProfileLiveStatus>?             LiveFinishList                          { get; set; }
        public List<UserProfileLiveStatus>?             LiveFullComboList                       { get; set; }
        public List<UserProfileLiveStatus>?             LiveAllGreatList                        { get; set; }
        public List<UserProfileLiveStatus>?             LiveAllPerfectList                      { get; set; }
        public ProduceParameterRank                     BestProduceParameterRank                { get; set; }
        public List<UserProfileProduceStatus>?          ProduceScenarioFinishList               { get; set; }
        public int                                      WorkedNumber                            { get; set; }
        public Timestamp?                               _FirstWorkedDay                         { get; set; }
        public int                                      ProducedIdolNumber                      { get; set; }
        public int                                      EvolveNumber                            { get; set; }
        public int                                      LimitBreakNumber                        { get; set; }
        public int                                      CostumeNumber                           { get; set; }
        public int                                      SupportCharacterNumber                  { get; set; }
        public int                                      MasterTrainingNumber                    { get; set; }
        public long                                     TotalFanNumber                          { get; set; }
        public List<UserProfileStoryStatus>?            StoryReadNumberList                     { get; set; }
        public List<UserProfileLiveStatus>?             TotalLiveFinishList                     { get; set; }
        public List<UserProfileLiveStatus>?             TotalLiveFullComboList                  { get; set; }
        public List<UserProfileLiveStatus>?             TotalLiveAllGreatList                   { get; set; }
        public List<UserProfileLiveStatus>?             TotalLiveAllPerfectList                 { get; set; }
        public List<UserProfileProduceStatus>?          TotalProduceFinishList                  { get; set; }
        public List<UserProfileProduceTotalParameterRankStatus>? ParameterRankList                       { get; set; }
        public int                                      ProduceCardNum                          { get; set; }
        public int                                      ProduceCardOpenedNum                    { get; set; }
        public List<UserProfileFesUnitRankStatus>?      ParameterRankDetailList                 { get; set; }
        public List<UserProfileProduceCardSummaryStatus>? ProduceCardDetailList                   { get; set; }
        public List<UserProfileLiveStatus>?             LiveAllShinyList                        { get; set; }
        public List<UserProfileLiveStatus>?             TotalLiveAllShinyList                   { get; set; }

        public static GetProducerInfoReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetProducerInfoReply() { Pointer= p0 };

            value.FirstWorkedDay                            = GetDateTime(new IntPtr(p + 0x010)); // 0x10 FirstWorkedDay              ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.TotalHighScoreRating                      = GetObject<TotalHighScoreRatingStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.TotalHighScoreRatingStatus.FromPointer); // 0x28 TotalHighScoreRating        ( ModelClassType TotalHighScoreRatingStatus TotalHighScoreRatingStatus TotalHighScoreRatingStatus Pointer )
            value.TotalTechnicalRating                      = GetObject<TotalTechnicalRatingStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.TotalTechnicalRatingStatus.FromPointer); // 0x30 TotalTechnicalRating        ( ModelClassType TotalTechnicalRatingStatus TotalTechnicalRatingStatus TotalTechnicalRatingStatus Pointer )
            value.LiveFinishList                            = GetObjectList<UserProfileLiveStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.UserProfileLiveStatus.FromPointer); // 0x38 LiveFinishList              ( ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer )
            value.LiveFullComboList                         = GetObjectList<UserProfileLiveStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.UserProfileLiveStatus.FromPointer); // 0x40 LiveFullComboList           ( ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer )
            value.LiveAllGreatList                          = GetObjectList<UserProfileLiveStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.UserProfileLiveStatus.FromPointer); // 0x48 LiveAllGreatList            ( ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer )
            value.LiveAllPerfectList                        = GetObjectList<UserProfileLiveStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.UserProfileLiveStatus.FromPointer); // 0x50 LiveAllPerfectList          ( ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer )
            value.BestProduceParameterRank                  = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x058)); // 0x58 BestProduceParameterRank    ( ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.ProduceScenarioFinishList                 = GetObjectList<UserProfileProduceStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.UserProfileProduceStatus.FromPointer); // 0x60 ProduceScenarioFinishList   ( ModelClassListType RepeatedField`1<UserProfileProduceStatus> RepeatedField`1<UserProfileProduceStatus> List<UserProfileProduceStatus> Pointer )
            value.WorkedNumber                              = GetInt32(new IntPtr(p + 0x068)); // 0x68 WorkedNumber                ( ModelPrimitiveType int int int Int32 )
            value._FirstWorkedDay                           = GetObject<Timestamp>(new IntPtr(p + 0x070), ReversePrism.DataModels.Timestamp.FromPointer); // 0x70 _FirstWorkedDay             ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.ProducedIdolNumber                        = GetInt32(new IntPtr(p + 0x078)); // 0x78 ProducedIdolNumber          ( ModelPrimitiveType int int int Int32 )
            value.EvolveNumber                              = GetInt32(new IntPtr(p + 0x07C)); // 0x7C EvolveNumber                ( ModelPrimitiveType int int int Int32 )
            value.LimitBreakNumber                          = GetInt32(new IntPtr(p + 0x080)); // 0x80 LimitBreakNumber            ( ModelPrimitiveType int int int Int32 )
            value.CostumeNumber                             = GetInt32(new IntPtr(p + 0x084)); // 0x84 CostumeNumber               ( ModelPrimitiveType int int int Int32 )
            value.SupportCharacterNumber                    = GetInt32(new IntPtr(p + 0x088)); // 0x88 SupportCharacterNumber      ( ModelPrimitiveType int int int Int32 )
            value.MasterTrainingNumber                      = GetInt32(new IntPtr(p + 0x08C)); // 0x8C MasterTrainingNumber        ( ModelPrimitiveType int int int Int32 )
            value.TotalFanNumber                            = GetInt64(new IntPtr(p + 0x090)); // 0x90 TotalFanNumber              ( ModelPrimitiveType long long long Int64 )
            value.StoryReadNumberList                       = GetObjectList<UserProfileStoryStatus>(new IntPtr(p + 0x098), ReversePrism.DataModels.UserProfileStoryStatus.FromPointer); // 0x98 StoryReadNumberList         ( ModelClassListType RepeatedField`1<UserProfileStoryStatus> RepeatedField`1<UserProfileStoryStatus> List<UserProfileStoryStatus> Pointer )
            value.TotalLiveFinishList                       = GetObjectList<UserProfileLiveStatus>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UserProfileLiveStatus.FromPointer); // 0xA0 TotalLiveFinishList         ( ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer )
            value.TotalLiveFullComboList                    = GetObjectList<UserProfileLiveStatus>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UserProfileLiveStatus.FromPointer); // 0xA8 TotalLiveFullComboList      ( ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer )
            value.TotalLiveAllGreatList                     = GetObjectList<UserProfileLiveStatus>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.UserProfileLiveStatus.FromPointer); // 0xB0 TotalLiveAllGreatList       ( ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer )
            value.TotalLiveAllPerfectList                   = GetObjectList<UserProfileLiveStatus>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UserProfileLiveStatus.FromPointer); // 0xB8 TotalLiveAllPerfectList     ( ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer )
            value.TotalProduceFinishList                    = GetObjectList<UserProfileProduceStatus>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.UserProfileProduceStatus.FromPointer); // 0xC0 TotalProduceFinishList      ( ModelClassListType RepeatedField`1<UserProfileProduceStatus> RepeatedField`1<UserProfileProduceStatus> List<UserProfileProduceStatus> Pointer )
            value.ParameterRankList                         = GetObjectList<UserProfileProduceTotalParameterRankStatus>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UserProfileProduceTotalParameterRankStatus.FromPointer); // 0xC8 ParameterRankList           ( ModelClassListType RepeatedField`1<UserProfileProduceTotalParameterRankStatus> RepeatedField`1<UserProfileProduceTotalParameterRankStatus> List<UserProfileProduceTotalParameterRankStatus> Pointer )
            value.ProduceCardNum                            = GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 ProduceCardNum              ( ModelPrimitiveType int int int Int32 )
            value.ProduceCardOpenedNum                      = GetInt32(new IntPtr(p + 0x0D4)); // 0xD4 ProduceCardOpenedNum        ( ModelPrimitiveType int int int Int32 )
            value.ParameterRankDetailList                   = GetObjectList<UserProfileFesUnitRankStatus>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.UserProfileFesUnitRankStatus.FromPointer); // 0xD8 ParameterRankDetailList     ( ModelClassListType RepeatedField`1<UserProfileFesUnitRankStatus> RepeatedField`1<UserProfileFesUnitRankStatus> List<UserProfileFesUnitRankStatus> Pointer )
            value.ProduceCardDetailList                     = GetObjectList<UserProfileProduceCardSummaryStatus>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.UserProfileProduceCardSummaryStatus.FromPointer); // 0xE0 ProduceCardDetailList       ( ModelClassListType RepeatedField`1<UserProfileProduceCardSummaryStatus> RepeatedField`1<UserProfileProduceCardSummaryStatus> List<UserProfileProduceCardSummaryStatus> Pointer )
            value.LiveAllShinyList                          = GetObjectList<UserProfileLiveStatus>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.UserProfileLiveStatus.FromPointer); // 0xE8 LiveAllShinyList            ( ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer )
            value.TotalLiveAllShinyList                     = GetObjectList<UserProfileLiveStatus>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.UserProfileLiveStatus.FromPointer); // 0xF0 TotalLiveAllShinyList       ( ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer )
            value.FirstWorkedDay                = ToDateTime(value._FirstWorkedDay);

            return value;
        }
    }
}
