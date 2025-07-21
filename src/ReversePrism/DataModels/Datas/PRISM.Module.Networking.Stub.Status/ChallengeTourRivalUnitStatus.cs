using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ChallengeTourRivalUnitStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RivalListFieldNumber                     int IL2CPP_TYPE_I4
    // 008 _repeated_rivalList_codec                FieldCodec`1<ChallengeTourRivalStatus> IL2CPP_TYPE_GENERICINST
    // 018 RivalList                                ModelClassListType RepeatedField`1<ChallengeTourRivalStatus> RepeatedField`1<ChallengeTourRivalStatus> List<ChallengeTourRivalStatus> Pointer
    // 000 ProduceCardDeckFieldNumber               int IL2CPP_TYPE_I4
    // 020 ProduceCardDeck                          ModelClassType ProduceCardDeckStatus ProduceCardDeckStatus ProduceCardDeckStatus Pointer
    // 000 AppealCorrectionFieldNumber              int IL2CPP_TYPE_I4
    // 028 AppealCorrection                         ModelClassType AppealCorrectionStatus AppealCorrectionStatus AppealCorrectionStatus Pointer
    // 000 MstChallengeTourRivalUnitIdFieldNumber   int IL2CPP_TYPE_I4
    // 030 MstChallengeTourRivalUnitId              ModelPrimitiveType int int int Int32
    // 000 RecommendationTotalPowerFieldNumber      int IL2CPP_TYPE_I4
    // 034 RecommendationTotalPower                 ModelPrimitiveType int int int Int32
    public partial class ChallengeTourRivalUnitStatus : DataModel
    {
        public List<ChallengeTourRivalStatus>?          RivalList                               { get; set; }
        public ProduceCardDeckStatus?                   ProduceCardDeck                         { get; set; }
        public AppealCorrectionStatus?                  AppealCorrection                        { get; set; }
        public int                                      MstChallengeTourRivalUnitId             { get; set; }
        public int                                      RecommendationTotalPower                { get; set; }

        public static ChallengeTourRivalUnitStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourRivalUnitStatus() { Pointer= p0 };

            value.RivalList                                 = GetObjectList<ChallengeTourRivalStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ChallengeTourRivalStatus.FromPointer); // 0x18 RivalList                   ( ModelClassListType RepeatedField`1<ChallengeTourRivalStatus> RepeatedField`1<ChallengeTourRivalStatus> List<ChallengeTourRivalStatus> Pointer )
            value.ProduceCardDeck                           = GetObject<ProduceCardDeckStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceCardDeckStatus.FromPointer); // 0x20 ProduceCardDeck             ( ModelClassType ProduceCardDeckStatus ProduceCardDeckStatus ProduceCardDeckStatus Pointer )
            value.AppealCorrection                          = GetObject<AppealCorrectionStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.AppealCorrectionStatus.FromPointer); // 0x28 AppealCorrection            ( ModelClassType AppealCorrectionStatus AppealCorrectionStatus AppealCorrectionStatus Pointer )
            value.MstChallengeTourRivalUnitId               = GetInt32(new IntPtr(p + 0x030)); // 0x30 MstChallengeTourRivalUnitId ( ModelPrimitiveType int int int Int32 )
            value.RecommendationTotalPower                  = GetInt32(new IntPtr(p + 0x034)); // 0x34 RecommendationTotalPower    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
