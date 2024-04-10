using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetProduceUnit                           Method`2<IGetProduceUnitArgs, IGetProduceUnitReply> IL2CPP_TYPE_GENERICINST
    // 018 SetProduceUnit                           Method`2<ISetProduceUnitArgs, ISetProduceUnitReply> IL2CPP_TYPE_GENERICINST
    // 030 GetFriendSupportCharacterList            Method`2<IGetFriendSupportCharacterListArgs, IGetFriendSupportCharacterListReply> IL2CPP_TYPE_GENERICINST
    // 048 StartProduce                             Method`2<IStartProduceArgs, IStartProduceReply> IL2CPP_TYPE_GENERICINST
    // 060 GetProduceResume                         Method`2<IGetProduceResumeArgs, IGetProduceResumeReply> IL2CPP_TYPE_GENERICINST
    // 078 GetProduceTop                            Method`2<IGetProduceTopArgs, IGetProduceTopReply> IL2CPP_TYPE_GENERICINST
    // 090 GetEpisodeList                           Method`2<IGetEpisodeListArgs, IGetEpisodeListReply> IL2CPP_TYPE_GENERICINST
    // 0A8 ProduceStrategyList                      Method`2<IProduceStrategyListArgs, IProduceStrategyListReply> IL2CPP_TYPE_GENERICINST
    // 0C0 SelectProduceStrategy                    Method`2<ISelectProduceStrategyArgs, ISelectProduceStrategyReply> IL2CPP_TYPE_GENERICINST
    // 0D8 SelectProduceStrategyReward              Method`2<ISelectProduceStrategyRewardArgs, ISelectProduceStrategyRewardReply> IL2CPP_TYPE_GENERICINST
    // 0F0 SelectSchedule                           Method`2<ISelectScheduleArgs, ISelectScheduleReply> IL2CPP_TYPE_GENERICINST
    // 108 StartScheduleRest                        Method`2<IStartScheduleRestArgs, IStartScheduleRestReply> IL2CPP_TYPE_GENERICINST
    // 120 FinishScheduleRest                       Method`2<IFinishScheduleRestArgs, IFinishScheduleRestReply> IL2CPP_TYPE_GENERICINST
    // 138 StartScheduleTraining                    Method`2<IStartScheduleTrainingArgs, IStartScheduleTrainingReply> IL2CPP_TYPE_GENERICINST
    // 150 FinishScheduleTraining                   Method`2<IFinishScheduleTrainingArgs, IFinishScheduleTrainingReply> IL2CPP_TYPE_GENERICINST
    // 168 StartScheduleWorking                     Method`2<IStartScheduleWorkingArgs, IStartScheduleWorkingReply> IL2CPP_TYPE_GENERICINST
    // 180 FinishScheduleWorking                    Method`2<IFinishScheduleWorkingArgs, IFinishScheduleWorkingReply> IL2CPP_TYPE_GENERICINST
    // 198 StartScheduleOuting                      Method`2<IStartScheduleOutingArgs, IStartScheduleOutingReply> IL2CPP_TYPE_GENERICINST
    // 1B0 FinishScheduleOuting                     Method`2<IFinishScheduleOutingArgs, IFinishScheduleOutingReply> IL2CPP_TYPE_GENERICINST
    // 1C8 StartScheduleShopping                    Method`2<IStartScheduleShoppingArgs, IStartScheduleShoppingReply> IL2CPP_TYPE_GENERICINST
    // 1E0 FinishScheduleShopping                   Method`2<IFinishScheduleShoppingArgs, IFinishScheduleShoppingReply> IL2CPP_TYPE_GENERICINST
    // 1F8 StartScheduleAdvice                      Method`2<IStartScheduleAdviceArgs, IStartScheduleAdviceReply> IL2CPP_TYPE_GENERICINST
    // 210 FinishScheduleAdvice                     Method`2<IFinishScheduleAdviceArgs, IFinishScheduleAdviceReply> IL2CPP_TYPE_GENERICINST
    // 228 StartLesson                              Method`2<IStartLessonArgs, IStartLessonReply> IL2CPP_TYPE_GENERICINST
    // 240 FinishLesson                             Method`2<IFinishLessonArgs, IFinishLessonReply> IL2CPP_TYPE_GENERICINST
    // 258 FinishLessonResult                       Method`2<IFinishLessonResultArgs, IFinishLessonResultReply> IL2CPP_TYPE_GENERICINST
    // 270 StartSpecialLesson                       Method`2<IStartSpecialLessonArgs, IStartSpecialLessonReply> IL2CPP_TYPE_GENERICINST
    // 288 FinishSpecialLesson                      Method`2<IFinishSpecialLessonArgs, IFinishSpecialLessonReply> IL2CPP_TYPE_GENERICINST
    // 2A0 CardRankUp                               Method`2<ICardRankUpArgs, ICardRankUpReply> IL2CPP_TYPE_GENERICINST
    // 2B8 StartAudition                            Method`2<IStartAuditionArgs, IStartAuditionReply> IL2CPP_TYPE_GENERICINST
    // 2D0 FinishAudition                           Method`2<IFinishAuditionArgs, IFinishAuditionReply> IL2CPP_TYPE_GENERICINST
    // 2E8 FinishAuditionResult                     Method`2<IFinishAuditionResultArgs, IFinishAuditionResultReply> IL2CPP_TYPE_GENERICINST
    // 300 StartSupportCooperationEvent             Method`2<IStartSupportCooperationEventArgs, IStartSupportCooperationEventReply> IL2CPP_TYPE_GENERICINST
    // 318 FinishSupportCooperationEvent            Method`2<IFinishSupportCooperationEventArgs, IFinishSupportCooperationEventReply> IL2CPP_TYPE_GENERICINST
    // 330 StartProduceAdv                          Method`2<IStartProduceAdvArgs, IStartProduceAdvReply> IL2CPP_TYPE_GENERICINST
    // 348 SelectProduceAdvOption                   Method`2<ISelectProduceAdvOptionArgs, ISelectProduceAdvOptionReply> IL2CPP_TYPE_GENERICINST
    // 360 FinishProduceAdv                         Method`2<IFinishProduceAdvArgs, IFinishProduceAdvReply> IL2CPP_TYPE_GENERICINST
    // 378 ProduceResult                            Method`2<IProduceResultArgs, IProduceResultReply> IL2CPP_TYPE_GENERICINST
    // 390 DetermineProduceResult                   Method`2<IDetermineProduceResultArgs, IDetermineProduceResultReply> IL2CPP_TYPE_GENERICINST
    // 3A8 ProduceMV                                Method`2<IProduceMVArgs, IProduceMVReply> IL2CPP_TYPE_GENERICINST
    // 3C0 FinishProduce                            Method`2<IFinishProduceArgs, IFinishProduceReply> IL2CPP_TYPE_GENERICINST
    // 3D8 SubSeasonList                            Method`2<ISubSeasonListArgs, ISubSeasonListReply> IL2CPP_TYPE_GENERICINST
    // 3F0 SelectSubSeason                          Method`2<ISelectSubSeasonArgs, ISelectSubSeasonReply> IL2CPP_TYPE_GENERICINST
    // 408 SelectSubSeasonIdol                      Method`2<ISelectSubSeasonIdolArgs, ISelectSubSeasonIdolReply> IL2CPP_TYPE_GENERICINST
    // 420 ProduceFailureResult                     Method`2<IProduceFailureResultArgs, IProduceFailureResultReply> IL2CPP_TYPE_GENERICINST
    // 438 InheritanceSkillList                     Method`2<IInheritanceSkillListArgs, IInheritanceSkillListReply> IL2CPP_TYPE_GENERICINST
    // 450 SelectInheritanceSkill                   Method`2<ISelectInheritanceSkillArgs, ISelectInheritanceSkillReply> IL2CPP_TYPE_GENERICINST
    // 468 GetProduceAutoPlayProgress               Method`2<IGetProduceAutoPlayProgressArgs, IGetProduceAutoPlayProgressReply> IL2CPP_TYPE_GENERICINST
    // 480 CancelProduceAutoPlay                    Method`2<ICancelProduceAutoPlayArgs, ICancelProduceAutoPlayReply> IL2CPP_TYPE_GENERICINST
    // 498 GetProduceAdvList                        Method`2<IGetProduceAdvListArgs, IGetProduceAdvListReply> IL2CPP_TYPE_GENERICINST
    // 4B0 StartScheduleMiniLive                    Method`2<IStartScheduleMiniLiveArgs, IStartScheduleMiniLiveReply> IL2CPP_TYPE_GENERICINST
    // 4C8 FinishScheduleMiniLive                   Method`2<IFinishScheduleMiniLiveArgs, IFinishScheduleMiniLiveReply> IL2CPP_TYPE_GENERICINST
    // 4E0 StartScheduleTalkShow                    Method`2<IStartScheduleTalkShowArgs, IStartScheduleTalkShowReply> IL2CPP_TYPE_GENERICINST
    // 4F8 FinishScheduleTalkShow                   Method`2<IFinishScheduleTalkShowArgs, IFinishScheduleTalkShowReply> IL2CPP_TYPE_GENERICINST
    public partial class ProduceServiceMethods : DataModel
    {

        public static ProduceServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceServiceMethods() { Pointer= p0 };


            return value;
        }
    }
}
