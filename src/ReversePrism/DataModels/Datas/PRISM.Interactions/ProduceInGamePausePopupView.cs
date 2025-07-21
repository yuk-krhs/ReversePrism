using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 onClickEnemySkillIconSubject             Subject`1<ValueTuple`2<int, IngameSkillModel>> IL2CPP_TYPE_GENERICINST
    // 028 onClickRetryButtonSubject                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 onClickGiveUpButtonSubject               Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 onClickProduceOptionButtonSubject        Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 onClickCloseButtonSubject                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 EnemySkillContentListView                ModelClassType EnemySkillContentListView EnemySkillContentListView EnemySkillContentListView Pointer
    // 050 RetryButton                              ModelClassType UIButton UIButton UIButton Pointer
    // 058 GiveUpButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 060 ChallengeMissionContent                  ModelClassType ChallengeMissionContent ChallengeMissionContent ChallengeMissionContent Pointer
    // 068 NotExistChallengeMissionUI               ModelClassType GameObject GameObject GameObject Pointer
    // 070 ProduceOptionButton                      ModelClassType UIButton UIButton UIButton Pointer
    // 078 ViewModel                                ModelClassType ProduceInGamePausePopupViewModel ProduceInGamePausePopupViewModel ProduceInGamePausePopupViewModel Pointer
    // 080 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProduceInGamePausePopupView : DataModel
    {
        public EnemySkillContentListView?               EnemySkillContentListView               { get; set; }
        public UIButton?                                RetryButton                             { get; set; }
        public UIButton?                                GiveUpButton                            { get; set; }
        public ChallengeMissionContent?                 ChallengeMissionContent                 { get; set; }
        public GameObject?                              NotExistChallengeMissionUI              { get; set; }
        public UIButton?                                ProduceOptionButton                     { get; set; }
        public ProduceInGamePausePopupViewModel?        ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProduceInGamePausePopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceInGamePausePopupView() { Pointer= p0 };

            value.EnemySkillContentListView                 = GetObject<EnemySkillContentListView>(new IntPtr(p + 0x048), ReversePrism.DataModels.EnemySkillContentListView.FromPointer); // 0x48 EnemySkillContentListView   ( ModelClassType EnemySkillContentListView EnemySkillContentListView EnemySkillContentListView Pointer )
            value.RetryButton                               = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 RetryButton                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.GiveUpButton                              = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0x58 GiveUpButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ChallengeMissionContent                   = GetObject<ChallengeMissionContent>(new IntPtr(p + 0x060), ReversePrism.DataModels.ChallengeMissionContent.FromPointer); // 0x60 ChallengeMissionContent     ( ModelClassType ChallengeMissionContent ChallengeMissionContent ChallengeMissionContent Pointer )
            value.NotExistChallengeMissionUI                = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 NotExistChallengeMissionUI  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ProduceOptionButton                       = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0x70 ProduceOptionButton         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ViewModel                                 = GetObject<ProduceInGamePausePopupViewModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.ProduceInGamePausePopupViewModel.FromPointer); // 0x78 ViewModel                   ( ModelClassType ProduceInGamePausePopupViewModel ProduceInGamePausePopupViewModel ProduceInGamePausePopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x080), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x80 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
