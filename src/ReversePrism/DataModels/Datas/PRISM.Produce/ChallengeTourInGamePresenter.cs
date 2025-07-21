using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 ChallengeTourInGameView                  ModelClassType ChallengeTourInGameView ChallengeTourInGameView ChallengeTourInGameView Pointer
    // 088 ChallengeTourInGameModel                 ModelClassType ChallengeTourInGameModel ChallengeTourInGameModel ChallengeTourInGameModel Pointer
    // 090 MissionList                              ModelClassListType IReadOnlyList`1<IChallengeTourStageRewardStatus> IReadOnlyList`1<IChallengeTourStageRewardStatus> List<IChallengeTourStageRewardStatus> Pointer
    // 098 CacheLessonAuditionSource                ModelClassType LessonAudition LessonAudition LessonAudition Pointer
    public partial class ChallengeTourInGamePresenter : DataModel
    {
        public ChallengeTourInGameView?                 ChallengeTourInGameView                 { get; set; }
        public ChallengeTourInGameModel?                ChallengeTourInGameModel                { get; set; }
        public List<IChallengeTourStageRewardStatus>?   MissionList                             { get; set; }
        public LessonAudition?                          CacheLessonAuditionSource               { get; set; }

        public static ChallengeTourInGamePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourInGamePresenter() { Pointer= p0 };

            value.ChallengeTourInGameView                   = GetObject<ChallengeTourInGameView>(new IntPtr(p + 0x080), ReversePrism.DataModels.ChallengeTourInGameView.FromPointer); // 0x80 ChallengeTourInGameView     ( ModelClassType ChallengeTourInGameView ChallengeTourInGameView ChallengeTourInGameView Pointer )
            value.ChallengeTourInGameModel                  = GetObject<ChallengeTourInGameModel>(new IntPtr(p + 0x088), ReversePrism.DataModels.ChallengeTourInGameModel.FromPointer); // 0x88 ChallengeTourInGameModel    ( ModelClassType ChallengeTourInGameModel ChallengeTourInGameModel ChallengeTourInGameModel Pointer )
            value.MissionList                               = GetObjectList<IChallengeTourStageRewardStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.IChallengeTourStageRewardStatus.FromPointer); // 0x90 MissionList                 ( ModelClassListType IReadOnlyList`1<IChallengeTourStageRewardStatus> IReadOnlyList`1<IChallengeTourStageRewardStatus> List<IChallengeTourStageRewardStatus> Pointer )
            value.CacheLessonAuditionSource                 = GetObject<LessonAudition>(new IntPtr(p + 0x098), ReversePrism.DataModels.LessonAudition.FromPointer); // 0x98 CacheLessonAuditionSource   ( ModelClassType LessonAudition LessonAudition LessonAudition Pointer )

            return value;
        }
    }
}
