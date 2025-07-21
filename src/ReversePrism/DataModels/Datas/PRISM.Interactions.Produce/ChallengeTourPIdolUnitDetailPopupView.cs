using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabGroup                                 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 VoDaViMeRankView                         ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer
    // 030 ParameterDetailButton                    ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 PIdolUnitPanelViews                      ModelClassListType ChallengeTourPIdolUnitPanelView[] ChallengeTourPIdolUnitPanelView[] List<ChallengeTourPIdolUnitPanelView> Pointer
    // 040 GoPCardPrefab                            ModelClassType ProduceCardContent ProduceCardContent ProduceCardContent Pointer
    // 048 TrCardParent                             ModelClassType Transform Transform Transform Pointer
    // 050 CardCountText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 ShowObjects                              ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 060 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 068 onClickPIdol                             Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 070 ViewModel                                ModelClassType ChallengeTourUnitViewModel ChallengeTourUnitViewModel ChallengeTourUnitViewModel Pointer
    // 078 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 080 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ChallengeTourPIdolUnitDetailPopupView : DataModel
    {
        public UITabGroup?                              TabGroup                                { get; set; }
        public VoDaViMeRankView?                        VoDaViMeRankView                        { get; set; }
        public ButtonBase?                              ParameterDetailButton                   { get; set; }
        public List<ChallengeTourPIdolUnitPanelView>?   PIdolUnitPanelViews                     { get; set; }
        public ProduceCardContent?                      GoPCardPrefab                           { get; set; }
        public Transform?                               TrCardParent                            { get; set; }
        public UITextMeshProUGUI?                       CardCountText                           { get; set; }
        public List<GameObject>?                        ShowObjects                             { get; set; }
        public ChallengeTourUnitViewModel?              ViewModel                               { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ChallengeTourPIdolUnitDetailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourPIdolUnitDetailPopupView() { Pointer= p0 };

            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x20 TabGroup                    ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.VoDaViMeRankView                          = GetObject<VoDaViMeRankView>(new IntPtr(p + 0x028), ReversePrism.DataModels.VoDaViMeRankView.FromPointer); // 0x28 VoDaViMeRankView            ( ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer )
            value.ParameterDetailButton                     = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x30 ParameterDetailButton       ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.PIdolUnitPanelViews                       = GetObjectList<ChallengeTourPIdolUnitPanelView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChallengeTourPIdolUnitPanelView.FromPointer); // 0x38 PIdolUnitPanelViews         ( ModelClassListType ChallengeTourPIdolUnitPanelView[] ChallengeTourPIdolUnitPanelView[] List<ChallengeTourPIdolUnitPanelView> Pointer )
            value.GoPCardPrefab                             = GetObject<ProduceCardContent>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProduceCardContent.FromPointer); // 0x40 GoPCardPrefab               ( ModelClassType ProduceCardContent ProduceCardContent ProduceCardContent Pointer )
            value.TrCardParent                              = GetObject<Transform>(new IntPtr(p + 0x048), ReversePrism.DataModels.Transform.FromPointer); // 0x48 TrCardParent                ( ModelClassType Transform Transform Transform Pointer )
            value.CardCountText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 CardCountText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ShowObjects                               = GetObjectList<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 ShowObjects                 ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.ViewModel                                 = GetObject<ChallengeTourUnitViewModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.ChallengeTourUnitViewModel.FromPointer); // 0x70 ViewModel                   ( ModelClassType ChallengeTourUnitViewModel ChallengeTourUnitViewModel ChallengeTourUnitViewModel Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x078), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x78 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x080), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x80 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
