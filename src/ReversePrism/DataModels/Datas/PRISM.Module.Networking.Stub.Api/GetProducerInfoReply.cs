using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FirstWorkedDay                           000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<GetProducerInfoReply> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TotalHighScoreRatingFieldNumber          int IL2CPP_TYPE_I4
    // 028 TotalHighScoreRating                     00018668CAE0 ModelClassType TotalHighScoreRatingStatus TotalHighScoreRatingStatus TotalHighScoreRatingStatus Pointer
    // 000 TotalTechnicalRatingFieldNumber          int IL2CPP_TYPE_I4
    // 030 TotalTechnicalRating                     00018668D290 ModelClassType TotalTechnicalRatingStatus TotalTechnicalRatingStatus TotalTechnicalRatingStatus Pointer
    // 000 LiveFinishListFieldNumber                int IL2CPP_TYPE_I4
    // 008 _repeated_liveFinishList_codec           FieldCodec`1<UserProfileLiveStatus> IL2CPP_TYPE_GENERICINST
    // 038 LiveFinishList                           000185CF7058 ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer
    // 000 LiveFullComboListFieldNumber             int IL2CPP_TYPE_I4
    // 010 _repeated_liveFullComboList_codec        FieldCodec`1<UserProfileLiveStatus> IL2CPP_TYPE_GENERICINST
    // 040 LiveFullComboList                        000185CF7058 ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer
    // 000 LiveAllGreatListFieldNumber              int IL2CPP_TYPE_I4
    // 018 _repeated_liveAllGreatList_codec         FieldCodec`1<UserProfileLiveStatus> IL2CPP_TYPE_GENERICINST
    // 048 LiveAllGreatList                         000185CF7058 ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer
    // 000 LiveAllPerfectListFieldNumber            int IL2CPP_TYPE_I4
    // 020 _repeated_liveAllPerfectList_codec       FieldCodec`1<UserProfileLiveStatus> IL2CPP_TYPE_GENERICINST
    // 050 LiveAllPerfectList                       000185CF7058 ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer
    // 000 BestProduceParameterRankFieldNumber      int IL2CPP_TYPE_I4
    // 058 BestProduceParameterRank                 000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 000 ProduceScenarioFinishListFieldNumber     int IL2CPP_TYPE_I4
    // 028 _repeated_produceScenarioFinishList_codec FieldCodec`1<UserProfileProduceStatus> IL2CPP_TYPE_GENERICINST
    // 060 ProduceScenarioFinishList                000185CF74D8 ModelClassListType RepeatedField`1<UserProfileProduceStatus> RepeatedField`1<UserProfileProduceStatus> List<UserProfileProduceStatus> Pointer
    // 000 WorkedNumberFieldNumber                  int IL2CPP_TYPE_I4
    // 068 WorkedNumber                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 FirstWorkedDayFieldNumber                int IL2CPP_TYPE_I4
    // 070 _FirstWorkedDay                          000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 ProducedIdolNumberFieldNumber            int IL2CPP_TYPE_I4
    // 078 ProducedIdolNumber                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 EvolveNumberFieldNumber                  int IL2CPP_TYPE_I4
    // 07C EvolveNumber                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 LimitBreakNumberFieldNumber              int IL2CPP_TYPE_I4
    // 080 LimitBreakNumber                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CostumeNumberFieldNumber                 int IL2CPP_TYPE_I4
    // 084 CostumeNumber                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 SupportCharacterNumberFieldNumber        int IL2CPP_TYPE_I4
    // 088 SupportCharacterNumber                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MasterTrainingNumberFieldNumber          int IL2CPP_TYPE_I4
    // 08C MasterTrainingNumber                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 TotalFanNumberFieldNumber                int IL2CPP_TYPE_I4
    // 090 TotalFanNumber                           0001865F7700 ModelPrimitiveType long long long Int64
    // 000 StoryReadNumberListFieldNumber           int IL2CPP_TYPE_I4
    // 030 _repeated_storyReadNumberList_codec      FieldCodec`1<UserProfileStoryStatus> IL2CPP_TYPE_GENERICINST
    // 098 StoryReadNumberList                      000185CF7968 ModelClassListType RepeatedField`1<UserProfileStoryStatus> RepeatedField`1<UserProfileStoryStatus> List<UserProfileStoryStatus> Pointer
    // 000 TotalLiveFinishListFieldNumber           int IL2CPP_TYPE_I4
    // 038 _repeated_totalLiveFinishList_codec      FieldCodec`1<UserProfileLiveStatus> IL2CPP_TYPE_GENERICINST
    // 0A0 TotalLiveFinishList                      000185CF7058 ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer
    // 000 TotalLiveFullComboListFieldNumber        int IL2CPP_TYPE_I4
    // 040 _repeated_totalLiveFullComboList_codec   FieldCodec`1<UserProfileLiveStatus> IL2CPP_TYPE_GENERICINST
    // 0A8 TotalLiveFullComboList                   000185CF7058 ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer
    // 000 TotalLiveAllGreatListFieldNumber         int IL2CPP_TYPE_I4
    // 048 _repeated_totalLiveAllGreatList_codec    FieldCodec`1<UserProfileLiveStatus> IL2CPP_TYPE_GENERICINST
    // 0B0 TotalLiveAllGreatList                    000185CF7058 ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer
    // 000 TotalLiveAllPerfectListFieldNumber       int IL2CPP_TYPE_I4
    // 050 _repeated_totalLiveAllPerfectList_codec  FieldCodec`1<UserProfileLiveStatus> IL2CPP_TYPE_GENERICINST
    // 0B8 TotalLiveAllPerfectList                  000185CF7058 ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer
    // 000 TotalProduceFinishListFieldNumber        int IL2CPP_TYPE_I4
    // 058 _repeated_totalProduceFinishList_codec   FieldCodec`1<UserProfileProduceStatus> IL2CPP_TYPE_GENERICINST
    // 0C0 TotalProduceFinishList                   000185CF74D8 ModelClassListType RepeatedField`1<UserProfileProduceStatus> RepeatedField`1<UserProfileProduceStatus> List<UserProfileProduceStatus> Pointer
    // 000 ParameterRankListFieldNumber             int IL2CPP_TYPE_I4
    // 060 _repeated_parameterRankList_codec        FieldCodec`1<UserProfileProduceTotalParameterRankStatus> IL2CPP_TYPE_GENERICINST
    // 0C8 ParameterRankList                        000185CF76F8 ModelClassListType RepeatedField`1<UserProfileProduceTotalParameterRankStatus> RepeatedField`1<UserProfileProduceTotalParameterRankStatus> List<UserProfileProduceTotalParameterRankStatus> Pointer
    // 000 ProduceCardNumFieldNumber                int IL2CPP_TYPE_I4
    // 0D0 ProduceCardNum                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ProduceCardOpenedNumFieldNumber          int IL2CPP_TYPE_I4
    // 0D4 ProduceCardOpenedNum                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ParameterRankDetailListFieldNumber       int IL2CPP_TYPE_I4
    // 068 _repeated_parameterRankDetailList_codec  FieldCodec`1<UserProfileFesUnitRankStatus> IL2CPP_TYPE_GENERICINST
    // 0D8 ParameterRankDetailList                  000185CF6E18 ModelClassListType RepeatedField`1<UserProfileFesUnitRankStatus> RepeatedField`1<UserProfileFesUnitRankStatus> List<UserProfileFesUnitRankStatus> Pointer
    // 000 ProduceCardDetailListFieldNumber         int IL2CPP_TYPE_I4
    // 070 _repeated_produceCardDetailList_codec    FieldCodec`1<UserProfileProduceCardSummaryStatus> IL2CPP_TYPE_GENERICINST
    // 0E0 ProduceCardDetailList                    000185CF7288 ModelClassListType RepeatedField`1<UserProfileProduceCardSummaryStatus> RepeatedField`1<UserProfileProduceCardSummaryStatus> List<UserProfileProduceCardSummaryStatus> Pointer
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

        public static GetProducerInfoReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetProducerInfoReply() { Pointer= p0 };

            value.FirstWorkedDay                            = GetDateTime(new IntPtr(p + 0x010)); // 0246626498E0 0x10 FirstWorkedDay              ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.TotalHighScoreRating                      = GetObject<TotalHighScoreRatingStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.TotalHighScoreRatingStatus.FromPointer); // 024662649960 0x28 TotalHighScoreRating        ( 00018668CAE0 ModelClassType TotalHighScoreRatingStatus TotalHighScoreRatingStatus TotalHighScoreRatingStatus Pointer )
            value.TotalTechnicalRating                      = GetObject<TotalTechnicalRatingStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.TotalTechnicalRatingStatus.FromPointer); // 0246626499A0 0x30 TotalTechnicalRating        ( 00018668D290 ModelClassType TotalTechnicalRatingStatus TotalTechnicalRatingStatus TotalTechnicalRatingStatus Pointer )
            value.LiveFinishList                            = GetObjectList<UserProfileLiveStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.UserProfileLiveStatus.FromPointer); // 024662649A00 0x38 LiveFinishList              ( 000185CF7058 ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer )
            value.LiveFullComboList                         = GetObjectList<UserProfileLiveStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.UserProfileLiveStatus.FromPointer); // 024662649A60 0x40 LiveFullComboList           ( 000185CF7058 ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer )
            value.LiveAllGreatList                          = GetObjectList<UserProfileLiveStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.UserProfileLiveStatus.FromPointer); // 024662649AC0 0x48 LiveAllGreatList            ( 000185CF7058 ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer )
            value.LiveAllPerfectList                        = GetObjectList<UserProfileLiveStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.UserProfileLiveStatus.FromPointer); // 024662649B20 0x50 LiveAllPerfectList          ( 000185CF7058 ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer )
            value.BestProduceParameterRank                  = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x058)); // 024662649B60 0x58 BestProduceParameterRank    ( 000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.ProduceScenarioFinishList                 = GetObjectList<UserProfileProduceStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.UserProfileProduceStatus.FromPointer); // 024662649BC0 0x60 ProduceScenarioFinishList   ( 000185CF74D8 ModelClassListType RepeatedField`1<UserProfileProduceStatus> RepeatedField`1<UserProfileProduceStatus> List<UserProfileProduceStatus> Pointer )
            value.WorkedNumber                              = GetInt32(new IntPtr(p + 0x068)); // 024662649C00 0x68 WorkedNumber                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value._FirstWorkedDay                           = GetObject<Timestamp>(new IntPtr(p + 0x070), ReversePrism.DataModels.Timestamp.FromPointer); // 024662649C40 0x70 _FirstWorkedDay             ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.ProducedIdolNumber                        = GetInt32(new IntPtr(p + 0x078)); // 024662649C80 0x78 ProducedIdolNumber          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EvolveNumber                              = GetInt32(new IntPtr(p + 0x07C)); // 024662649CC0 0x7C EvolveNumber                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LimitBreakNumber                          = GetInt32(new IntPtr(p + 0x080)); // 024662649D00 0x80 LimitBreakNumber            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CostumeNumber                             = GetInt32(new IntPtr(p + 0x084)); // 024662649D40 0x84 CostumeNumber               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SupportCharacterNumber                    = GetInt32(new IntPtr(p + 0x088)); // 024662649D80 0x88 SupportCharacterNumber      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MasterTrainingNumber                      = GetInt32(new IntPtr(p + 0x08C)); // 024662649DC0 0x8C MasterTrainingNumber        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TotalFanNumber                            = GetInt64(new IntPtr(p + 0x090)); // 024662649E00 0x90 TotalFanNumber              ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.StoryReadNumberList                       = GetObjectList<UserProfileStoryStatus>(new IntPtr(p + 0x098), ReversePrism.DataModels.UserProfileStoryStatus.FromPointer); // 024662649E60 0x98 StoryReadNumberList         ( 000185CF7968 ModelClassListType RepeatedField`1<UserProfileStoryStatus> RepeatedField`1<UserProfileStoryStatus> List<UserProfileStoryStatus> Pointer )
            value.TotalLiveFinishList                       = GetObjectList<UserProfileLiveStatus>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UserProfileLiveStatus.FromPointer); // 024662649EC0 0xA0 TotalLiveFinishList         ( 000185CF7058 ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer )
            value.TotalLiveFullComboList                    = GetObjectList<UserProfileLiveStatus>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UserProfileLiveStatus.FromPointer); // 024662649F20 0xA8 TotalLiveFullComboList      ( 000185CF7058 ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer )
            value.TotalLiveAllGreatList                     = GetObjectList<UserProfileLiveStatus>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.UserProfileLiveStatus.FromPointer); // 024662649F80 0xB0 TotalLiveAllGreatList       ( 000185CF7058 ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer )
            value.TotalLiveAllPerfectList                   = GetObjectList<UserProfileLiveStatus>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UserProfileLiveStatus.FromPointer); // 024662649FE0 0xB8 TotalLiveAllPerfectList     ( 000185CF7058 ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer )
            value.TotalProduceFinishList                    = GetObjectList<UserProfileProduceStatus>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.UserProfileProduceStatus.FromPointer); // 02466264A040 0xC0 TotalProduceFinishList      ( 000185CF74D8 ModelClassListType RepeatedField`1<UserProfileProduceStatus> RepeatedField`1<UserProfileProduceStatus> List<UserProfileProduceStatus> Pointer )
            value.ParameterRankList                         = GetObjectList<UserProfileProduceTotalParameterRankStatus>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UserProfileProduceTotalParameterRankStatus.FromPointer); // 02466264A0A0 0xC8 ParameterRankList           ( 000185CF76F8 ModelClassListType RepeatedField`1<UserProfileProduceTotalParameterRankStatus> RepeatedField`1<UserProfileProduceTotalParameterRankStatus> List<UserProfileProduceTotalParameterRankStatus> Pointer )
            value.ProduceCardNum                            = GetInt32(new IntPtr(p + 0x0D0)); // 02466264A0E0 0xD0 ProduceCardNum              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ProduceCardOpenedNum                      = GetInt32(new IntPtr(p + 0x0D4)); // 02466264A120 0xD4 ProduceCardOpenedNum        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ParameterRankDetailList                   = GetObjectList<UserProfileFesUnitRankStatus>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.UserProfileFesUnitRankStatus.FromPointer); // 02466264A180 0xD8 ParameterRankDetailList     ( 000185CF6E18 ModelClassListType RepeatedField`1<UserProfileFesUnitRankStatus> RepeatedField`1<UserProfileFesUnitRankStatus> List<UserProfileFesUnitRankStatus> Pointer )
            value.ProduceCardDetailList                     = GetObjectList<UserProfileProduceCardSummaryStatus>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.UserProfileProduceCardSummaryStatus.FromPointer); // 02466264A1E0 0xE0 ProduceCardDetailList       ( 000185CF7288 ModelClassListType RepeatedField`1<UserProfileProduceCardSummaryStatus> RepeatedField`1<UserProfileProduceCardSummaryStatus> List<UserProfileProduceCardSummaryStatus> Pointer )
            value.FirstWorkedDay                = ToDateTime(value._FirstWorkedDay);

            return value;
        }
    }
}
