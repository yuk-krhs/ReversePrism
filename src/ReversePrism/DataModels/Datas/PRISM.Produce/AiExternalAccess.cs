using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GetIngamePlayerModelFunc                 Func`1<IngamePlayerModel> IL2CPP_TYPE_GENERICINST
    // 018 GetIngameEnemyModelFunc                  Func`1<IngamePlayerModel> IL2CPP_TYPE_GENERICINST
    // 020 <GetIngameTimeFunc>k__BackingField       Func`1<float> IL2CPP_TYPE_GENERICINST
    // 028 <GetIngameMaxTimeFunc>k__BackingField    Func`1<float> IL2CPP_TYPE_GENERICINST
    // 030 <GetHandCardNumFunc>k__BackingField      Func`1<int> IL2CPP_TYPE_GENERICINST
    // 038 <GetMaxHandCountFunc>k__BackingField     Func`1<int> IL2CPP_TYPE_GENERICINST
    // 040 <GetUsePcardCountFunc>k__BackingField    Func`1<int> IL2CPP_TYPE_GENERICINST
    // 048 <GetHandCardListFunc>k__BackingField     Func`1<List`1<IngamePCardModel>> IL2CPP_TYPE_GENERICINST
    // 050 <GetDeckCardListFunc>k__BackingField     Func`1<List`1<IngamePCardModel>> IL2CPP_TYPE_GENERICINST
    // 058 <GetMyStatusFunc>k__BackingField         Func`1<IngamePlayerStatusModel> IL2CPP_TYPE_GENERICINST
    // 060 <GetTimeRateFunc>k__BackingField         Func`1<float> IL2CPP_TYPE_GENERICINST
    // 068 <GetUserPPFunc>k__BackingField           Func`1<int> IL2CPP_TYPE_GENERICINST
    // 070 <GetUserAPFunc>k__BackingField           Func`1<int> IL2CPP_TYPE_GENERICINST
    // 078 <GetUserAPMaxFunc>k__BackingField        Func`1<int> IL2CPP_TYPE_GENERICINST
    // 080 <GetUserMentalFunc>k__BackingField       Func`1<int> IL2CPP_TYPE_GENERICINST
    // 088 <GetUserMentalMaxFunc>k__BackingField    Func`1<int> IL2CPP_TYPE_GENERICINST
    // 090 <GetMentalPercentFunc>k__BackingField    Func`1<float> IL2CPP_TYPE_GENERICINST
    // 098 <GetAvoidRateFunc>k__BackingField        Func`1<int> IL2CPP_TYPE_GENERICINST
    // 0A0 <GetEnemyMentalFunc>k__BackingField      Func`1<int> IL2CPP_TYPE_GENERICINST
    // 0A8 <GetEnemyMentalMaxFunc>k__BackingField   Func`1<int> IL2CPP_TYPE_GENERICINST
    // 0B0 <GetMentalGuardFunc>k__BackingField      Func`1<int> IL2CPP_TYPE_GENERICINST
    // 0B8 <GetEffectValueSumFunc>k__BackingField   Func`2<ProduceInGameEffectType, int> IL2CPP_TYPE_GENERICINST
    // 0C0 <GetPlayerCurrentCardCostFunc>k__BackingField Func`2<IngamePCardModel, int> IL2CPP_TYPE_GENERICINST
    // 0C8 <IsExistEffectFunc>k__BackingField       Func`2<ProduceInGameEffectType, bool> IL2CPP_TYPE_GENERICINST
    // 0D0 <GetPredictionByCardEffectFunc>k__BackingField Func`3<IngamePCardModel, IngameActionEffectModel, AutoReleaseScope`1<InGameActionResult>> IL2CPP_TYPE_GENERICINST
    // 0D8 <GetPredictionByCardFunc>k__BackingField Func`3<IngamePCardModel, float, AutoReleaseScope`1<InGameActionResult>> IL2CPP_TYPE_GENERICINST
    // 0E0 <OnExecuteCard>k__BackingField           Action`1<int> IL2CPP_TYPE_GENERICINST
    // 0E8 OnExecuteIdolSkillSubject                Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class AiExternalAccess
    {

        public static AiExternalAccess? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AiExternalAccess();


            return value;
        }
    }
}
