using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 StagePinView                             000186583BF0 ModelClassType ChallengeTourStagePinPanelView ChallengeTourStagePinPanelView ChallengeTourStagePinPanelView Pointer
    // 028 InfoPanelView                            000186580630 ModelClassType ChallengeTourStageDetailInfoPanelView ChallengeTourStageDetailInfoPanelView ChallengeTourStageDetailInfoPanelView Pointer
    // 030 EnemyInfoPanelView                       00018656D700 ModelClassType ChallengeTourEnemyInfoPanelView ChallengeTourEnemyInfoPanelView ChallengeTourEnemyInfoPanelView Pointer
    // 038 UnitDeckPanelView                        000186585800 ModelClassType ChallengeTourStageUnitDeckPanelView ChallengeTourStageUnitDeckPanelView ChallengeTourStageUnitDeckPanelView Pointer
    // 040 BackgroundImage                          0001866CCDB0 ModelClassType Image Image Image Pointer
    // 048 LeftButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 050 RightButton                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 058 CloseButton                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 060 DecideButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 068 OpenAnimator                             0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 070 stageMissionInfoPopupFactory             PopupViewFactory`1<IChallengeTourStageMissionInfoPopupView> IL2CPP_TYPE_GENERICINST
    // 078 fUnitDetailPopupViewFactory              PopupViewFactory`1<IFUnitDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 080 enemySkillDetailPopupViewFactory         PopupViewFactory`1<IProduceEnemySkillDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 088 pIdolUnitDetailPopupViewFactory          PopupViewFactory`1<IChallengeTourPIdolUnitDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 090 customPopup                              AssetCollection`1<PopupContentBase> IL2CPP_TYPE_GENERICINST
    // 098 UnitViewModel                            00018658D950 ModelClassType ChallengeTourUnitViewModel ChallengeTourUnitViewModel ChallengeTourUnitViewModel Pointer
    // 0A0 StageViewModel                           000186585EB0 ModelClassType ChallengeTourStageViewModel ChallengeTourStageViewModel ChallengeTourStageViewModel Pointer
    // 0A8 IsAnimation                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0B0 BackKeyDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 0B8 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class ChallengeTourStageDetailOverlayView
    {
        public ChallengeTourStagePinPanelView?          StagePinView                            { get; set; }
        public ChallengeTourStageDetailInfoPanelView?   InfoPanelView                           { get; set; }
        public ChallengeTourEnemyInfoPanelView?         EnemyInfoPanelView                      { get; set; }
        public ChallengeTourStageUnitDeckPanelView?     UnitDeckPanelView                       { get; set; }
        public Image?                                   BackgroundImage                         { get; set; }
        public UIButton?                                LeftButton                              { get; set; }
        public UIButton?                                RightButton                             { get; set; }
        public UIButton?                                CloseButton                             { get; set; }
        public UIButton?                                DecideButton                            { get; set; }
        public Animator?                                OpenAnimator                            { get; set; }
        public ChallengeTourUnitViewModel?              UnitViewModel                           { get; set; }
        public ChallengeTourStageViewModel?             StageViewModel                          { get; set; }
        public bool                                     IsAnimation                             { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static ChallengeTourStageDetailOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourStageDetailOverlayView();

            value.StagePinView                              = GetObject<ChallengeTourStagePinPanelView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChallengeTourStagePinPanelView.FromPointer); // 0270DA1B50B0 0x20 StagePinView                ( 000186583BF0 ModelClassType ChallengeTourStagePinPanelView ChallengeTourStagePinPanelView ChallengeTourStagePinPanelView Pointer )
            value.InfoPanelView                             = GetObject<ChallengeTourStageDetailInfoPanelView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ChallengeTourStageDetailInfoPanelView.FromPointer); // 0270DA1B50D0 0x28 InfoPanelView               ( 000186580630 ModelClassType ChallengeTourStageDetailInfoPanelView ChallengeTourStageDetailInfoPanelView ChallengeTourStageDetailInfoPanelView Pointer )
            value.EnemyInfoPanelView                        = GetObject<ChallengeTourEnemyInfoPanelView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChallengeTourEnemyInfoPanelView.FromPointer); // 0270DA1B50F0 0x30 EnemyInfoPanelView          ( 00018656D700 ModelClassType ChallengeTourEnemyInfoPanelView ChallengeTourEnemyInfoPanelView ChallengeTourEnemyInfoPanelView Pointer )
            value.UnitDeckPanelView                         = GetObject<ChallengeTourStageUnitDeckPanelView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChallengeTourStageUnitDeckPanelView.FromPointer); // 0270DA1B5110 0x38 UnitDeckPanelView           ( 000186585800 ModelClassType ChallengeTourStageUnitDeckPanelView ChallengeTourStageUnitDeckPanelView ChallengeTourStageUnitDeckPanelView Pointer )
            value.BackgroundImage                           = GetObject<Image>(new IntPtr(p + 0x040), ReversePrism.DataModels.Image.FromPointer); // 0270DA1B5130 0x40 BackgroundImage             ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.LeftButton                                = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA1B5150 0x48 LeftButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.RightButton                               = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA1B5170 0x50 RightButton                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CloseButton                               = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA1B5190 0x58 CloseButton                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.DecideButton                              = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA1B51B0 0x60 DecideButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.OpenAnimator                              = GetObject<Animator>(new IntPtr(p + 0x068), ReversePrism.DataModels.Animator.FromPointer); // 0270DA1B51D0 0x68 OpenAnimator                ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.UnitViewModel                             = GetObject<ChallengeTourUnitViewModel>(new IntPtr(p + 0x098), ReversePrism.DataModels.ChallengeTourUnitViewModel.FromPointer); // 0270DA1B5290 0x98 UnitViewModel               ( 00018658D950 ModelClassType ChallengeTourUnitViewModel ChallengeTourUnitViewModel ChallengeTourUnitViewModel Pointer )
            value.StageViewModel                            = GetObject<ChallengeTourStageViewModel>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ChallengeTourStageViewModel.FromPointer); // 0270DA1B52B0 0xA0 StageViewModel              ( 000186585EB0 ModelClassType ChallengeTourStageViewModel ChallengeTourStageViewModel ChallengeTourStageViewModel Pointer )
            value.IsAnimation                               = GetBool(new IntPtr(p + 0x0A8)); // 0270DA1B52D0 0xA8 IsAnimation                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DA1B52F0 0xB0 BackKeyDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DA1B5310 0xB8 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
