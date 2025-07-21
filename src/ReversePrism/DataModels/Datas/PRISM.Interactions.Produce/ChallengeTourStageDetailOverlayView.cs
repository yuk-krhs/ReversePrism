using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 StagePinView                             ModelClassType ChallengeTourStagePinPanelView ChallengeTourStagePinPanelView ChallengeTourStagePinPanelView Pointer
    // 028 InfoPanelView                            ModelClassType ChallengeTourStageDetailInfoPanelView ChallengeTourStageDetailInfoPanelView ChallengeTourStageDetailInfoPanelView Pointer
    // 030 EnemyInfoPanelView                       ModelClassType ChallengeTourEnemyInfoPanelView ChallengeTourEnemyInfoPanelView ChallengeTourEnemyInfoPanelView Pointer
    // 038 UnitDeckPanelView                        ModelClassType ChallengeTourStageUnitDeckPanelView ChallengeTourStageUnitDeckPanelView ChallengeTourStageUnitDeckPanelView Pointer
    // 040 BackgroundImage                          ModelClassType Image Image Image Pointer
    // 048 LeftButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 050 RightButton                              ModelClassType UIButton UIButton UIButton Pointer
    // 058 CloseButton                              ModelClassType UIButton UIButton UIButton Pointer
    // 060 DecideButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 068 OpenAnimator                             ModelClassType Animator Animator Animator Pointer
    // 070 DeckListPopupPrefab                      ModelClassType DeckListPopupContent DeckListPopupContent DeckListPopupContent Pointer
    // 078 StageViewModel                           ModelClassType ChallengeTourStageViewModel ChallengeTourStageViewModel ChallengeTourStageViewModel Pointer
    // 080 IsAnimation                              ModelPrimitiveType bool bool bool Bool
    // 088 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    // 090 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class ChallengeTourStageDetailOverlayView : DataModel
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
        public DeckListPopupContent?                    DeckListPopupPrefab                     { get; set; }
        public ChallengeTourStageViewModel?             StageViewModel                          { get; set; }
        public bool                                     IsAnimation                             { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static ChallengeTourStageDetailOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourStageDetailOverlayView() { Pointer= p0 };

            value.StagePinView                              = GetObject<ChallengeTourStagePinPanelView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChallengeTourStagePinPanelView.FromPointer); // 0x20 StagePinView                ( ModelClassType ChallengeTourStagePinPanelView ChallengeTourStagePinPanelView ChallengeTourStagePinPanelView Pointer )
            value.InfoPanelView                             = GetObject<ChallengeTourStageDetailInfoPanelView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ChallengeTourStageDetailInfoPanelView.FromPointer); // 0x28 InfoPanelView               ( ModelClassType ChallengeTourStageDetailInfoPanelView ChallengeTourStageDetailInfoPanelView ChallengeTourStageDetailInfoPanelView Pointer )
            value.EnemyInfoPanelView                        = GetObject<ChallengeTourEnemyInfoPanelView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChallengeTourEnemyInfoPanelView.FromPointer); // 0x30 EnemyInfoPanelView          ( ModelClassType ChallengeTourEnemyInfoPanelView ChallengeTourEnemyInfoPanelView ChallengeTourEnemyInfoPanelView Pointer )
            value.UnitDeckPanelView                         = GetObject<ChallengeTourStageUnitDeckPanelView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChallengeTourStageUnitDeckPanelView.FromPointer); // 0x38 UnitDeckPanelView           ( ModelClassType ChallengeTourStageUnitDeckPanelView ChallengeTourStageUnitDeckPanelView ChallengeTourStageUnitDeckPanelView Pointer )
            value.BackgroundImage                           = GetObject<Image>(new IntPtr(p + 0x040), ReversePrism.DataModels.Image.FromPointer); // 0x40 BackgroundImage             ( ModelClassType Image Image Image Pointer )
            value.LeftButton                                = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0x48 LeftButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.RightButton                               = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 RightButton                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CloseButton                               = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0x58 CloseButton                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.DecideButton                              = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0x60 DecideButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.OpenAnimator                              = GetObject<Animator>(new IntPtr(p + 0x068), ReversePrism.DataModels.Animator.FromPointer); // 0x68 OpenAnimator                ( ModelClassType Animator Animator Animator Pointer )
            value.DeckListPopupPrefab                       = GetObject<DeckListPopupContent>(new IntPtr(p + 0x070), ReversePrism.DataModels.DeckListPopupContent.FromPointer); // 0x70 DeckListPopupPrefab         ( ModelClassType DeckListPopupContent DeckListPopupContent DeckListPopupContent Pointer )
            value.StageViewModel                            = GetObject<ChallengeTourStageViewModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.ChallengeTourStageViewModel.FromPointer); // 0x78 StageViewModel              ( ModelClassType ChallengeTourStageViewModel ChallengeTourStageViewModel ChallengeTourStageViewModel Pointer )
            value.IsAnimation                               = GetBool(new IntPtr(p + 0x080)); // 0x80 IsAnimation                 ( ModelPrimitiveType bool bool bool Bool )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x088), ReversePrism.DataModels.IDisposable.FromPointer); // 0x88 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x090), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x90 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
