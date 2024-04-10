using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ResourceTag                              000186672320 ModelClassType ResourceTag ResourceTag ResourceTag Pointer
    // 028 onClickEnemySkillIconSubject             Subject`1<ValueTuple`2<int, IngameSkillModel>> IL2CPP_TYPE_GENERICINST
    // 030 onClickRetryButtonSubject                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 onClickGiveUpButtonSubject               Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 onClickProduceOptionButtonSubject        Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 onClickCloseButtonSubject                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 EnemySkillContentListView                000186732D20 ModelClassType EnemySkillContentListView EnemySkillContentListView EnemySkillContentListView Pointer
    // 058 RetryButton                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 060 GiveUpButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 068 ChallengeMissionContent                  00018656BDA0 ModelClassType ChallengeMissionContent ChallengeMissionContent ChallengeMissionContent Pointer
    // 070 NotExistChallengeMissionUI               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 ProduceOptionButton                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 080 OptionPopupViewFactory                   000186560F20 ModelClassType ProduceOptionPopupViewFactory ProduceOptionPopupViewFactory ProduceOptionPopupViewFactory Pointer
    // 088 EnemySkillDetailPopupViewFactory         00018653D6F0 ModelClassType ProduceEnemySkillDetailPopupViewFactory ProduceEnemySkillDetailPopupViewFactory ProduceEnemySkillDetailPopupViewFactory Pointer
    // 090 ViewModel                                00018655A5A0 ModelClassType ProduceInGamePausePopupViewModel ProduceInGamePausePopupViewModel ProduceInGamePausePopupViewModel Pointer
    // 098 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProduceInGamePausePopupView : DataModel
    {
        public ResourceTag?                             ResourceTag                             { get; set; }
        public EnemySkillContentListView?               EnemySkillContentListView               { get; set; }
        public UIButton?                                RetryButton                             { get; set; }
        public UIButton?                                GiveUpButton                            { get; set; }
        public ChallengeMissionContent?                 ChallengeMissionContent                 { get; set; }
        public GameObject?                              NotExistChallengeMissionUI              { get; set; }
        public UIButton?                                ProduceOptionButton                     { get; set; }
        public ProduceOptionPopupViewFactory?           OptionPopupViewFactory                  { get; set; }
        public ProduceEnemySkillDetailPopupViewFactory? EnemySkillDetailPopupViewFactory        { get; set; }
        public ProduceInGamePausePopupViewModel?        ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProduceInGamePausePopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceInGamePausePopupView() { Pointer= p0 };

            value.ResourceTag                               = GetObject<ResourceTag>(new IntPtr(p + 0x020), ReversePrism.DataModels.ResourceTag.FromPointer); // 02466A13E700 0x20 ResourceTag                 ( 000186672320 ModelClassType ResourceTag ResourceTag ResourceTag Pointer )
            value.EnemySkillContentListView                 = GetObject<EnemySkillContentListView>(new IntPtr(p + 0x050), ReversePrism.DataModels.EnemySkillContentListView.FromPointer); // 02466A13E7C0 0x50 EnemySkillContentListView   ( 000186732D20 ModelClassType EnemySkillContentListView EnemySkillContentListView EnemySkillContentListView Pointer )
            value.RetryButton                               = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 02466A13E7E0 0x58 RetryButton                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.GiveUpButton                              = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 02466A13E800 0x60 GiveUpButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ChallengeMissionContent                   = GetObject<ChallengeMissionContent>(new IntPtr(p + 0x068), ReversePrism.DataModels.ChallengeMissionContent.FromPointer); // 02466A13E820 0x68 ChallengeMissionContent     ( 00018656BDA0 ModelClassType ChallengeMissionContent ChallengeMissionContent ChallengeMissionContent Pointer )
            value.NotExistChallengeMissionUI                = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 02466A13E840 0x70 NotExistChallengeMissionUI  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ProduceOptionButton                       = GetObject<UIButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIButton.FromPointer); // 02466A13E860 0x78 ProduceOptionButton         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.OptionPopupViewFactory                    = GetObject<ProduceOptionPopupViewFactory>(new IntPtr(p + 0x080), ReversePrism.DataModels.ProduceOptionPopupViewFactory.FromPointer); // 02466A13E880 0x80 OptionPopupViewFactory      ( 000186560F20 ModelClassType ProduceOptionPopupViewFactory ProduceOptionPopupViewFactory ProduceOptionPopupViewFactory Pointer )
            value.EnemySkillDetailPopupViewFactory          = GetObject<ProduceEnemySkillDetailPopupViewFactory>(new IntPtr(p + 0x088), ReversePrism.DataModels.ProduceEnemySkillDetailPopupViewFactory.FromPointer); // 02466A13E8A0 0x88 EnemySkillDetailPopupViewFactory ( 00018653D6F0 ModelClassType ProduceEnemySkillDetailPopupViewFactory ProduceEnemySkillDetailPopupViewFactory ProduceEnemySkillDetailPopupViewFactory Pointer )
            value.ViewModel                                 = GetObject<ProduceInGamePausePopupViewModel>(new IntPtr(p + 0x090), ReversePrism.DataModels.ProduceInGamePausePopupViewModel.FromPointer); // 02466A13E8C0 0x90 ViewModel                   ( 00018655A5A0 ModelClassType ProduceInGamePausePopupViewModel ProduceInGamePausePopupViewModel ProduceInGamePausePopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x098), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466A13E8E0 0x98 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
