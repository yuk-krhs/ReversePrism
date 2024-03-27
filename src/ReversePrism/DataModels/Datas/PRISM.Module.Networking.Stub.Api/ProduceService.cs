using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetProduceUnitArgs      Marshaller`1<GetProduceUnitArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetProduceUnitReply     Marshaller`1<GetProduceUnitReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_SetProduceUnitArgs      Marshaller`1<SetProduceUnitArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_SetProduceUnitReply     Marshaller`1<SetProduceUnitReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_GetFriendSupportCharacterListArgs Marshaller`1<GetFriendSupportCharacterListArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_GetFriendSupportCharacterListReply Marshaller`1<GetFriendSupportCharacterListReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_StartProduceArgs        Marshaller`1<StartProduceArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_StartProduceReply       Marshaller`1<StartProduceReply> IL2CPP_TYPE_GENERICINST
    // 048 __Marshaller_api_GetProduceResumeArgs    Marshaller`1<GetProduceResumeArgs> IL2CPP_TYPE_GENERICINST
    // 050 __Marshaller_api_GetProduceResumeReply   Marshaller`1<GetProduceResumeReply> IL2CPP_TYPE_GENERICINST
    // 058 __Marshaller_api_GetProduceTopArgs       Marshaller`1<GetProduceTopArgs> IL2CPP_TYPE_GENERICINST
    // 060 __Marshaller_api_GetProduceTopReply      Marshaller`1<GetProduceTopReply> IL2CPP_TYPE_GENERICINST
    // 068 __Marshaller_api_GetEpisodeListArgs      Marshaller`1<GetEpisodeListArgs> IL2CPP_TYPE_GENERICINST
    // 070 __Marshaller_api_GetEpisodeListReply     Marshaller`1<GetEpisodeListReply> IL2CPP_TYPE_GENERICINST
    // 078 __Marshaller_api_ProduceStrategyListArgs Marshaller`1<ProduceStrategyListArgs> IL2CPP_TYPE_GENERICINST
    // 080 __Marshaller_api_ProduceStrategyListReply Marshaller`1<ProduceStrategyListReply> IL2CPP_TYPE_GENERICINST
    // 088 __Marshaller_api_SelectProduceStrategyArgs Marshaller`1<SelectProduceStrategyArgs> IL2CPP_TYPE_GENERICINST
    // 090 __Marshaller_api_SelectProduceStrategyReply Marshaller`1<SelectProduceStrategyReply> IL2CPP_TYPE_GENERICINST
    // 098 __Marshaller_api_SelectProduceStrategyRewardArgs Marshaller`1<SelectProduceStrategyRewardArgs> IL2CPP_TYPE_GENERICINST
    // 0A0 __Marshaller_api_SelectProduceStrategyRewardReply Marshaller`1<SelectProduceStrategyRewardReply> IL2CPP_TYPE_GENERICINST
    // 0A8 __Marshaller_api_SelectScheduleArgs      Marshaller`1<SelectScheduleArgs> IL2CPP_TYPE_GENERICINST
    // 0B0 __Marshaller_api_SelectScheduleReply     Marshaller`1<SelectScheduleReply> IL2CPP_TYPE_GENERICINST
    // 0B8 __Marshaller_api_StartScheduleRestArgs   Marshaller`1<StartScheduleRestArgs> IL2CPP_TYPE_GENERICINST
    // 0C0 __Marshaller_api_StartScheduleRestReply  Marshaller`1<StartScheduleRestReply> IL2CPP_TYPE_GENERICINST
    // 0C8 __Marshaller_api_FinishScheduleRestArgs  Marshaller`1<FinishScheduleRestArgs> IL2CPP_TYPE_GENERICINST
    // 0D0 __Marshaller_api_FinishScheduleRestReply Marshaller`1<FinishScheduleRestReply> IL2CPP_TYPE_GENERICINST
    // 0D8 __Marshaller_api_StartScheduleTrainingArgs Marshaller`1<StartScheduleTrainingArgs> IL2CPP_TYPE_GENERICINST
    // 0E0 __Marshaller_api_StartScheduleTrainingReply Marshaller`1<StartScheduleTrainingReply> IL2CPP_TYPE_GENERICINST
    // 0E8 __Marshaller_api_FinishScheduleTrainingArgs Marshaller`1<FinishScheduleTrainingArgs> IL2CPP_TYPE_GENERICINST
    // 0F0 __Marshaller_api_FinishScheduleTrainingReply Marshaller`1<FinishScheduleTrainingReply> IL2CPP_TYPE_GENERICINST
    // 0F8 __Marshaller_api_StartScheduleWorkingArgs Marshaller`1<StartScheduleWorkingArgs> IL2CPP_TYPE_GENERICINST
    // 100 __Marshaller_api_StartScheduleWorkingReply Marshaller`1<StartScheduleWorkingReply> IL2CPP_TYPE_GENERICINST
    // 108 __Marshaller_api_FinishScheduleWorkingArgs Marshaller`1<FinishScheduleWorkingArgs> IL2CPP_TYPE_GENERICINST
    // 110 __Marshaller_api_FinishScheduleWorkingReply Marshaller`1<FinishScheduleWorkingReply> IL2CPP_TYPE_GENERICINST
    // 118 __Marshaller_api_StartScheduleOutingArgs Marshaller`1<StartScheduleOutingArgs> IL2CPP_TYPE_GENERICINST
    // 120 __Marshaller_api_StartScheduleOutingReply Marshaller`1<StartScheduleOutingReply> IL2CPP_TYPE_GENERICINST
    // 128 __Marshaller_api_FinishScheduleOutingArgs Marshaller`1<FinishScheduleOutingArgs> IL2CPP_TYPE_GENERICINST
    // 130 __Marshaller_api_FinishScheduleOutingReply Marshaller`1<FinishScheduleOutingReply> IL2CPP_TYPE_GENERICINST
    // 138 __Marshaller_api_StartScheduleShoppingArgs Marshaller`1<StartScheduleShoppingArgs> IL2CPP_TYPE_GENERICINST
    // 140 __Marshaller_api_StartScheduleShoppingReply Marshaller`1<StartScheduleShoppingReply> IL2CPP_TYPE_GENERICINST
    // 148 __Marshaller_api_FinishScheduleShoppingArgs Marshaller`1<FinishScheduleShoppingArgs> IL2CPP_TYPE_GENERICINST
    // 150 __Marshaller_api_FinishScheduleShoppingReply Marshaller`1<FinishScheduleShoppingReply> IL2CPP_TYPE_GENERICINST
    // 158 __Marshaller_api_StartScheduleAdviceArgs Marshaller`1<StartScheduleAdviceArgs> IL2CPP_TYPE_GENERICINST
    // 160 __Marshaller_api_StartScheduleAdviceReply Marshaller`1<StartScheduleAdviceReply> IL2CPP_TYPE_GENERICINST
    // 168 __Marshaller_api_FinishScheduleAdviceArgs Marshaller`1<FinishScheduleAdviceArgs> IL2CPP_TYPE_GENERICINST
    // 170 __Marshaller_api_FinishScheduleAdviceReply Marshaller`1<FinishScheduleAdviceReply> IL2CPP_TYPE_GENERICINST
    // 178 __Marshaller_api_StartLessonArgs         Marshaller`1<StartLessonArgs> IL2CPP_TYPE_GENERICINST
    // 180 __Marshaller_api_StartLessonReply        Marshaller`1<StartLessonReply> IL2CPP_TYPE_GENERICINST
    // 188 __Marshaller_api_FinishLessonArgs        Marshaller`1<FinishLessonArgs> IL2CPP_TYPE_GENERICINST
    // 190 __Marshaller_api_FinishLessonReply       Marshaller`1<FinishLessonReply> IL2CPP_TYPE_GENERICINST
    // 198 __Marshaller_api_FinishLessonResultArgs  Marshaller`1<FinishLessonResultArgs> IL2CPP_TYPE_GENERICINST
    // 1A0 __Marshaller_api_FinishLessonResultReply Marshaller`1<FinishLessonResultReply> IL2CPP_TYPE_GENERICINST
    // 1A8 __Marshaller_api_StartSpecialLessonArgs  Marshaller`1<StartSpecialLessonArgs> IL2CPP_TYPE_GENERICINST
    // 1B0 __Marshaller_api_StartSpecialLessonReply Marshaller`1<StartSpecialLessonReply> IL2CPP_TYPE_GENERICINST
    // 1B8 __Marshaller_api_FinishSpecialLessonArgs Marshaller`1<FinishSpecialLessonArgs> IL2CPP_TYPE_GENERICINST
    // 1C0 __Marshaller_api_FinishSpecialLessonReply Marshaller`1<FinishSpecialLessonReply> IL2CPP_TYPE_GENERICINST
    // 1C8 __Marshaller_api_CardRankUpArgs          Marshaller`1<CardRankUpArgs> IL2CPP_TYPE_GENERICINST
    // 1D0 __Marshaller_api_CardRankUpReply         Marshaller`1<CardRankUpReply> IL2CPP_TYPE_GENERICINST
    // 1D8 __Marshaller_api_StartAuditionArgs       Marshaller`1<StartAuditionArgs> IL2CPP_TYPE_GENERICINST
    // 1E0 __Marshaller_api_StartAuditionReply      Marshaller`1<StartAuditionReply> IL2CPP_TYPE_GENERICINST
    // 1E8 __Marshaller_api_FinishAuditionArgs      Marshaller`1<FinishAuditionArgs> IL2CPP_TYPE_GENERICINST
    // 1F0 __Marshaller_api_FinishAuditionReply     Marshaller`1<FinishAuditionReply> IL2CPP_TYPE_GENERICINST
    // 1F8 __Marshaller_api_FinishAuditionResultArgs Marshaller`1<FinishAuditionResultArgs> IL2CPP_TYPE_GENERICINST
    // 200 __Marshaller_api_FinishAuditionResultReply Marshaller`1<FinishAuditionResultReply> IL2CPP_TYPE_GENERICINST
    // 208 __Marshaller_api_StartSupportCooperationEventArgs Marshaller`1<StartSupportCooperationEventArgs> IL2CPP_TYPE_GENERICINST
    // 210 __Marshaller_api_StartSupportCooperationEventReply Marshaller`1<StartSupportCooperationEventReply> IL2CPP_TYPE_GENERICINST
    // 218 __Marshaller_api_FinishSupportCooperationEventArgs Marshaller`1<FinishSupportCooperationEventArgs> IL2CPP_TYPE_GENERICINST
    // 220 __Marshaller_api_FinishSupportCooperationEventReply Marshaller`1<FinishSupportCooperationEventReply> IL2CPP_TYPE_GENERICINST
    // 228 __Marshaller_api_StartProduceAdvArgs     Marshaller`1<StartProduceAdvArgs> IL2CPP_TYPE_GENERICINST
    // 230 __Marshaller_api_StartProduceAdvReply    Marshaller`1<StartProduceAdvReply> IL2CPP_TYPE_GENERICINST
    // 238 __Marshaller_api_SelectProduceAdvOptionArgs Marshaller`1<SelectProduceAdvOptionArgs> IL2CPP_TYPE_GENERICINST
    // 240 __Marshaller_api_SelectProduceAdvOptionReply Marshaller`1<SelectProduceAdvOptionReply> IL2CPP_TYPE_GENERICINST
    // 248 __Marshaller_api_FinishProduceAdvArgs    Marshaller`1<FinishProduceAdvArgs> IL2CPP_TYPE_GENERICINST
    // 250 __Marshaller_api_FinishProduceAdvReply   Marshaller`1<FinishProduceAdvReply> IL2CPP_TYPE_GENERICINST
    // 258 __Marshaller_api_ProduceResultArgs       Marshaller`1<ProduceResultArgs> IL2CPP_TYPE_GENERICINST
    // 260 __Marshaller_api_ProduceResultReply      Marshaller`1<ProduceResultReply> IL2CPP_TYPE_GENERICINST
    // 268 __Marshaller_api_DetermineProduceResultArgs Marshaller`1<DetermineProduceResultArgs> IL2CPP_TYPE_GENERICINST
    // 270 __Marshaller_api_DetermineProduceResultReply Marshaller`1<DetermineProduceResultReply> IL2CPP_TYPE_GENERICINST
    // 278 __Marshaller_api_ProduceMVArgs           Marshaller`1<ProduceMVArgs> IL2CPP_TYPE_GENERICINST
    // 280 __Marshaller_api_ProduceMVReply          Marshaller`1<ProduceMVReply> IL2CPP_TYPE_GENERICINST
    // 288 __Marshaller_api_FinishProduceArgs       Marshaller`1<FinishProduceArgs> IL2CPP_TYPE_GENERICINST
    // 290 __Marshaller_api_FinishProduceReply      Marshaller`1<FinishProduceReply> IL2CPP_TYPE_GENERICINST
    // 298 __Marshaller_api_SubSeasonListArgs       Marshaller`1<SubSeasonListArgs> IL2CPP_TYPE_GENERICINST
    // 2A0 __Marshaller_api_SubSeasonListReply      Marshaller`1<SubSeasonListReply> IL2CPP_TYPE_GENERICINST
    // 2A8 __Marshaller_api_SelectSubSeasonArgs     Marshaller`1<SelectSubSeasonArgs> IL2CPP_TYPE_GENERICINST
    // 2B0 __Marshaller_api_SelectSubSeasonReply    Marshaller`1<SelectSubSeasonReply> IL2CPP_TYPE_GENERICINST
    // 2B8 __Marshaller_api_SelectSubSeasonIdolArgs Marshaller`1<SelectSubSeasonIdolArgs> IL2CPP_TYPE_GENERICINST
    // 2C0 __Marshaller_api_SelectSubSeasonIdolReply Marshaller`1<SelectSubSeasonIdolReply> IL2CPP_TYPE_GENERICINST
    // 2C8 __Marshaller_api_ProduceFailureResultArgs Marshaller`1<ProduceFailureResultArgs> IL2CPP_TYPE_GENERICINST
    // 2D0 __Marshaller_api_ProduceFailureResultReply Marshaller`1<ProduceFailureResultReply> IL2CPP_TYPE_GENERICINST
    // 2D8 __Marshaller_api_InheritanceSkillListArgs Marshaller`1<InheritanceSkillListArgs> IL2CPP_TYPE_GENERICINST
    // 2E0 __Marshaller_api_InheritanceSkillListReply Marshaller`1<InheritanceSkillListReply> IL2CPP_TYPE_GENERICINST
    // 2E8 __Marshaller_api_SelectInheritanceSkillArgs Marshaller`1<SelectInheritanceSkillArgs> IL2CPP_TYPE_GENERICINST
    // 2F0 __Marshaller_api_SelectInheritanceSkillReply Marshaller`1<SelectInheritanceSkillReply> IL2CPP_TYPE_GENERICINST
    // 2F8 __Marshaller_api_GetProduceAutoPlayProgressArgs Marshaller`1<GetProduceAutoPlayProgressArgs> IL2CPP_TYPE_GENERICINST
    // 300 __Marshaller_api_GetProduceAutoPlayProgressReply Marshaller`1<GetProduceAutoPlayProgressReply> IL2CPP_TYPE_GENERICINST
    // 308 __Marshaller_api_CancelProduceAutoPlayArgs Marshaller`1<CancelProduceAutoPlayArgs> IL2CPP_TYPE_GENERICINST
    // 310 __Marshaller_api_CancelProduceAutoPlayReply Marshaller`1<CancelProduceAutoPlayReply> IL2CPP_TYPE_GENERICINST
    // 318 __Marshaller_api_GetProduceAdvListArgs   Marshaller`1<GetProduceAdvListArgs> IL2CPP_TYPE_GENERICINST
    // 320 __Marshaller_api_GetProduceAdvListReply  Marshaller`1<GetProduceAdvListReply> IL2CPP_TYPE_GENERICINST
    // 328 __Marshaller_api_StartScheduleMiniLiveArgs Marshaller`1<StartScheduleMiniLiveArgs> IL2CPP_TYPE_GENERICINST
    // 330 __Marshaller_api_StartScheduleMiniLiveReply Marshaller`1<StartScheduleMiniLiveReply> IL2CPP_TYPE_GENERICINST
    // 338 __Marshaller_api_FinishScheduleMiniLiveArgs Marshaller`1<FinishScheduleMiniLiveArgs> IL2CPP_TYPE_GENERICINST
    // 340 __Marshaller_api_FinishScheduleMiniLiveReply Marshaller`1<FinishScheduleMiniLiveReply> IL2CPP_TYPE_GENERICINST
    // 348 __Marshaller_api_StartScheduleTalkShowArgs Marshaller`1<StartScheduleTalkShowArgs> IL2CPP_TYPE_GENERICINST
    // 350 __Marshaller_api_StartScheduleTalkShowReply Marshaller`1<StartScheduleTalkShowReply> IL2CPP_TYPE_GENERICINST
    // 358 __Marshaller_api_FinishScheduleTalkShowArgs Marshaller`1<FinishScheduleTalkShowArgs> IL2CPP_TYPE_GENERICINST
    // 360 __Marshaller_api_FinishScheduleTalkShowReply Marshaller`1<FinishScheduleTalkShowReply> IL2CPP_TYPE_GENERICINST
    // 368 __Method_GetProduceUnit                  Method`2<GetProduceUnitArgs, GetProduceUnitReply> IL2CPP_TYPE_GENERICINST
    // 370 __Method_SetProduceUnit                  Method`2<SetProduceUnitArgs, SetProduceUnitReply> IL2CPP_TYPE_GENERICINST
    // 378 __Method_GetFriendSupportCharacterList   Method`2<GetFriendSupportCharacterListArgs, GetFriendSupportCharacterListReply> IL2CPP_TYPE_GENERICINST
    // 380 __Method_StartProduce                    Method`2<StartProduceArgs, StartProduceReply> IL2CPP_TYPE_GENERICINST
    // 388 __Method_GetProduceResume                Method`2<GetProduceResumeArgs, GetProduceResumeReply> IL2CPP_TYPE_GENERICINST
    // 390 __Method_GetProduceTop                   Method`2<GetProduceTopArgs, GetProduceTopReply> IL2CPP_TYPE_GENERICINST
    // 398 __Method_GetEpisodeList                  Method`2<GetEpisodeListArgs, GetEpisodeListReply> IL2CPP_TYPE_GENERICINST
    // 3A0 __Method_ProduceStrategyList             Method`2<ProduceStrategyListArgs, ProduceStrategyListReply> IL2CPP_TYPE_GENERICINST
    // 3A8 __Method_SelectProduceStrategy           Method`2<SelectProduceStrategyArgs, SelectProduceStrategyReply> IL2CPP_TYPE_GENERICINST
    // 3B0 __Method_SelectProduceStrategyReward     Method`2<SelectProduceStrategyRewardArgs, SelectProduceStrategyRewardReply> IL2CPP_TYPE_GENERICINST
    // 3B8 __Method_SelectSchedule                  Method`2<SelectScheduleArgs, SelectScheduleReply> IL2CPP_TYPE_GENERICINST
    // 3C0 __Method_StartScheduleRest               Method`2<StartScheduleRestArgs, StartScheduleRestReply> IL2CPP_TYPE_GENERICINST
    // 3C8 __Method_FinishScheduleRest              Method`2<FinishScheduleRestArgs, FinishScheduleRestReply> IL2CPP_TYPE_GENERICINST
    // 3D0 __Method_StartScheduleTraining           Method`2<StartScheduleTrainingArgs, StartScheduleTrainingReply> IL2CPP_TYPE_GENERICINST
    // 3D8 __Method_FinishScheduleTraining          Method`2<FinishScheduleTrainingArgs, FinishScheduleTrainingReply> IL2CPP_TYPE_GENERICINST
    // 3E0 __Method_StartScheduleWorking            Method`2<StartScheduleWorkingArgs, StartScheduleWorkingReply> IL2CPP_TYPE_GENERICINST
    // 3E8 __Method_FinishScheduleWorking           Method`2<FinishScheduleWorkingArgs, FinishScheduleWorkingReply> IL2CPP_TYPE_GENERICINST
    // 3F0 __Method_StartScheduleOuting             Method`2<StartScheduleOutingArgs, StartScheduleOutingReply> IL2CPP_TYPE_GENERICINST
    // 3F8 __Method_FinishScheduleOuting            Method`2<FinishScheduleOutingArgs, FinishScheduleOutingReply> IL2CPP_TYPE_GENERICINST
    // 400 __Method_StartScheduleShopping           Method`2<StartScheduleShoppingArgs, StartScheduleShoppingReply> IL2CPP_TYPE_GENERICINST
    // 408 __Method_FinishScheduleShopping          Method`2<FinishScheduleShoppingArgs, FinishScheduleShoppingReply> IL2CPP_TYPE_GENERICINST
    // 410 __Method_StartScheduleAdvice             Method`2<StartScheduleAdviceArgs, StartScheduleAdviceReply> IL2CPP_TYPE_GENERICINST
    // 418 __Method_FinishScheduleAdvice            Method`2<FinishScheduleAdviceArgs, FinishScheduleAdviceReply> IL2CPP_TYPE_GENERICINST
    // 420 __Method_StartLesson                     Method`2<StartLessonArgs, StartLessonReply> IL2CPP_TYPE_GENERICINST
    // 428 __Method_FinishLesson                    Method`2<FinishLessonArgs, FinishLessonReply> IL2CPP_TYPE_GENERICINST
    // 430 __Method_FinishLessonResult              Method`2<FinishLessonResultArgs, FinishLessonResultReply> IL2CPP_TYPE_GENERICINST
    // 438 __Method_StartSpecialLesson              Method`2<StartSpecialLessonArgs, StartSpecialLessonReply> IL2CPP_TYPE_GENERICINST
    // 440 __Method_FinishSpecialLesson             Method`2<FinishSpecialLessonArgs, FinishSpecialLessonReply> IL2CPP_TYPE_GENERICINST
    // 448 __Method_CardRankUp                      Method`2<CardRankUpArgs, CardRankUpReply> IL2CPP_TYPE_GENERICINST
    // 450 __Method_StartAudition                   Method`2<StartAuditionArgs, StartAuditionReply> IL2CPP_TYPE_GENERICINST
    // 458 __Method_FinishAudition                  Method`2<FinishAuditionArgs, FinishAuditionReply> IL2CPP_TYPE_GENERICINST
    // 460 __Method_FinishAuditionResult            Method`2<FinishAuditionResultArgs, FinishAuditionResultReply> IL2CPP_TYPE_GENERICINST
    // 468 __Method_StartSupportCooperationEvent    Method`2<StartSupportCooperationEventArgs, StartSupportCooperationEventReply> IL2CPP_TYPE_GENERICINST
    // 470 __Method_FinishSupportCooperationEvent   Method`2<FinishSupportCooperationEventArgs, FinishSupportCooperationEventReply> IL2CPP_TYPE_GENERICINST
    // 478 __Method_StartProduceAdv                 Method`2<StartProduceAdvArgs, StartProduceAdvReply> IL2CPP_TYPE_GENERICINST
    // 480 __Method_SelectProduceAdvOption          Method`2<SelectProduceAdvOptionArgs, SelectProduceAdvOptionReply> IL2CPP_TYPE_GENERICINST
    // 488 __Method_FinishProduceAdv                Method`2<FinishProduceAdvArgs, FinishProduceAdvReply> IL2CPP_TYPE_GENERICINST
    // 490 __Method_ProduceResult                   Method`2<ProduceResultArgs, ProduceResultReply> IL2CPP_TYPE_GENERICINST
    // 498 __Method_DetermineProduceResult          Method`2<DetermineProduceResultArgs, DetermineProduceResultReply> IL2CPP_TYPE_GENERICINST
    // 4A0 __Method_ProduceMV                       Method`2<ProduceMVArgs, ProduceMVReply> IL2CPP_TYPE_GENERICINST
    // 4A8 __Method_FinishProduce                   Method`2<FinishProduceArgs, FinishProduceReply> IL2CPP_TYPE_GENERICINST
    // 4B0 __Method_SubSeasonList                   Method`2<SubSeasonListArgs, SubSeasonListReply> IL2CPP_TYPE_GENERICINST
    // 4B8 __Method_SelectSubSeason                 Method`2<SelectSubSeasonArgs, SelectSubSeasonReply> IL2CPP_TYPE_GENERICINST
    // 4C0 __Method_SelectSubSeasonIdol             Method`2<SelectSubSeasonIdolArgs, SelectSubSeasonIdolReply> IL2CPP_TYPE_GENERICINST
    // 4C8 __Method_ProduceFailureResult            Method`2<ProduceFailureResultArgs, ProduceFailureResultReply> IL2CPP_TYPE_GENERICINST
    // 4D0 __Method_InheritanceSkillList            Method`2<InheritanceSkillListArgs, InheritanceSkillListReply> IL2CPP_TYPE_GENERICINST
    // 4D8 __Method_SelectInheritanceSkill          Method`2<SelectInheritanceSkillArgs, SelectInheritanceSkillReply> IL2CPP_TYPE_GENERICINST
    // 4E0 __Method_GetProduceAutoPlayProgress      Method`2<GetProduceAutoPlayProgressArgs, GetProduceAutoPlayProgressReply> IL2CPP_TYPE_GENERICINST
    // 4E8 __Method_CancelProduceAutoPlay           Method`2<CancelProduceAutoPlayArgs, CancelProduceAutoPlayReply> IL2CPP_TYPE_GENERICINST
    // 4F0 __Method_GetProduceAdvList               Method`2<GetProduceAdvListArgs, GetProduceAdvListReply> IL2CPP_TYPE_GENERICINST
    // 4F8 __Method_StartScheduleMiniLive           Method`2<StartScheduleMiniLiveArgs, StartScheduleMiniLiveReply> IL2CPP_TYPE_GENERICINST
    // 500 __Method_FinishScheduleMiniLive          Method`2<FinishScheduleMiniLiveArgs, FinishScheduleMiniLiveReply> IL2CPP_TYPE_GENERICINST
    // 508 __Method_StartScheduleTalkShow           Method`2<StartScheduleTalkShowArgs, StartScheduleTalkShowReply> IL2CPP_TYPE_GENERICINST
    // 510 __Method_FinishScheduleTalkShow          Method`2<FinishScheduleTalkShowArgs, FinishScheduleTalkShowReply> IL2CPP_TYPE_GENERICINST
    public partial class ProduceService
    {

        public static ProduceService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceService();


            return value;
        }
    }
}
