using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetUserProgressInfoReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TotalHighScoreRatingFieldNumber          int IL2CPP_TYPE_I4
    // 018 TotalHighScoreRating                     ModelClassType TotalHighScoreRatingStatus TotalHighScoreRatingStatus TotalHighScoreRatingStatus Pointer
    // 000 TotalTechnicalRatingFieldNumber          int IL2CPP_TYPE_I4
    // 020 TotalTechnicalRating                     ModelClassType TotalTechnicalRatingStatus TotalTechnicalRatingStatus TotalTechnicalRatingStatus Pointer
    // 000 LiveFinishListFieldNumber                int IL2CPP_TYPE_I4
    // 008 _repeated_liveFinishList_codec           FieldCodec`1<UserProfileLiveStatus> IL2CPP_TYPE_GENERICINST
    // 028 LiveFinishList                           ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer
    // 000 LiveFullComboListFieldNumber             int IL2CPP_TYPE_I4
    // 010 _repeated_liveFullComboList_codec        FieldCodec`1<UserProfileLiveStatus> IL2CPP_TYPE_GENERICINST
    // 030 LiveFullComboList                        ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer
    // 000 LiveAllGreatListFieldNumber              int IL2CPP_TYPE_I4
    // 018 _repeated_liveAllGreatList_codec         FieldCodec`1<UserProfileLiveStatus> IL2CPP_TYPE_GENERICINST
    // 038 LiveAllGreatList                         ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer
    // 000 LiveAllPerfectListFieldNumber            int IL2CPP_TYPE_I4
    // 020 _repeated_liveAllPerfectList_codec       FieldCodec`1<UserProfileLiveStatus> IL2CPP_TYPE_GENERICINST
    // 040 LiveAllPerfectList                       ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer
    // 000 BestProduceParameterRankFieldNumber      int IL2CPP_TYPE_I4
    // 048 BestProduceParameterRank                 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 000 ProduceScenarioFinishListFieldNumber     int IL2CPP_TYPE_I4
    // 028 _repeated_produceScenarioFinishList_codec FieldCodec`1<UserProfileProduceStatus> IL2CPP_TYPE_GENERICINST
    // 050 ProduceScenarioFinishList                ModelClassListType RepeatedField`1<UserProfileProduceStatus> RepeatedField`1<UserProfileProduceStatus> List<UserProfileProduceStatus> Pointer
    // 000 ParameterRankDetailListFieldNumber       int IL2CPP_TYPE_I4
    // 030 _repeated_parameterRankDetailList_codec  FieldCodec`1<UserProfileFesUnitRankStatus> IL2CPP_TYPE_GENERICINST
    // 058 ParameterRankDetailList                  ModelClassListType RepeatedField`1<UserProfileFesUnitRankStatus> RepeatedField`1<UserProfileFesUnitRankStatus> List<UserProfileFesUnitRankStatus> Pointer
    // 000 LiveAllShinyListFieldNumber              int IL2CPP_TYPE_I4
    // 038 _repeated_liveAllShinyList_codec         FieldCodec`1<UserProfileLiveStatus> IL2CPP_TYPE_GENERICINST
    // 060 LiveAllShinyList                         ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer
    public partial class GetUserProgressInfoReply : DataModel
    {
        public TotalHighScoreRatingStatus?              TotalHighScoreRating                    { get; set; }
        public TotalTechnicalRatingStatus?              TotalTechnicalRating                    { get; set; }
        public List<UserProfileLiveStatus>?             LiveFinishList                          { get; set; }
        public List<UserProfileLiveStatus>?             LiveFullComboList                       { get; set; }
        public List<UserProfileLiveStatus>?             LiveAllGreatList                        { get; set; }
        public List<UserProfileLiveStatus>?             LiveAllPerfectList                      { get; set; }
        public ProduceParameterRank                     BestProduceParameterRank                { get; set; }
        public List<UserProfileProduceStatus>?          ProduceScenarioFinishList               { get; set; }
        public List<UserProfileFesUnitRankStatus>?      ParameterRankDetailList                 { get; set; }
        public List<UserProfileLiveStatus>?             LiveAllShinyList                        { get; set; }

        public static GetUserProgressInfoReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetUserProgressInfoReply() { Pointer= p0 };

            value.TotalHighScoreRating                      = GetObject<TotalHighScoreRatingStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.TotalHighScoreRatingStatus.FromPointer); // 0x18 TotalHighScoreRating        ( ModelClassType TotalHighScoreRatingStatus TotalHighScoreRatingStatus TotalHighScoreRatingStatus Pointer )
            value.TotalTechnicalRating                      = GetObject<TotalTechnicalRatingStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.TotalTechnicalRatingStatus.FromPointer); // 0x20 TotalTechnicalRating        ( ModelClassType TotalTechnicalRatingStatus TotalTechnicalRatingStatus TotalTechnicalRatingStatus Pointer )
            value.LiveFinishList                            = GetObjectList<UserProfileLiveStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.UserProfileLiveStatus.FromPointer); // 0x28 LiveFinishList              ( ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer )
            value.LiveFullComboList                         = GetObjectList<UserProfileLiveStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.UserProfileLiveStatus.FromPointer); // 0x30 LiveFullComboList           ( ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer )
            value.LiveAllGreatList                          = GetObjectList<UserProfileLiveStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.UserProfileLiveStatus.FromPointer); // 0x38 LiveAllGreatList            ( ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer )
            value.LiveAllPerfectList                        = GetObjectList<UserProfileLiveStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.UserProfileLiveStatus.FromPointer); // 0x40 LiveAllPerfectList          ( ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer )
            value.BestProduceParameterRank                  = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x048)); // 0x48 BestProduceParameterRank    ( ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.ProduceScenarioFinishList                 = GetObjectList<UserProfileProduceStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.UserProfileProduceStatus.FromPointer); // 0x50 ProduceScenarioFinishList   ( ModelClassListType RepeatedField`1<UserProfileProduceStatus> RepeatedField`1<UserProfileProduceStatus> List<UserProfileProduceStatus> Pointer )
            value.ParameterRankDetailList                   = GetObjectList<UserProfileFesUnitRankStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.UserProfileFesUnitRankStatus.FromPointer); // 0x58 ParameterRankDetailList     ( ModelClassListType RepeatedField`1<UserProfileFesUnitRankStatus> RepeatedField`1<UserProfileFesUnitRankStatus> List<UserProfileFesUnitRankStatus> Pointer )
            value.LiveAllShinyList                          = GetObjectList<UserProfileLiveStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.UserProfileLiveStatus.FromPointer); // 0x60 LiveAllShinyList            ( ModelClassListType RepeatedField`1<UserProfileLiveStatus> RepeatedField`1<UserProfileLiveStatus> List<UserProfileLiveStatus> Pointer )

            return value;
        }
    }
}
