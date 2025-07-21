using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EnemySkillContentListView                ModelClassType EnemySkillContentListView EnemySkillContentListView EnemySkillContentListView Pointer
    // 028 ChallengeTourStageMissionListView        ModelClassType ChallengeTourInGameMissionListView ChallengeTourInGameMissionListView ChallengeTourInGameMissionListView Pointer
    // 030 RetryButton                              ModelClassType UIButton UIButton UIButton Pointer
    // 038 GiveUpButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 040 ProduceOptionButton                      ModelClassType UIButton UIButton UIButton Pointer
    // 048 onClickEnemySkillIconSubject             Subject`1<ValueTuple`2<int, IngameSkillModel>> IL2CPP_TYPE_GENERICINST
    // 050 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ChallengeTourInGamePausePopupView : DataModel
    {
        public EnemySkillContentListView?               EnemySkillContentListView               { get; set; }
        public ChallengeTourInGameMissionListView?      ChallengeTourStageMissionListView       { get; set; }
        public UIButton?                                RetryButton                             { get; set; }
        public UIButton?                                GiveUpButton                            { get; set; }
        public UIButton?                                ProduceOptionButton                     { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ChallengeTourInGamePausePopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourInGamePausePopupView() { Pointer= p0 };

            value.EnemySkillContentListView                 = GetObject<EnemySkillContentListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.EnemySkillContentListView.FromPointer); // 0x20 EnemySkillContentListView   ( ModelClassType EnemySkillContentListView EnemySkillContentListView EnemySkillContentListView Pointer )
            value.ChallengeTourStageMissionListView         = GetObject<ChallengeTourInGameMissionListView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ChallengeTourInGameMissionListView.FromPointer); // 0x28 ChallengeTourStageMissionListView ( ModelClassType ChallengeTourInGameMissionListView ChallengeTourInGameMissionListView ChallengeTourInGameMissionListView Pointer )
            value.RetryButton                               = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 RetryButton                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.GiveUpButton                              = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 GiveUpButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ProduceOptionButton                       = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 ProduceOptionButton         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x58 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
